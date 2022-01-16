using ClassLibrary1.Page;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Test
{
    class IkeaTest : BaseTest
    {
        [Test]
        public static void TestSumBlock()
        {
            
            basePage.IeitiIPuslapi()
                .AcceptCookies()
                .IsskleistiPrekiuJuosta()
                .PasirinktiAntklode()
                .IsskleistiDydziuFiltra()
                .PazymetiDydi150x200()
                .PasirinktiPreke()
                .IdetiIPirkiniuKrepseli()
                .PerziuretiPirkiniuKrepseli()                
                .PatikrintiRezultata("1");
        }
        [Test]
        public static void PrekiuKrepseli()
        {
            basePage.IeitiIPuslapi()
                .AcceptCookies()
                .IsskleistiPrekiuJuosta();
            prekiuPaieskaPage.PasirinktiDviguluLovuRemai()
                 .PatikrintiDviguliuLovuRemaiRezultata("Dvigulių lovų rėmai");
        }
        [Test]
        public static void Ispirktuves()
        {
            basePage.IeitiIPuslapi()
                .AcceptCookies();
            // .ZiuretiPasiulymusMygtuka()
            // .PrekesIki10()
            // .PatikrintiRezultata("Prekės iki 10 €")     
        }
    }
}
