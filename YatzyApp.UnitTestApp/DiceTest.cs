using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using YatzyApp.Core;
namespace YatzyApp.UnitTestApp
{
    [TestClass]
    public class DiceTest
    {
        [TestMethod]
        public void CreateDiceTest()
        {
            for (int i = 1; i < 7; i++)
            {
                Dice d = new Dice(i);
                Assert.IsTrue(d.Value ==i);
                Assert.IsTrue(d.DiceValue() == "["+i+"]");
            }
           

        }
    }
}
