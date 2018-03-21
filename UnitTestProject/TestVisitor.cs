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
            string input = @"1 - 2";

            var stream = new AntlrInputStream(input);
            var lexer = new CalcLexer(stream);
            var tokens = new CommonTokenStream(lexer);
            var parser = new CalcParser(tokens);
            var tree = parser.exp();

            var visitor = new CalcVisitor();
            var result = visitor.Visit(tree);


            //Console.WriteLine(tree.ToStringTree(parser));
            //Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
