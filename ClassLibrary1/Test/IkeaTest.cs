using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Test
{
    public class IkeaTest
    {
        [TestCase( TestName = "Antklode")]
        public static void TestSumBlock(string result)
        {

            basePage.Ikea()
                .IsskleistiPrekiuJuosta()
                .PasirinktiAntklode()
                .IsskleistiDydziuFiltra()
                .PazymetiDydi150x200()
                .PasirinktiPreke()
                .IdetiIPirkiniuKrepseli()
                .PerziuretiPirkiniuKrepseli()                
                .PatikrintiRezultata(result);
        }
        [TestCase(TestName = "Dvigulių lovų rėmai")]
        public static void PrekeKrepseli(string result)
        {
            basePage.Ikea()
                .IsskleistiPrekiuJuosta()
                .PasirinktiDviguluLovuRemai()
                .PatikrintiDviguliuLovuRemaiRezultata(result);
        }
    }
}
