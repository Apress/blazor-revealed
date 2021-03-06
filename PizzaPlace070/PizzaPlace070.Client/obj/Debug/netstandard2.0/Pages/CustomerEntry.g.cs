#pragma checksum "C:\Code\Blazor\PizzaPlace070\PizzaPlace070.Client\Pages\CustomerEntry.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e018363e503edd0b16c4d93013e523cf49d9da5c"
// <auto-generated/>
#pragma warning disable 1591
namespace PizzaPlace070.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Blazor;
    using Microsoft.AspNetCore.Blazor.Components;
    using System.Net.Http;
    using Microsoft.AspNetCore.Blazor.Layouts;
    using Microsoft.AspNetCore.Blazor.Routing;
    using Microsoft.JSInterop;
    using PizzaPlace070.Client;
    using PizzaPlace070.Client.Shared;
    using PizzaPlace070.Shared;
    using System.ComponentModel;
    [Microsoft.AspNetCore.Blazor.Layouts.LayoutAttribute(typeof(MainLayout))]

    public class CustomerEntry : Microsoft.AspNetCore.Blazor.Components.BlazorComponent
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Blazor.RenderTree.RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);
            builder.OpenElement(0, "h1");
            builder.AddContent(1, Title);
            builder.CloseElement();
            builder.AddContent(2, "\n\n");
            builder.OpenElement(3, "fieldset");
            builder.AddContent(4, "\n  ");
            builder.OpenElement(5, "p");
            builder.AddContent(6, "\n    ");
            builder.AddMarkupContent(7, "<label for=\"name\">Name:</label>\n    ");
            builder.OpenElement(8, "input");
            builder.AddAttribute(9, "id", "name");
            builder.AddAttribute(10, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(Customer.Name));
            builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => Customer.Name = __value, Customer.Name));
            builder.CloseElement();
            builder.AddContent(12, "\n    ");
            builder.OpenComponent<PizzaPlace070.Extensions.Validation.ValidationError>(13);
            builder.AddAttribute(14, "Subject", Microsoft.AspNetCore.Blazor.Components.RuntimeHelpers.TypeCheck<System.Object>(Customer));
            builder.AddAttribute(15, "Property", Microsoft.AspNetCore.Blazor.Components.RuntimeHelpers.TypeCheck<System.String>(nameof(Customer.Name)));
            builder.CloseComponent();
            builder.AddContent(16, "\n  ");
            builder.CloseElement();
            builder.AddContent(17, "\n  ");
            builder.OpenElement(18, "p");
            builder.AddContent(19, "\n    ");
            builder.AddMarkupContent(20, "<label for=\"street\">Street:</label>\n    ");
            builder.OpenElement(21, "input");
            builder.AddAttribute(22, "id", "street");
            builder.AddAttribute(23, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(Customer.Street));
            builder.AddAttribute(24, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => Customer.Street = __value, Customer.Street));
            builder.CloseElement();
            builder.AddContent(25, "\n    ");
            builder.OpenComponent<PizzaPlace070.Extensions.Validation.ValidationError>(26);
            builder.AddAttribute(27, "Subject", Microsoft.AspNetCore.Blazor.Components.RuntimeHelpers.TypeCheck<System.Object>(Customer));
            builder.AddAttribute(28, "Property", Microsoft.AspNetCore.Blazor.Components.RuntimeHelpers.TypeCheck<System.String>(nameof(Customer.Street)));
            builder.CloseComponent();
            builder.AddContent(29, "\n  ");
            builder.CloseElement();
            builder.AddContent(30, "\n  ");
            builder.OpenElement(31, "p");
            builder.AddContent(32, "\n    ");
            builder.AddMarkupContent(33, "<label for=\"city\">City:</label>\n    ");
            builder.OpenElement(34, "input");
            builder.AddAttribute(35, "id", "city");
            builder.AddAttribute(36, "value", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetValue(Customer.City));
            builder.AddAttribute(37, "onchange", Microsoft.AspNetCore.Blazor.Components.BindMethods.SetValueHandler(__value => Customer.City = __value, Customer.City));
            builder.CloseElement();
            builder.AddContent(38, "\n    ");
            builder.OpenComponent<PizzaPlace070.Extensions.Validation.ValidationError>(39);
            builder.AddAttribute(40, "Subject", Microsoft.AspNetCore.Blazor.Components.RuntimeHelpers.TypeCheck<System.Object>(Customer));
            builder.AddAttribute(41, "Property", Microsoft.AspNetCore.Blazor.Components.RuntimeHelpers.TypeCheck<System.String>(nameof(Customer.City)));
            builder.CloseComponent();
            builder.AddContent(42, "\n  ");
            builder.CloseElement();
            builder.AddContent(43, "\n\n  ");
            builder.OpenElement(44, "button");
            builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Blazor.Components.BindMethods.GetEventHandlerValue<Microsoft.AspNetCore.Blazor.UIMouseEventArgs>(()=>Submit(Customer)));
            builder.AddAttribute(46, "disabled", Customer.HasErrors);
            builder.AddContent(47, "\n    Checkout\n  ");
            builder.CloseElement();
            builder.AddContent(48, "\n");
            builder.CloseElement();
        }
        #pragma warning restore 1998
#line 33 "C:\Code\Blazor\PizzaPlace070\PizzaPlace070.Client\Pages\CustomerEntry.cshtml"
            

[Parameter]
protected string Title { get; set; }

[Parameter]
protected Customer Customer { get; set; }

[Parameter]
protected Action<Customer> Submit { get; set; }


#line default
#line hidden
    }
}
#pragma warning restore 1591
