#pragma checksum "C:\Users\Marky\Source\Repos\AzureFunctionsDemo\AzureFunctionsDemo\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f8046d8c2f9274cc008e2faef7e33941a791e2e"
// <auto-generated/>
#pragma warning disable 1591
namespace AzureFunctionsDemo.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Marky\Source\Repos\AzureFunctionsDemo\AzureFunctionsDemo\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Marky\Source\Repos\AzureFunctionsDemo\AzureFunctionsDemo\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Marky\Source\Repos\AzureFunctionsDemo\AzureFunctionsDemo\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Marky\Source\Repos\AzureFunctionsDemo\AzureFunctionsDemo\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Marky\Source\Repos\AzureFunctionsDemo\AzureFunctionsDemo\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Marky\Source\Repos\AzureFunctionsDemo\AzureFunctionsDemo\Client\_Imports.razor"
using AzureFunctionsDemo.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Marky\Source\Repos\AzureFunctionsDemo\AzureFunctionsDemo\Client\_Imports.razor"
using AzureFunctionsDemo.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Marky\Source\Repos\AzureFunctionsDemo\AzureFunctionsDemo\Client\Pages\Index.razor"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card");
            __builder.AddAttribute(2, "style", "z-index:8;");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.AddMarkupContent(4, "<div class=\"card-header\">\r\n            <h1>Azure Functions</h1>\r\n        </div>\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card-body");
            __builder.AddMarkupContent(7, "\r\n");
#nullable restore
#line 10 "C:\Users\Marky\Source\Repos\AzureFunctionsDemo\AzureFunctionsDemo\Client\Pages\Index.razor"
             if (SlideState == ((int)State.Intro))
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(8, "                ");
            __builder.OpenComponent<AzureFunctionsDemo.Client.Pages.Intro>(9);
            __builder.CloseComponent();
            __builder.AddMarkupContent(10, "\r\n");
#nullable restore
#line 13 "C:\Users\Marky\Source\Repos\AzureFunctionsDemo\AzureFunctionsDemo\Client\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Marky\Source\Repos\AzureFunctionsDemo\AzureFunctionsDemo\Client\Pages\Index.razor"
             if (SlideState == ((int)State.CoreVsFramework))
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "                ");
            __builder.OpenComponent<AzureFunctionsDemo.Client.Pages.CoreVFramework>(12);
            __builder.CloseComponent();
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 17 "C:\Users\Marky\Source\Repos\AzureFunctionsDemo\AzureFunctionsDemo\Client\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Marky\Source\Repos\AzureFunctionsDemo\AzureFunctionsDemo\Client\Pages\Index.razor"
             if (SlideState == ((int)State.WhatIsFunctions))
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(14, "                ");
            __builder.OpenComponent<AzureFunctionsDemo.Client.Pages.WhatIsFunctions>(15);
            __builder.CloseComponent();
            __builder.AddMarkupContent(16, "\r\n");
#nullable restore
#line 21 "C:\Users\Marky\Source\Repos\AzureFunctionsDemo\AzureFunctionsDemo\Client\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Marky\Source\Repos\AzureFunctionsDemo\AzureFunctionsDemo\Client\Pages\Index.razor"
             if (SlideState == ((int)State.ChangesInArchitecture))
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(17, "                ");
            __builder.OpenComponent<AzureFunctionsDemo.Client.Pages.ChangesInArchitecture>(18);
            __builder.CloseComponent();
            __builder.AddMarkupContent(19, "\r\n");
#nullable restore
#line 25 "C:\Users\Marky\Source\Repos\AzureFunctionsDemo\AzureFunctionsDemo\Client\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Marky\Source\Repos\AzureFunctionsDemo\AzureFunctionsDemo\Client\Pages\Index.razor"
             if (SlideState == ((int)State.Blazor))
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(20, "                ");
            __builder.OpenComponent<AzureFunctionsDemo.Client.Pages.Blazor>(21);
            __builder.CloseComponent();
            __builder.AddMarkupContent(22, "\r\n");
#nullable restore
#line 29 "C:\Users\Marky\Source\Repos\AzureFunctionsDemo\AzureFunctionsDemo\Client\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\Marky\Source\Repos\AzureFunctionsDemo\AzureFunctionsDemo\Client\Pages\Index.razor"
             if (SlideState == ((int)State.WhyServerless))
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(23, "                ");
            __builder.OpenComponent<AzureFunctionsDemo.Client.Pages.WhyNetServerless>(24);
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\r\n");
#nullable restore
#line 33 "C:\Users\Marky\Source\Repos\AzureFunctionsDemo\AzureFunctionsDemo\Client\Pages\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(26, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "card-footer");
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "row");
            __builder.AddMarkupContent(33, "\r\n                ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "col-6 col-lg-4");
            __builder.AddMarkupContent(36, "\r\n                    ");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "class", "btn btn-primary w-100 ml-1 mr-1");
            __builder.AddAttribute(39, "hidden", 
#nullable restore
#line 38 "C:\Users\Marky\Source\Repos\AzureFunctionsDemo\AzureFunctionsDemo\Client\Pages\Index.razor"
                                                                             SlideState.Equals((int)State.Intro)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\Marky\Source\Repos\AzureFunctionsDemo\AzureFunctionsDemo\Client\Pages\Index.razor"
                                                                                                                            Back

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(41, "Previous");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                ");
            __builder.OpenElement(44, "div");
            __builder.AddAttribute(45, "class", "col-6 col-lg-4");
            __builder.AddMarkupContent(46, "\r\n                    ");
            __builder.OpenElement(47, "button");
            __builder.AddAttribute(48, "class", "btn btn-secondary w-100 ml-1 mr-1");
            __builder.AddAttribute(49, "hidden", 
#nullable restore
#line 41 "C:\Users\Marky\Source\Repos\AzureFunctionsDemo\AzureFunctionsDemo\Client\Pages\Index.razor"
                                                                               SlideState.Equals((int)State.WhyServerless)

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(50, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\Marky\Source\Repos\AzureFunctionsDemo\AzureFunctionsDemo\Client\Pages\Index.razor"
                                                                                                                                      Next

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(51, "Next");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n\r\n    ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "mt-3");
            __builder.AddMarkupContent(59, "\r\n        ");
            __builder.OpenComponent<AzureFunctionsDemo.Client.Pages.Counter>(60);
            __builder.CloseComponent();
            __builder.AddMarkupContent(61, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 51 "C:\Users\Marky\Source\Repos\AzureFunctionsDemo\AzureFunctionsDemo\Client\Pages\Index.razor"
      
    private enum State { Intro, CoreVsFramework, WhatIsFunctions, ChangesInArchitecture, Blazor, WhyServerless }
    private int SlideState = 0;

    void Back()
    {
        UpdateState(true);
    }

    void Next()
    {
        UpdateState(false);
    }

    async Task UpdateState(bool back)
    {//http://localhost:7071
        var endpoint = $"https://mk-azure-blazor-demo.azurewebsites.net/api/BlazorDemoStateHttpTrigger?back="+(back ? "true":"false");
        SlideState = await http.PostJsonAsync<int>(endpoint, new {state = SlideState});
        Console.WriteLine("Response = " + SlideState);
        this.StateHasChanged();
    }
    


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient http { get; set; }
    }
}
#pragma warning restore 1591
