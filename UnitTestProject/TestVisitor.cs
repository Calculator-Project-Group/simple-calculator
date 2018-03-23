using System;
using Antlr4.Runtime;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using calculator;

namespace UnitTestProject
{
    [TestClass]
    public class TestVisitor
    {
        [TestMethod]
        public void TestVisitExp()
        {
            string input = @"10 - 2 + 3*4.5";

            CalcTreeGenerator G = new CalcTreeGenerator();
            Calc_node node = G.Generate(input);

        }
    }
}
