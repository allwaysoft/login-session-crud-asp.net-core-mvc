#pragma checksum "/home/rafael/Área de Trabalho/Etapa 05/projeto-destino-certo/Views/Home/Listar_Usuarios.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b91d6abbee0ad2eda38c066be4dde36ba8ec9446"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Listar_Usuarios), @"mvc.1.0.view", @"/Views/Home/Listar_Usuarios.cshtml")]
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
#line 1 "/home/rafael/Área de Trabalho/Etapa 05/projeto-destino-certo/Views/_ViewImports.cshtml"
using projeto_destino_certo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/rafael/Área de Trabalho/Etapa 05/projeto-destino-certo/Views/_ViewImports.cshtml"
using projeto_destino_certo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/home/rafael/Área de Trabalho/Etapa 05/projeto-destino-certo/Views/Home/Listar_Usuarios.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b91d6abbee0ad2eda38c066be4dde36ba8ec9446", @"/Views/Home/Listar_Usuarios.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62dc632e00c762f86a3e907f5348c6ae15d28f1b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Listar_Usuarios : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Usuario>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("icones-content"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/icone-userlist.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/icone-edit.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/icone-close2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/home/rafael/Área de Trabalho/Etapa 05/projeto-destino-certo/Views/Home/Listar_Usuarios.cshtml"
  
    ViewData["Title"] = "Listagem de Usuários";

#line default
#line hidden
#nullable disable
            WriteLiteral("<main class=\"fundo-color\" style=\"min-height: 100vh;\">\n<div class=\"usuarios-content\">  \n<div>\n    <div class=\"icone-titulo\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b91d6abbee0ad2eda38c066be4dde36ba8ec94465118", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"<h3 class=""titulos"">LISTAGEM DE USUÁRIOS</h3></div>
<p class=""paragrafos"">A lista com todos os usuários cadastrados no sistema será exibida abaixo. Utilize os botões da direita para realizar a exclusão ou alteração dos usuarios</p>
<p class=""paragrafos"">AVISO: Tenha cuidado ao excluir um usuário. Uma vez excluídos, os dados do registo relacionados ao usuário não poderão ser recuperados.</p>
<table class=""table"">
  <thead class=""thead-dark"">
    <tr>
      <th scope=""col"">ID</th>
      <th scope=""col"">NOME</th>
<!-- <th scope=""col"">DATA DE NASCIMENTO</th
     <th scope=""col"">LOGIN</th>
      <th scope=""col"">SENHA</th> 
     <th scope=""col"">TIPO DE CONTA</th> -->
      <th scope=""col""></th> 
      <th scope=""col""></th>

    </tr>
  </thead>
  <tbody>
");
#nullable restore
#line 27 "/home/rafael/Área de Trabalho/Etapa 05/projeto-destino-certo/Views/Home/Listar_Usuarios.cshtml"
      foreach(Usuario u in Model){

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\n      <th scope=\"row\">");
#nullable restore
#line 29 "/home/rafael/Área de Trabalho/Etapa 05/projeto-destino-certo/Views/Home/Listar_Usuarios.cshtml"
                 Write(u.id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\n      <td>");
#nullable restore
#line 30 "/home/rafael/Área de Trabalho/Etapa 05/projeto-destino-certo/Views/Home/Listar_Usuarios.cshtml"
     Write(u.nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n     <!-- <td>");
#nullable restore
#line 31 "/home/rafael/Área de Trabalho/Etapa 05/projeto-destino-certo/Views/Home/Listar_Usuarios.cshtml"
         Write(u.data_nascimento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \n      <td>");
#nullable restore
#line 32 "/home/rafael/Área de Trabalho/Etapa 05/projeto-destino-certo/Views/Home/Listar_Usuarios.cshtml"
     Write(u.login);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n      <td>");
#nullable restore
#line 33 "/home/rafael/Área de Trabalho/Etapa 05/projeto-destino-certo/Views/Home/Listar_Usuarios.cshtml"
     Write(u.senha);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> \n      <td>");
#nullable restore
#line 34 "/home/rafael/Área de Trabalho/Etapa 05/projeto-destino-certo/Views/Home/Listar_Usuarios.cshtml"
     Write(u.conta);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td> -->\n      <td><a");
            BeginWriteAttribute("href", " href=\"", 1284, "\"", 1321, 2);
            WriteAttributeValue("", 1291, "/Home/Alterar_Usuario?id=", 1291, 25, true);
#nullable restore
#line 35 "/home/rafael/Área de Trabalho/Etapa 05/projeto-destino-certo/Views/Home/Listar_Usuarios.cshtml"
WriteAttributeValue("", 1316, u.id, 1316, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b91d6abbee0ad2eda38c066be4dde36ba8ec94469179", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\n      <td><a");
            BeginWriteAttribute("href", " href=\"", 1396, "\"", 1433, 2);
            WriteAttributeValue("", 1403, "/Home/Excluir_Usuario?id=", 1403, 25, true);
#nullable restore
#line 36 "/home/rafael/Área de Trabalho/Etapa 05/projeto-destino-certo/Views/Home/Listar_Usuarios.cshtml"
WriteAttributeValue("", 1428, u.id, 1428, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b91d6abbee0ad2eda38c066be4dde36ba8ec944610742", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</a></td>\n    </tr>");
#nullable restore
#line 37 "/home/rafael/Área de Trabalho/Etapa 05/projeto-destino-certo/Views/Home/Listar_Usuarios.cshtml"
         } 

#line default
#line hidden
#nullable disable
            WriteLiteral("  </tbody>\n</table>\n\n</div>\n</main>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Usuario>> Html { get; private set; }
    }
}
#pragma warning restore 1591