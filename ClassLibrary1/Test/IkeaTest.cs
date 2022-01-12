using ClassLibrary1.Page;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Test
{
    public class IkeaTest : BaseTest
    {
        [Test]
        public static void TestSumBlock(string result)
        {
            
            basePage.IeitiIPuslapi()
                .IsskleistiPrekiuJuosta()
                .PasirinktiAntklode()
                .IsskleistiDydziuFiltra()
                .PazymetiDydi150x200()
                .PasirinktiPreke()
                .IdetiIPirkiniuKrepseli()
                .PerziuretiPirkiniuKrepseli()                
                .PatikrintiRezultata(result);
        }
        [Test]
        public static void PrekiuKrepseli(string result)
        {
            basePage.IeitiIPuslapi()
                .IsskleistiPrekiuJuosta();
           prekiuPaieskaPage.PasirinktiDviguluLovuRemai()
                .PatikrintiDviguliuLovuRemaiRezultata(result);
        }
    }
}
