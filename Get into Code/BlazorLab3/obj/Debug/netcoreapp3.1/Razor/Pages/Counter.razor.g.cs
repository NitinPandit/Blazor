#pragma checksum "C:\Users\Lenovo\source\repos\BlazorBook\BlazorLab3\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e99e22063aa1906f902dd98db8aeaf2a6dcd66e7"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorLab3.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Lenovo\source\repos\BlazorBook\BlazorLab3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Lenovo\source\repos\BlazorBook\BlazorLab3\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Lenovo\source\repos\BlazorBook\BlazorLab3\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Lenovo\source\repos\BlazorBook\BlazorLab3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Lenovo\source\repos\BlazorBook\BlazorLab3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Lenovo\source\repos\BlazorBook\BlazorLab3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Lenovo\source\repos\BlazorBook\BlazorLab3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Lenovo\source\repos\BlazorBook\BlazorLab3\_Imports.razor"
using BlazorLab3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Lenovo\source\repos\BlazorBook\BlazorLab3\_Imports.razor"
using BlazorLab3.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "container");
            __builder.AddMarkupContent(2, "\r\n        ");
            __builder.AddMarkupContent(3, "<h1>Clicks and Age Counter</h1>\r\n        ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "form-group");
            __builder.AddMarkupContent(6, "\r\n            ");
            __builder.AddMarkupContent(7, "<label class=\"col-md-12\">Click the button to count</label>\r\n            ");
            __builder.OpenElement(8, "button");
            __builder.AddAttribute(9, "class", "btn btn-primary");
            __builder.AddAttribute(10, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\Lenovo\source\repos\BlazorBook\BlazorLab3\Pages\Counter.razor"
                                                      IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(11, "Increment Count");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n            ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "alert alert-success");
            __builder.AddMarkupContent(15, "\r\n                Current count: ");
            __builder.AddContent(16, 
#nullable restore
#line 10 "C:\Users\Lenovo\source\repos\BlazorBook\BlazorLab3\Pages\Counter.razor"
                                currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "form-group");
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.AddMarkupContent(23, "<label class=\"col-md-12\">Select Date of Birth</label>\r\n            ");
            __builder.OpenElement(24, "input");
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\Lenovo\source\repos\BlazorBook\BlazorLab3\Pages\Counter.razor"
                                (ChangeEventArgs __e)=>{ dob = __e.Value.ToString(); }

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(26, "class", "form-control");
            __builder.AddAttribute(27, "type", "date");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n            ");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "class", "btn btn-primary");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\Lenovo\source\repos\BlazorBook\BlazorLab3\Pages\Counter.razor"
                                                      CalculateAge

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(32, "Calculate Age");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n            ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "alert alert-success");
            __builder.AddMarkupContent(36, "\r\n                Current Age: ");
            __builder.AddContent(37, 
#nullable restore
#line 18 "C:\Users\Lenovo\source\repos\BlazorBook\BlazorLab3\Pages\Counter.razor"
                              age

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n    ");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 23 "C:\Users\Lenovo\source\repos\BlazorBook\BlazorLab3\Pages\Counter.razor"
       
    private int currentCount = 0;

    int age;
    public string dob { get; set; }

    private void IncrementCount()
    {
        currentCount++;
    }

    private void CalculateAge()
    {
        age = (DateTime.Now-Convert.ToDateTime(dob)).Days / 365;
    }


#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
