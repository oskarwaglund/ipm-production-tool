#pragma checksum "C:\Users\oskar\source\repos\IpmProductionTool\Components\ProductionView.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6fd4157deed193fbe0d88dd51a35c6ad7898fd3"
// <auto-generated/>
#pragma warning disable 1591
namespace IpmProductionTool.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\oskar\source\repos\IpmProductionTool\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\oskar\source\repos\IpmProductionTool\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\oskar\source\repos\IpmProductionTool\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\oskar\source\repos\IpmProductionTool\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\oskar\source\repos\IpmProductionTool\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\oskar\source\repos\IpmProductionTool\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\oskar\source\repos\IpmProductionTool\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\oskar\source\repos\IpmProductionTool\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\oskar\source\repos\IpmProductionTool\_Imports.razor"
using IpmProductionTool;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\oskar\source\repos\IpmProductionTool\_Imports.razor"
using IpmProductionTool.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\oskar\source\repos\IpmProductionTool\Components\ProductionView.razor"
using IpmProductionTool.ViewModel;

#line default
#line hidden
#nullable disable
    public partial class ProductionView : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Upgrades</h3>\r\n\r\n");
            __builder.OpenElement(1, "table");
            __builder.OpenElement(2, "tr");
            __builder.AddMarkupContent(3, "<td>Underforge</td>\r\n        ");
            __builder.OpenElement(4, "td");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\oskar\source\repos\IpmProductionTool\Components\ProductionView.razor"
                              DecUnderforge

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(7, "-");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "td");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", "text");
            __builder.AddAttribute(12, "width", "20");
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 9 "C:\Users\oskar\source\repos\IpmProductionTool\Components\ProductionView.razor"
                                       UnderForgeLevel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => UnderForgeLevel = __value, UnderForgeLevel));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "td");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\oskar\source\repos\IpmProductionTool\Components\ProductionView.razor"
                              IncUnderforge

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, "+");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenElement(21, "tr");
            __builder.AddMarkupContent(22, "<td>Dorms</td>\r\n        ");
            __builder.OpenElement(23, "td");
            __builder.OpenElement(24, "button");
            __builder.AddAttribute(25, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 14 "C:\Users\oskar\source\repos\IpmProductionTool\Components\ProductionView.razor"
                              DecDorms

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(26, "-");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "td");
            __builder.OpenElement(29, "input");
            __builder.AddAttribute(30, "type", "text");
            __builder.AddAttribute(31, "width", "20");
            __builder.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 15 "C:\Users\oskar\source\repos\IpmProductionTool\Components\ProductionView.razor"
                                       DormsLevel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => DormsLevel = __value, DormsLevel));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n        ");
            __builder.OpenElement(35, "td");
            __builder.OpenElement(36, "button");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\oskar\source\repos\IpmProductionTool\Components\ProductionView.razor"
                              IncDorms

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(38, "+");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(40, "<h3>Alloys</h3>\r\n\r\n");
            __builder.OpenElement(41, "table");
#nullable restore
#line 24 "C:\Users\oskar\source\repos\IpmProductionTool\Components\ProductionView.razor"
     foreach (var alloy in alloys)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(42, 
#nullable restore
#line 26 "C:\Users\oskar\source\repos\IpmProductionTool\Components\ProductionView.razor"
         alloy

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 26 "C:\Users\oskar\source\repos\IpmProductionTool\Components\ProductionView.razor"
              
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n\r\n");
            __builder.AddMarkupContent(44, "<h3>Items</h3>\r\n\r\n");
            __builder.OpenElement(45, "table");
#nullable restore
#line 33 "C:\Users\oskar\source\repos\IpmProductionTool\Components\ProductionView.razor"
     foreach (var item in items)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(46, 
#nullable restore
#line 35 "C:\Users\oskar\source\repos\IpmProductionTool\Components\ProductionView.razor"
         item

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 35 "C:\Users\oskar\source\repos\IpmProductionTool\Components\ProductionView.razor"
             
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\oskar\source\repos\IpmProductionTool\Components\ProductionView.razor"
       
    public List<MarkupString> alloys;
    public List<MarkupString> items;

    private int underforgeLevel;
    private string? UnderForgeLevel { get => underforgeLevel.ToString(); set { return; } }

    private int dormsLevel;
    private string? DormsLevel { get => dormsLevel.ToString(); set { return; } }

    protected override void OnInitialized()
    {
        underforgeLevel = 0;
        dormsLevel = 0;
        Recalculate();
    }

    private void Recalculate()
    {
        var vm = new CalculatorVm();
        alloys = vm.GetAlloys(underforgeLevel, dormsLevel);
        items = vm.GetItems(underforgeLevel, dormsLevel);
    }

    private void DecUnderforge()
    {
        if (underforgeLevel > 0) underforgeLevel--;
        Recalculate();
    }

    private void IncUnderforge()
    {
        if (underforgeLevel < 11) underforgeLevel++;
        Recalculate();
    }

    private void DecDorms()
    {
        if (dormsLevel > 0) dormsLevel--;
        Recalculate();
    }

    private void IncDorms()
    {
        if (dormsLevel < 11) dormsLevel++;
        Recalculate();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591