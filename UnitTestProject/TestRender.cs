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
        
        [TestMethod]
        public void TestMethod1()
        {
            Value_node value = new Value_node
            {
                isint = true,
                result = 50233L
            };
            Value_node value2 = new Value_node
            {
                isint = true,
                result = 2018L
            };
            value.Calculate();
            Bracket_node bnode = new Bracket_node
            {
                internal_node = value
            };
            Binary_node bin_node = new Binary_node
            {
                node1 = bnode,
                node2 = value2,
                op = Binary_node.Operator.ADD
            };

            MathRenderer renderer = new MathRenderer();
            Window window = null;
            Thread t = new Thread(() =>
            {
                window = new Window();

                // Initiates the dispatcher thread shutdown when the window closes
                window.Closed += (s, e) => window.Dispatcher.InvokeShutdown();

                Canvas block = renderer.RenderElement(bin_node);
                window.Content = block;
                window.Show();

                // Makes the thread support message pumping
                System.Windows.Threading.Dispatcher.Run();
            });

            
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();

        }
        [TestMethod]
        public void TestFraction()
        {
            Value_node value1 = new Value_node
            {
                isint = true,
                result = 50233L
            };
            Value_node value2 = new Value_node
            {
                isint = true,
                result = 2018L
            };
            Binary_node bin_node = new Binary_node
            {
                node1 = value1,
                node2 = value2,
                op = Binary_node.Operator.DIVIDE
            };
            MathRenderer renderer = new MathRenderer();
            Window window = new Window();
            window.Closed += (s, e) => window.Dispatcher.InvokeShutdown();
            Canvas block = renderer.RenderElement(bin_node);
            window.Content = block;
            window.Show();
            System.Windows.Threading.Dispatcher.Run();
        }
    }
}
