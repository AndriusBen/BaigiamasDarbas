using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Test
{
    public class PaieskosTest : BaseTest
    {

        [TestCase("švelnaus uždarymo lankstai", TestName = "švelnaus užarymo lankstai")]
        public static void PaieskosSkiltis(string paieskosObjektas, string result)
        {            
            prekiuPaieskaPage.IeitiIPaieskosPuslapi()
                .IvedamasIeskomasObjektas(paieskosObjektas)
                .SpaudziamPaieskosMygtuka()
                .GaunamasRezultatas(result);



        }
    }
}
