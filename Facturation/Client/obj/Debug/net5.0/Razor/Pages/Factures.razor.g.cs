#pragma checksum "C:\Users\levie\Documents\EPSI\B3\C#\Facturation\Facturation\Client\Pages\Factures.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f2033ad8ca605f9e9f53d314503377af88a4294"
// <auto-generated/>
#pragma warning disable 1591
namespace Facturation.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\levie\Documents\EPSI\B3\C#\Facturation\Facturation\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\levie\Documents\EPSI\B3\C#\Facturation\Facturation\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\levie\Documents\EPSI\B3\C#\Facturation\Facturation\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\levie\Documents\EPSI\B3\C#\Facturation\Facturation\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\levie\Documents\EPSI\B3\C#\Facturation\Facturation\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\levie\Documents\EPSI\B3\C#\Facturation\Facturation\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\levie\Documents\EPSI\B3\C#\Facturation\Facturation\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\levie\Documents\EPSI\B3\C#\Facturation\Facturation\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\levie\Documents\EPSI\B3\C#\Facturation\Facturation\Client\_Imports.razor"
using Facturation.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\levie\Documents\EPSI\B3\C#\Facturation\Facturation\Client\_Imports.razor"
using Facturation.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\levie\Documents\EPSI\B3\C#\Facturation\Facturation\Client\Pages\Factures.razor"
using Facturation.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/factures")]
    public partial class Factures : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Factures</h1>");
#nullable restore
#line 8 "C:\Users\levie\Documents\EPSI\B3\C#\Facturation\Facturation\Client\Pages\Factures.razor"
 if (factures.Count() == 0 && CAAttendu == null && CAReel == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 11 "C:\Users\levie\Documents\EPSI\B3\C#\Facturation\Facturation\Client\Pages\Factures.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "h2");
            __builder.AddContent(3, "Chiffre d\'affaire attendu: ");
            __builder.AddContent(4, 
#nullable restore
#line 14 "C:\Users\levie\Documents\EPSI\B3\C#\Facturation\Facturation\Client\Pages\Factures.razor"
                                CAAttendu

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(5, " €");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n");
            __builder.OpenElement(7, "h2");
            __builder.AddMarkupContent(8, "Chiffre d\'affaire réel: ");
            __builder.AddContent(9, 
#nullable restore
#line 15 "C:\Users\levie\Documents\EPSI\B3\C#\Facturation\Facturation\Client\Pages\Factures.razor"
                             CAReel

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(10, " €");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "container");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "row");
#nullable restore
#line 18 "C:\Users\levie\Documents\EPSI\B3\C#\Facturation\Facturation\Client\Pages\Factures.razor"
         foreach (var f in factures)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col-sm");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "card");
            __builder.AddAttribute(20, "style", "width: 18rem;");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "card-body");
            __builder.OpenElement(23, "h5");
            __builder.AddAttribute(24, "class", "card-title");
            __builder.AddContent(25, 
#nullable restore
#line 23 "C:\Users\levie\Documents\EPSI\B3\C#\Facturation\Facturation\Client\Pages\Factures.razor"
                                                f.Numero

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                        ");
            __builder.OpenElement(27, "p");
            __builder.AddAttribute(28, "class", "card-text");
            __builder.AddContent(29, 
#nullable restore
#line 24 "C:\Users\levie\Documents\EPSI\B3\C#\Facturation\Facturation\Client\Pages\Factures.razor"
                                              f.Client

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    ");
            __builder.OpenElement(31, "ul");
            __builder.AddAttribute(32, "class", "list-group list-group-flush");
            __builder.OpenElement(33, "li");
            __builder.AddAttribute(34, "class", "list-group-item");
            __builder.AddMarkupContent(35, "Date d\'émission: ");
            __builder.AddContent(36, 
#nullable restore
#line 27 "C:\Users\levie\Documents\EPSI\B3\C#\Facturation\Facturation\Client\Pages\Factures.razor"
                                                                      f.DateEmission

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                        ");
            __builder.OpenElement(38, "li");
            __builder.AddAttribute(39, "class", "list-group-item");
            __builder.AddMarkupContent(40, "Date de réglement: ");
            __builder.AddContent(41, 
#nullable restore
#line 28 "C:\Users\levie\Documents\EPSI\B3\C#\Facturation\Facturation\Client\Pages\Factures.razor"
                                                                        f.DateReglement

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                        ");
            __builder.OpenElement(43, "li");
            __builder.AddAttribute(44, "class", "list-group-item");
            __builder.AddMarkupContent(45, "Montant dû: ");
            __builder.AddContent(46, 
#nullable restore
#line 29 "C:\Users\levie\Documents\EPSI\B3\C#\Facturation\Facturation\Client\Pages\Factures.razor"
                                                                 f.MontantDu

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(47, " €");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n                        ");
            __builder.OpenElement(49, "li");
            __builder.AddAttribute(50, "class", "list-group-item");
            __builder.AddMarkupContent(51, "Montant réglé: ");
            __builder.AddContent(52, 
#nullable restore
#line 30 "C:\Users\levie\Documents\EPSI\B3\C#\Facturation\Facturation\Client\Pages\Factures.razor"
                                                                    f.MontantRegle

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(53, " €");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 34 "C:\Users\levie\Documents\EPSI\B3\C#\Facturation\Facturation\Client\Pages\Factures.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "C:\Users\levie\Documents\EPSI\B3\C#\Facturation\Facturation\Client\Pages\Factures.razor"
    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 39 "C:\Users\levie\Documents\EPSI\B3\C#\Facturation\Facturation\Client\Pages\Factures.razor"
           
        private List<Facture> factures;
        private double CAReel;
        private double CAAttendu;

        protected override async Task OnInitializedAsync()
        {
            DateTime d1 = DateTime.Now;

            factures = new List<Facture>();
            factures.Add(new Facture("Florian Pointet", "SC1425", d1, d1, 3045.99, 3045.99));
            factures.Add(new Facture("Bastien Leviez", "SC1426", d1, d1, 4045.99, 4045.99));

            double CAR = 0;
            double CAA = 0;
            foreach(Facture f in factures)
            {
                CAR += f.MontantRegle;
                CAA += f.MontantDu;
            }

            CAReel = CAR;
            CAAttendu = CAA;
        }

    

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
