#pragma checksum "C:\Documents\2021暑假\VS2019\Addition_API\Addition_API\Pages\ApiCrud.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "882dc8b223819f2dfd0b7b11f8ac8f6adc75242f"
// <auto-generated/>
#pragma warning disable 1591
namespace Addition_API.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Documents\2021暑假\VS2019\Addition_API\Addition_API\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Documents\2021暑假\VS2019\Addition_API\Addition_API\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Documents\2021暑假\VS2019\Addition_API\Addition_API\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Documents\2021暑假\VS2019\Addition_API\Addition_API\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Documents\2021暑假\VS2019\Addition_API\Addition_API\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Documents\2021暑假\VS2019\Addition_API\Addition_API\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Documents\2021暑假\VS2019\Addition_API\Addition_API\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Documents\2021暑假\VS2019\Addition_API\Addition_API\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Documents\2021暑假\VS2019\Addition_API\Addition_API\_Imports.razor"
using Addition_API;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Documents\2021暑假\VS2019\Addition_API\Addition_API\_Imports.razor"
using Addition_API.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Documents\2021暑假\VS2019\Addition_API\Addition_API\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Documents\2021暑假\VS2019\Addition_API\Addition_API\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/apiCrud")]
    public partial class ApiCrud : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>API Crud</h1>\r\n\r\n");
            __builder.OpenComponent<Radzen.Blazor.RadzenRadioButtonList<int>>(1);
            __builder.AddAttribute(2, "Change", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<int>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<int>(this, 
#nullable restore
#line 5 "C:\Documents\2021暑假\VS2019\Addition_API\Addition_API\Pages\ApiCrud.razor"
                                                                         (args) => ChooseAction(args)

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<int>(
#nullable restore
#line 5 "C:\Documents\2021暑假\VS2019\Addition_API\Addition_API\Pages\ApiCrud.razor"
                                     selectValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<int>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<int>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => selectValue = __value, selectValue))));
            __builder.AddAttribute(5, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<int>>>(() => selectValue));
            __builder.AddAttribute(6, "Items", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __Blazor.Addition_API.Pages.ApiCrud.TypeInference.CreateRadzenRadioButtonListItem_0(__builder2, 7, 8, "Create", 9, 
#nullable restore
#line 7 "C:\Documents\2021暑假\VS2019\Addition_API\Addition_API\Pages\ApiCrud.razor"
                                                        1

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(10, "\r\n        ");
                __Blazor.Addition_API.Pages.ApiCrud.TypeInference.CreateRadzenRadioButtonListItem_1(__builder2, 11, 12, "Read", 13, 
#nullable restore
#line 8 "C:\Documents\2021暑假\VS2019\Addition_API\Addition_API\Pages\ApiCrud.razor"
                                                      2

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(14, "\r\n        ");
                __Blazor.Addition_API.Pages.ApiCrud.TypeInference.CreateRadzenRadioButtonListItem_2(__builder2, 15, 16, "Update", 17, 
#nullable restore
#line 9 "C:\Documents\2021暑假\VS2019\Addition_API\Addition_API\Pages\ApiCrud.razor"
                                                        3

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(18, "\r\n        ");
                __Blazor.Addition_API.Pages.ApiCrud.TypeInference.CreateRadzenRadioButtonListItem_3(__builder2, 19, 20, "Delete", 21, 
#nullable restore
#line 10 "C:\Documents\2021暑假\VS2019\Addition_API\Addition_API\Pages\ApiCrud.razor"
                                                        4

#line default
#line hidden
#nullable disable
                );
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "C:\Documents\2021暑假\VS2019\Addition_API\Addition_API\Pages\ApiCrud.razor"
       
    private int selectValue;

    private void ChooseAction(int selected)
    {
        selectValue = selected;
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.Addition_API.Pages.ApiCrud
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateRadzenRadioButtonListItem_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenRadioButtonListItem<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Text", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateRadzenRadioButtonListItem_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenRadioButtonListItem<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Text", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateRadzenRadioButtonListItem_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenRadioButtonListItem<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Text", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateRadzenRadioButtonListItem_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.String __arg0, int __seq1, TValue __arg1)
        {
        __builder.OpenComponent<global::Radzen.Blazor.RadzenRadioButtonListItem<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Text", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591