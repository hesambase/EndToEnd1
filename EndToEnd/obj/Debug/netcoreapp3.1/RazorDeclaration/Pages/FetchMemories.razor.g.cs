#pragma checksum "E:\MyWorks\Hesam\Net Framework\C#\2019\BlazorCookieAuthInsertDatabase\EndToEnd\Pages\FetchMemories.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cb00c2cbc3f8231d5255126cfcd2a8bd51dfada9"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace EndToEnd.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\MyWorks\Hesam\Net Framework\C#\2019\BlazorCookieAuthInsertDatabase\EndToEnd\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\MyWorks\Hesam\Net Framework\C#\2019\BlazorCookieAuthInsertDatabase\EndToEnd\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\MyWorks\Hesam\Net Framework\C#\2019\BlazorCookieAuthInsertDatabase\EndToEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\MyWorks\Hesam\Net Framework\C#\2019\BlazorCookieAuthInsertDatabase\EndToEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\MyWorks\Hesam\Net Framework\C#\2019\BlazorCookieAuthInsertDatabase\EndToEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\MyWorks\Hesam\Net Framework\C#\2019\BlazorCookieAuthInsertDatabase\EndToEnd\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\MyWorks\Hesam\Net Framework\C#\2019\BlazorCookieAuthInsertDatabase\EndToEnd\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\MyWorks\Hesam\Net Framework\C#\2019\BlazorCookieAuthInsertDatabase\EndToEnd\_Imports.razor"
using EndToEnd;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\MyWorks\Hesam\Net Framework\C#\2019\BlazorCookieAuthInsertDatabase\EndToEnd\_Imports.razor"
using EndToEnd.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\MyWorks\Hesam\Net Framework\C#\2019\BlazorCookieAuthInsertDatabase\EndToEnd\Pages\FetchMemories.razor"
using EndToEnd.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\MyWorks\Hesam\Net Framework\C#\2019\BlazorCookieAuthInsertDatabase\EndToEnd\Pages\FetchMemories.razor"
using EndToEndDB.Data.EndToEnd;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/FetchMemories")]
    public partial class FetchMemories : OwningComponentBase<MemoriesService>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 124 "E:\MyWorks\Hesam\Net Framework\C#\2019\BlazorCookieAuthInsertDatabase\EndToEnd\Pages\FetchMemories.razor"
            
     public enum MemType
    {
       
        family=0,
       
        job=1,
        
        Social = 2,
        
        Travel = 3,
        
        Others =4

    }
  
    private MemType TypeOfMemories { get; set; } = MemType.family;

   

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
    }
}
#pragma warning restore 1591
