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
        [TestCase("")]
        public static void PrekiuKrepseli(string rezult)
        {
            basePage.IeitiIPuslapi()
                .IsskleistiPrekiuJuosta();
            prekiuPaieskaPage.PasirinktiDviguluLovuRemai()
                 .PatikrintiDviguliuLovuRemaiRezultata(result);
        }
        [Test]
        public static void Ispirktuves(string result)
        {
            basePage.IeitiIPuslapi();
           // spirktuvesPage.
        } 
    }
}
