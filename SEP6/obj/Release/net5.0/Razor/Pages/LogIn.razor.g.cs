#pragma checksum "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\LogIn.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2671293423aa9c926a84f830a6a2f30182ee7ebf"
// <auto-generated/>
#pragma warning disable 1591
namespace SEP6.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using SEP6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using SEP6.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\LogIn.razor"
using SEP6.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\LogIn.razor"
using SEP6.Temporary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\LogIn.razor"
using Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/login")]
    public partial class LogIn : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "loginContainer");
            __builder.AddAttribute(2, "b-iwscbyh8bk");
            __builder.AddMarkupContent(3, "<div class=\"logo-container\" b-iwscbyh8bk><img src=\"images/Logo.jpg\" alt=\"Imperium Movie Logo\" class=\"logo-img\" b-iwscbyh8bk></div>\r\n\r\n    ");
            __builder.OpenElement(4, "form");
            __builder.AddAttribute(5, "class", "formContainer");
            __builder.AddAttribute(6, "onsubmit", global::Microsoft.AspNetCore.Components.EventCallback.Factory.Create<global::System.EventArgs>(this, 
#nullable restore
#line 15 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\LogIn.razor"
                                           LogInUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "method", "POST");
            __builder.AddAttribute(8, "b-iwscbyh8bk");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "form-group");
            __builder.AddAttribute(11, "b-iwscbyh8bk");
            __builder.AddMarkupContent(12, "<label for=\"username\" b-iwscbyh8bk>Username</label>\r\n            ");
            __builder.OpenElement(13, "input");
            __builder.AddAttribute(14, "type", "text");
            __builder.AddAttribute(15, "class", "form-control custom-input");
            __builder.AddAttribute(16, "placeholder", "Enter your username");
            __builder.AddAttribute(17, "required");
            __builder.AddAttribute(18, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 18 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\LogIn.razor"
                                                                        username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(19, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(20, "b-iwscbyh8bk");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n        ");
            __builder.OpenElement(22, "div");
            __builder.AddAttribute(23, "class", "form-group");
            __builder.AddAttribute(24, "b-iwscbyh8bk");
            __builder.AddMarkupContent(25, "<label for=\"password\" b-iwscbyh8bk>Password</label>\r\n            ");
            __builder.OpenElement(26, "input");
            __builder.AddAttribute(27, "type", "password");
            __builder.AddAttribute(28, "class", "form-control custom-input");
            __builder.AddAttribute(29, "placeholder", "Enter your password");
            __builder.AddAttribute(30, "required");
            __builder.AddAttribute(31, "value", global::Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 22 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\LogIn.razor"
                                                                            password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "onchange", global::Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(33, "b-iwscbyh8bk");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.AddMarkupContent(35, "<div class=\"text-center\" b-iwscbyh8bk><button type=\"submit\" class=\"btn custom-button\" b-iwscbyh8bk>Log in</button></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n\r\n    ");
            __builder.AddMarkupContent(37, "<div class=\"text-center mt-3\" b-iwscbyh8bk>\r\n        Don\'t have an account? <a href=\"/register\" class=\"register-link\" b-iwscbyh8bk>Register here!</a></div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\LogIn.razor"
       
    private string username;
    private string password;

    private async Task LogInUser()
    {
        try
        {
            DataSession.User=await DatabaseRetriever.LogIn(username, password);
            if (DataSession.User == null)
            {
                await JsRuntime.InvokeVoidAsync("alert", "The credentials are incorrect.");
                await OnInitializedAsync();
            }
            else
            {
                DataSession.LastLink = "/movielist";
                Navigation.NavigateTo("/movielist");
            }

        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataSession DataSession { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IDatabaseRetriever DatabaseRetriever { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591
