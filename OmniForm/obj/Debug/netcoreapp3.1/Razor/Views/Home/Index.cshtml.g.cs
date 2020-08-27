#pragma checksum "C:\workspace\OmniForm\OmniForm\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df26a284c27e3b97c0a8beef1a60d6dd17c10e76"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\workspace\OmniForm\OmniForm\Views\_ViewImports.cshtml"
using OmniForm;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\workspace\OmniForm\OmniForm\Views\_ViewImports.cshtml"
using OmniForm.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\workspace\OmniForm\OmniForm\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\workspace\OmniForm\OmniForm\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\workspace\OmniForm\OmniForm\Views\_ViewImports.cshtml"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\workspace\OmniForm\OmniForm\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\workspace\OmniForm\OmniForm\Views\_ViewImports.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\workspace\OmniForm\OmniForm\Views\_ViewImports.cshtml"
using System.Threading.Tasks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\workspace\OmniForm\OmniForm\Views\_ViewImports.cshtml"
using System.Linq;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df26a284c27e3b97c0a8beef1a60d6dd17c10e76", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"877d4f6c593ef35b547ea617d7d115ddefde0f0c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\workspace\OmniForm\OmniForm\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Início";

    string NormalName = "";
    var CurrentUser = new OmniForm.Data.Model.CustomerUser();
    if (signInManager.IsSignedIn(User))
    {
        //CurrentUser = await userManager.FindByNameAsync(User.Identity.Name);
        CurrentUser = await userManager.Users.Where(u => u.Email == User.Identity.Name).Include(u => u.PhoneNumbers).FirstAsync();
        NormalName = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(CurrentUser.FullName.ToLower());
    }


#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""row"">
        <div class=""col text-center"">
            <h1 class=""display-1 text-white"">Bemol Registro</h1>
            <h3 class=""text-white-50 font-weight-light"">
                Acesso a todos os nossos serviços, com apenas um Registro!
            </h3>
        </div>
    </div>
    <div class=""row mt-lg-5"">
        <div class=""col text-center text-white"">
");
#nullable restore
#line 28 "C:\workspace\OmniForm\OmniForm\Views\Home\Index.cshtml"
             if (!signInManager.IsSignedIn(User))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h5>\r\n                    Realize seu\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df26a284c27e3b97c0a8beef1a60d6dd17c10e766674", async() => {
                WriteLiteral("\r\n                        CADASTRO\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    agora!\r\n                </h5>\r\n                <h5>\r\n                    Já possui cadastro? Então\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "df26a284c27e3b97c0a8beef1a60d6dd17c10e768320", async() => {
                WriteLiteral("\r\n                        CLIQUE AQUI\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    para realizar o Login!\r\n                </h5>\r\n");
#nullable restore
#line 44 "C:\workspace\OmniForm\OmniForm\Views\Home\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <h5>Olá ");
#nullable restore
#line 47 "C:\workspace\OmniForm\OmniForm\Views\Home\Index.cshtml"
                   Write(NormalName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h5>
                <div class=""card text-dark text-left"">
                    <div class=""card-body"">
                        <div class=""row"">
                            <h5 class=""col text-center"">Estas são suas Informações cadastradas no sistema:</h5>
                        </div>
                        <div class=""row"">
                            <div class=""col"">
                                <dl>
                                    <dt>Nome Completo</dt>
                                    <dd>");
#nullable restore
#line 57 "C:\workspace\OmniForm\OmniForm\Views\Home\Index.cshtml"
                                   Write(CurrentUser.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                                    <dt>CPF</dt>\r\n                                    <dd>");
#nullable restore
#line 59 "C:\workspace\OmniForm\OmniForm\Views\Home\Index.cshtml"
                                   Write(CurrentUser.Cpf);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                                    <dt>RG</dt>\r\n                                    <dd>");
#nullable restore
#line 61 "C:\workspace\OmniForm\OmniForm\Views\Home\Index.cshtml"
                                   Write(CurrentUser.Rg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                                    <dt>Sexo</dt>\r\n                                    <dd>");
#nullable restore
#line 63 "C:\workspace\OmniForm\OmniForm\Views\Home\Index.cshtml"
                                   Write(CurrentUser.Sex);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                                    <dt>Data de Nascimento</dt>\r\n                                    <dd>");
#nullable restore
#line 65 "C:\workspace\OmniForm\OmniForm\Views\Home\Index.cshtml"
                                   Write(CurrentUser.Birthday.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</dd>
                                </dl>
                            </div>
                            <div class=""col"">
                                <dl>
                                    <dt>Endereço</dt>
                                    <dd>");
#nullable restore
#line 71 "C:\workspace\OmniForm\OmniForm\Views\Home\Index.cshtml"
                                   Write(CurrentUser.Street);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 71 "C:\workspace\OmniForm\OmniForm\Views\Home\Index.cshtml"
                                                        Write(CurrentUser.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 71 "C:\workspace\OmniForm\OmniForm\Views\Home\Index.cshtml"
                                                                             Write(CurrentUser.Neighborhood);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                                    <dt>Localidade</dt>\r\n                                    <dd>");
#nullable restore
#line 73 "C:\workspace\OmniForm\OmniForm\Views\Home\Index.cshtml"
                                   Write(CurrentUser.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 73 "C:\workspace\OmniForm\OmniForm\Views\Home\Index.cshtml"
                                                      Write(CurrentUser.State);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                                    <dt>CEP</dt>\r\n                                    <dd>");
#nullable restore
#line 75 "C:\workspace\OmniForm\OmniForm\Views\Home\Index.cshtml"
                                   Write(CurrentUser.Cep);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                                    <dt>Telefone</dt>\r\n                                    <div class=\"row\">\r\n");
#nullable restore
#line 78 "C:\workspace\OmniForm\OmniForm\Views\Home\Index.cshtml"
                                         foreach (var phone in CurrentUser.PhoneNumbers)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <dd class=\"col\">");
#nullable restore
#line 80 "C:\workspace\OmniForm\OmniForm\Views\Home\Index.cshtml"
                                                       Write(phone.Number);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n");
#nullable restore
#line 81 "C:\workspace\OmniForm\OmniForm\Views\Home\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                    <dt>E-Mail</dt>\r\n                                    <dd>");
#nullable restore
#line 84 "C:\workspace\OmniForm\OmniForm\Views\Home\Index.cshtml"
                                   Write(CurrentUser.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                                </dl>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 90 "C:\workspace\OmniForm\OmniForm\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<OmniForm.Data.Model.CustomerUser> userManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<OmniForm.Data.Model.CustomerUser> signInManager { get; private set; }
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
