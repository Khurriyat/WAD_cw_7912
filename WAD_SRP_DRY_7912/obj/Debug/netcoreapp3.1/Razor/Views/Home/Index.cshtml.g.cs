#pragma checksum "C:\Users\Khurriyat\Desktop\WAD_PetCare_7912\WAD_SRP_DRY_7912\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7169d7b3546ff0308fb131d43a25db79cf619208"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Khurriyat\Desktop\WAD_PetCare_7912\WAD_SRP_DRY_7912\Views\_ViewImports.cshtml"
using WAD_SRP_DRY_7912;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Khurriyat\Desktop\WAD_PetCare_7912\WAD_SRP_DRY_7912\Views\_ViewImports.cshtml"
using WAD_PetCare_7912_DAL.DBO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7169d7b3546ff0308fb131d43a25db79cf619208", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72858dfb7a91cbaed87df6d39d71fbcad3806a90", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-horizontal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/action_page.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Khurriyat\Desktop\WAD_PetCare_7912\WAD_SRP_DRY_7912\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "API Client Angular Professionals";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Professionals</h1>

<script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js""></script>
<script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>

<div id=""professionalsContainer"" ng-app=""professionalsApp"">
    <div ng-controller=""professionalsController"">

        <div class=""alert alert-info"" ng-if=""message"">
            <a href=""#"" class=""close"" ng-click=""clearMessage()"">&times;</a>
            {{message}}
        </div>

        <table class=""table table-bordered"">
            <tbody>

                <tr>
                    <td>
                        <strong>Id</strong>
                    </td>
                    <td>
                        <strong>First Name</strong>
                    </td>
                    <td>
                        <strong>Last Name</strong>
                    </td>
                    <td>
                        <strong>Date of Birth</strong>
                    </td>
            ");
            WriteLiteral(@"        <td>
                        <strong>Education</strong>
                    </td>
                    <td>
                        <strong>Work Experience</strong>
                    </td>
                    <td>
                        <strong>Speciality</strong>
                    </td>
                    <td>
                        <strong>Phone Number</strong>
                    </td>
                    <td>
                        <strong>Email</strong>
                    </td>
                    <td>
                        <strong>Address</strong>
                    </td>
                    <td>
                        <strong>Delete</strong>
                    </td>
                    <td>
                        <strong>Edit</strong>
                    </td>
                </tr>

                <tr ng-repeat=""professional in professionals"">
                    <td>
                        {{professional.id}}
                    </td>
             ");
            WriteLiteral(@"       <td>
                        {{professional.firstName}}
                    </td>
                    <td>
                        {{professional.lastName}}
                    </td>
                    <td>
                        <label ng-bind=""formatDate(professional.doB) | date:'dd/MM/yyyy'""></label>
                    </td>
                    <td>
                        {{professional.education}}
                    </td>
                    <td>
                        {{professional.workExperience}}
                    </td>
                    <td>
                        {{professional.speciality}}
                    </td>
                    <td>
                        {{professional.phoneNo}}
                    </td>
                    <td>
                        {{professional.email}}
                    </td>
                    <td>
                        {{professional.address}}
                    </td>
                    <td>
                     ");
            WriteLiteral(@"   <input type=""button"" class=""btn btn-danger"" value=""x"" ng-click=""delete(professional)"" />
                    </td>
                    <td>
                        <button type=""button"" class=""btn btn-info"" data-toggle=""modal"" data-target=""#myModal"" ng-click=""selectProfessional(professional)"">Edit</button>
                    </td>
                </tr>
            </tbody>

            <tfoot>
                <tr>
                    <td></td>
                    <td>
                        <input ng-model=""firstName"" placeholder=""First name"" type=""text"" />
                    </td>
                    <td>
                        <input ng-model=""lastName"" placeholder=""Last name"" type=""text"" />
                    </td>
                    <td>
                        <input ng-model=""doB"" placeholder=""Date of Birth"" type=""date"" />
                    </td>
                    <td>
                        <input ng-model=""education"" placeholder=""Education"" type=""text"" />
          ");
            WriteLiteral(@"          </td>
                    <td>
                        <input ng-model=""workExperience"" placeholder=""Work experience"" type=""text"" />
                    </td>
                    <td>
                        <input ng-model=""speciality"" placeholder=""Speciality"" type=""text"" />
                    </td>
                    <td>
                        <input ng-model=""phoneNo"" placeholder=""Phone number"" type=""text"" />
                    </td>
                    <td>
                        <input ng-model=""email"" placeholder=""Email"" type=""email"" />
                    </td>
                    <td>
                        <input ng-model=""address"" placeholder=""Address"" type=""text"" />
                    </td>
                    <td>
                        <input class=""btn btn-primary"" ng-click=""add()"" type=""button"" value=""+"" />
                    </td>
                    <td></td>
                </tr>
            </tfoot>
        </table>

        <div class=""modal fade");
            WriteLiteral(@""" id=""myModal"" role=""dialog"">
            <div class=""modal-dialog"">

                <div class=""modal-content"">
                    <div class=""modal-header"">
                        <h4 class=""modal-title"">Edit Professional</h4>
                        <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
                    </div>

                    <div class=""modal-body"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7169d7b3546ff0308fb131d43a25db79cf61920810064", async() => {
                WriteLiteral(@"

                            <div class=""form-group"">
                                <label class=""control-label col-sm-10"">First Name</label>
                                <div class=""col-sm-10"">
                                    <input type=""text"" class=""form-control"" ng-model=""clickedProfessional.firstName"">
                                </div>
                            </div>

                            <div class=""form-group"">
                                <label class=""control-label col-sm-10"">Last Name</label>
                                <div class=""col-sm-10"">
                                    <input type=""text"" class=""form-control"" ng-model=""clickedProfessional.lastName"">
                                </div>
                            </div>

                            <div class=""form-group"">
                                <label class=""control-label col-sm-10"">Date of Birth</label>
                                <div class=""col-sm-10"">
                   ");
                WriteLiteral(@"                 <input type=""date"" class=""form-control"" ng-model=""clickedProfessional.doB"">
                                </div>
                            </div>

                            <div class=""form-group"">
                                <label class=""control-label col-sm-2"">Education</label>
                                <div class=""col-sm-10"">
                                    <input type=""text"" class=""form-control"" ng-model=""clickedProfessional.education"">
                                </div>
                            </div>

                            <div class=""form-group"">
                                <label class=""control-label col-sm-10"">Work Experience</label>
                                <div class=""col-sm-10"">
                                    <input type=""text"" class=""form-control"" ng-model=""clickedProfessional.workExperience"">
                                </div>
                            </div>

                            <div class=""form-g");
                WriteLiteral(@"roup"">
                                <label class=""control-label col-sm-2"">Speciality</label>
                                <div class=""col-sm-10"">
                                    <input type=""text"" class=""form-control"" ng-model=""clickedProfessional.speciality"">
                                </div>
                            </div>

                            <div class=""form-group"">
                                <label class=""control-label col-sm-10"">Phone Number</label>
                                <div class=""col-sm-10"">
                                    <input type=""text"" class=""form-control"" ng-model=""clickedProfessional.phoneNo"">
                                </div>
                            </div>

                            <div class=""form-group"">
                                <label class=""control-label col-sm-2"">Email</label>
                                <div class=""col-sm-10"">
                                    <input type=""email"" class=""form-control""");
                WriteLiteral(@" ng-model=""clickedProfessional.email"">
                                </div>
                            </div>

                            <div class=""form-group"">
                                <label class=""control-label col-sm-2"">Address</label>
                                <div class=""col-sm-10"">
                                    <input type=""text"" class=""form-control"" ng-model=""clickedProfessional.address"">
                                </div>
                            </div>

                            <div class=""form-group"">
                                <div class=""col-sm-offset-2 col-sm-10"">
                                    <button type=""submit"" class=""btn btn-info"" data-dismiss=""modal"" ng-click=""update()"">Save</button>
                                </div>
                            </div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>

                    <div class=""modal-footer"">
                        <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Close</button>
                    </div>
                </div>
            </div>
        </div>

    </div>
</div>



");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script src=""https://ajax.googleapis.com/ajax/libs/angularjs/1.8.2/angular.min.js"" type=""text/javascript""></script>
    <script>
        angular.module('professionalsApp', [])
            .controller('professionalsController', function ($scope, $http) {
                $http.get(""");
#nullable restore
#line 240 "C:\Users\Khurriyat\Desktop\WAD_PetCare_7912\WAD_SRP_DRY_7912\Views\Home\Index.cshtml"
                      Write(Url.Action("GetProfessionals", "Professionals"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""").then(function (response) {
                    $scope.professionals = response.data;
                });

                $scope.formatDate = function (date) {
                    return new Date(date);
                }

                $scope.clickedProfessional = {};
                $scope.selectProfessional = function (professional) {
                    $scope.clickedProfessional = professional;
                };
                $scope.message = """";


                $scope.update = function () {
                    $scope.message = ""Professional is updated successfully!"";
                };


                $scope.add = function () {
                    var professional = {
                        firstName: $scope.firstName,
                        lastName: $scope.lastName,
                        doB: $scope.doB,
                        education: $scope.education,
                        workExperience: $scope.workExperience,
                        speciality: $scope");
                WriteLiteral(".speciality,\r\n                        phoneNo: $scope.phoneNo,\r\n                        email: $scope.email,\r\n                        address: $scope.address\r\n                    };\r\n\r\n                    $http.post(\"");
#nullable restore
#line 273 "C:\Users\Khurriyat\Desktop\WAD_PetCare_7912\WAD_SRP_DRY_7912\Views\Home\Index.cshtml"
                           Write(Url.Action("PostProfessional", "Professionals"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@""", professional).then(function (response) {
                        $scope.professionals.push(response.data);
                    });

                    $scope.firstName = '';
                    $scope.lastName = '';
                    $scope.doB = '';
                    $scope.education = '';
                    $scope.workExperience = '';
                    $scope.speciality = '';
                    $scope.phoneNo = '';
                    $scope.email = '';
                    $scope.address = '';

                    $scope.message = ""New professional is added successfully!"";
                }
                $scope.delete = function (professional) {
                    var result = confirm(""Do you want to delete the professional?"")
                    if (result == true) {
                        $http.delete(""");
#nullable restore
#line 292 "C:\Users\Khurriyat\Desktop\WAD_PetCare_7912\WAD_SRP_DRY_7912\Views\Home\Index.cshtml"
                                 Write(Url.Action("PostProfessional", "Professionals"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"/"" + professional.id).then(function (response) {
                            var index = $scope.professionals.indexOf(professional);
                            $scope.professionals.splice(index, 1);
                            $scope.message = ""Professional is deleted successfully!"";
                        });
                    }
                }

                $scope.clearMessage = function () {
                    $scope.message = """";
                };
            });
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
