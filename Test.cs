using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodcalculateLength()
        {
            MyClass myClass = new MyClass();
            Assert.AreEqual(myClass.calculateLength(1, 4, 1, 2), 2);

        }
    }
}
