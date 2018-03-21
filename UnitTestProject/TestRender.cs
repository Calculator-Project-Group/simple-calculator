using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using calculator;
using System.Windows;
using System.Threading;

namespace UnitTestProject
{
    [TestClass]
    public class TestRender
    {
        private bool SetWindow()
        {

        }
        [TestMethod]
        public void TestMethod1()
        {
            Value_node value = new Value_node
            {
                isint = true,
                result = 502L
            };
            value.Calculate();
            Bracket_node bnode = new Bracket_node
            {
                internal_node = value
            };

            MathRenderer renderer = new MathRenderer();
            MainWindow window;

            var t = new Thread(() =>
            {
                window = new MainWindow();

                // Initiates the dispatcher thread shutdown when the window closes
                window.Closed += (s, e) => window.Dispatcher.InvokeShutdown();

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
