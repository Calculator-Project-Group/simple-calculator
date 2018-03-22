using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using calculator;
using System.Windows;
using System.Threading;
using System.Windows.Controls;

namespace UnitTestProject
{
    [TestClass]
    public class TestRender
    {
        Value_node value1 = new Value_node
        {
            isint = true,
            result = 2333L
        };
        Value_node value2 = new Value_node
        {
            isint = true,
            result = 2018L
        };
        Value_node value3 = new Value_node
        {
            isint = true,
            result = 774L
        };
        Value_node value4 = new Value_node
        {
            isint = true,
            result = 123L
        };

        private void ShowWindow(Calc_node node)
        {
            MathRenderer renderer = new MathRenderer();
            Window window = new Window();
            window.Closed += (s, e) => window.Dispatcher.InvokeShutdown();
            Canvas block = renderer.RenderElement(node);
            window.Content = block;
            window.Show();
            System.Windows.Threading.Dispatcher.Run();
        }

        [TestMethod]
        public void TestRenderAdd()
        {
            
            Bracket_node bnode = new Bracket_node
            {
                internal_node = value1
            };
            Binary_node bin_node = new Binary_node
            {
                node1 = bnode,
                node2 = value2,
                op = Binary_node.Operator.ADD
            };

            ShowWindow(bin_node);

        }
        [TestMethod]
        public void TestRenderFraction()
        {
            Binary_node bin_node = new Binary_node
            {
                node1 = value1,
                node2 = value2,
                op = Binary_node.Operator.DIVIDE
            };
            ShowWindow(bin_node);
        }

        [TestMethod]
        public void TestRenderExpo()
        {
            Binary_node exp_node = new Binary_node
            {
                node1 = value1,
                node2 = value2,
                op = Binary_node.Operator.EXPO
            };
            ShowWindow(exp_node);
        }

        [TestMethod]
        public void TestLogExp()
        {
            Binary_node exp_node = new Binary_node
            {
                node1 = value1,
                node2 = value2,
                op = Binary_node.Operator.LOG
            };
            ShowWindow(exp_node);
        }

        [TestMethod]
        public void TestRenderMixExp1()
        {
            Binary_node exp_node = new Binary_node
            {
                node1 = value1,
                node2 = value2,
                op = Binary_node.Operator.EXPO
            };
            Binary_node pow_node = new Binary_node
            {
                node1 = value1,
                node2 = value2,
                op = Binary_node.Operator.EXPO
            };
            Binary_node log_node = new Binary_node
            {
                node1 = pow_node,
                node2 = exp_node,
                op = Binary_node.Operator.LOG
            };
            ShowWindow(log_node);
        }

        [TestMethod]
        public void TestRenderMixExp2()
        {
            Binary_node div_node1 = new Binary_node
            {
                node1 = value1,
                node2 = value2,
                op = Binary_node.Operator.DIVIDE
            };
            Binary_node div_node2 = new Binary_node
            {
                node1 = value3,
                node2 = value4,
                op = Binary_node.Operator.DIVIDE
            };
            Binary_node div_node = new Binary_node
            {
                node1 = div_node1,
                node2 = div_node2,
                op = Binary_node.Operator.DIVIDE
            };
            Binary_node pow_node0 = new Binary_node
            {
                node1 = div_node,
                node2 = value3,
                op = Binary_node.Operator.EXPO
            };
            Binary_node add_node = new Binary_node
            {
                node1 = pow_node0,
                node2 = value4,
                op = Binary_node.Operator.ADD
            };
            ShowWindow(add_node);
        }
    }
}
