using System;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinalAssignment;

namespace UnitTestProjectProgram
{
    [TestClass]
    public class TriangleTest
    {
        int texturestyle;
        Brush bb;
        Color c1 = Color.Black;

        [TestMethod]
        public void TestMethod1()
        {
            var t = new FinalAssignment.Triangle();
            int xi1 = 100, yi1 = 200, xi2 = 200, yi2 = 200, xii1 = 200, yii1 = 200, xii2 = 200,
                yii2 = 200, xiii1 = 200, yiii1 = 200, xiii2 = 200, yiii2 = 200;
            t.set(texturestyle, bb, c1, xi1, yi1, xi2, yi2, xii1, yii1, xii2, yii2, xiii1, yiii1, xiii2, yiii2);
            Assert.AreEqual(100, t.xi1);
        }
    }
}
