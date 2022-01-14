using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Test
{
    class PaieskosTest : BaseTest
    {

        [TestCase("švelnaus uždarymo lankstai", TestName = "švelnaus užarymo lankstai")]
        public static void PaieskosSkiltis(string ieskomasObjektas, string result)
        {
            prekiuPaieskaPage.IeitiIPuslapi();
                //.IvedamasIeskomasObjektas(ieskomasObjektas)
                //.SpaudziamPaieskosMygtuka()
                //.GaunamasRezultatas(result);



        }
    }
}
