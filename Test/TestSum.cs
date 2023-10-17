using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTZ.Vista.Responsabilitis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class TestSum
    {
        [TestMethod]
        public void testSum()
        {
            Sum suma = new Sum();
            
            int result= suma.sum(1, 1);
            int expect = 2;
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(result,expect);
        }
    }
}
