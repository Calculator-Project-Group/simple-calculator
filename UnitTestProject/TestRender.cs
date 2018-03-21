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
            value.Calculate();
            Bracket_node bnode = new Bracket_node
            {
                internal_node = value
            };

            MathRenderer renderer = new MathRenderer();
            Window window = null;
            Thread t = new Thread(() =>
            {
                window = new Window();

                // Initiates the dispatcher thread shutdown when the window closes
                window.Closed += (s, e) => window.Dispatcher.InvokeShutdown();

                Canvas block = renderer.RenderElement(bnode);
                window.Content = block;
                window.Show();

                // Makes the thread support message pumping
                System.Windows.Threading.Dispatcher.Run();
            });

            
            t.SetApartmentState(ApartmentState.STA);
            t.Start();
            t.Join();

        }
    }
}
