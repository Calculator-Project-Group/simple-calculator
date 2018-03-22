using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;

namespace calculator
{
    public class MathText : TextBlock
    {
        public MathText(string formula, double fsize = 18)
        {
            FontFamily = new System.Windows.Media.FontFamily("Cambria Math");
            Text = formula;
            FontSize = fsize;

        }
    }
    public class MathRenderer
    {
        public const double shrinkRatio = (double)5 / 6;
        public const double defaultFontSize = 18.0;
        public const double fractionBarHeight = 1.5;

        public MathRenderer()
        {
        }
        /*
         * Align elements horizontally and return a canvas.
         * Elements include Canvas and MathText.
        */
        public Canvas ArrangeHorizontalGroup(params FrameworkElement[] elements)
        {
            Canvas board = new Canvas();
            double startWidth = 0, maxHeight=0;
            // set each element's left margin
            foreach (var element in elements)
            {
                Canvas.SetLeft(element, startWidth);
                if(element is MathText)
                {
                    element.Measure(new Size(Double.PositiveInfinity, Double.PositiveInfinity));
                    startWidth += element.DesiredSize.Width;
                    if (maxHeight < element.DesiredSize.Height)
                        maxHeight = element.DesiredSize.Height;
                }
                else
                {
                    // it's a canvas.
                    startWidth += element.Width;
                    if (maxHeight < element.Height)
                        maxHeight = element.Height;
                }
            }
            
            // set each element's top margin
            foreach(var element in elements)
            {
                if(element is MathText)
                    Canvas.SetTop(element, (maxHeight - element.DesiredSize.Height) / 2);
                else
                    Canvas.SetTop(element, (maxHeight - element.Height) / 2);
                board.Children.Add(element);
            }
            board.Width = startWidth;
            board.Height = maxHeight;
            return board;
        }
        public Canvas ArrangeVerticalGroup(params FrameworkElement[] elements)
        {
            Canvas board = new Canvas();
            double startDepth = 0, maxWidth = 0;
            // set each element's left margin
            foreach (var element in elements)
            {
                Canvas.SetTop(element, startDepth);
                if (element is MathText)
                {
                    element.Measure(new Size(Double.PositiveInfinity, Double.PositiveInfinity));
                    startDepth += element.DesiredSize.Height;
                    if (maxWidth < element.DesiredSize.Width)
                        maxWidth = element.DesiredSize.Width;
                }
                else
                {
                    // it's a canvas or sth like that.
                    startDepth += element.Height;
                    if (maxWidth < element.Width)
                        maxWidth = element.Width;
                }
            }

            // set each element's top margin
            foreach (var element in elements)
            {
                if (element is MathText)
                    Canvas.SetLeft(element, (maxWidth - element.DesiredSize.Width) / 2);
                else
                    Canvas.SetLeft(element, (maxWidth - element.Width) / 2);
                board.Children.Add(element);
            }
            board.Height = startDepth;
            board.Width = maxWidth;
            return board;
        }

        public Canvas RenderElement(Calc_node exp, double fontsize=defaultFontSize)
        {
            Canvas board = null;

            if (exp is Value_node)
            {
                MathText text = new MathText(exp.result.ToString());
                board = ArrangeHorizontalGroup(text);
            }
            else if (exp is Bracket_node)
            {
                // we separate brackets and inner text
                MathText lparen = new MathText("(");
                Canvas inner_text = RenderElement((exp as Bracket_node).internal_node,fontsize);
                MathText rparen = new MathText(")");
                // arrange positions of these elements
                board = ArrangeHorizontalGroup(lparen, inner_text, rparen);
            }
            else if (exp is Binary_node)
            {
                Canvas operand1 = null, operand2 = null;
                switch ((exp as Binary_node).op)
                {
                    // horizontal expressions
                    case Binary_node.Operator.ADD:
                    case Binary_node.Operator.MINUS:
                    case Binary_node.Operator.MULTI:
                        operand1 = RenderElement((exp as Binary_node).node1, fontsize);
                        MathText add = new MathText("+");
                        operand2 = RenderElement((exp as Binary_node).node2, fontsize);
                        board = ArrangeHorizontalGroup(operand1, add, operand2);
                        break;
                        
                    // vertical expressions
                    case Binary_node.Operator.DIVIDE:
                        operand1 = RenderElement((exp as Binary_node).node1, fontsize*shrinkRatio);
                        operand2 = RenderElement((exp as Binary_node).node2, fontsize * shrinkRatio);
                        Rectangle fractline = new Rectangle();
                        // fractline's width should be the longer of two elements
                        fractline.Width = (operand1.Width > operand2.Width ? operand1.Width : operand2.Width)*1.1;
                        fractline.Height = fractionBarHeight;
                        fractline.Fill = System.Windows.Media.Brushes.Black;
                        fractline.HorizontalAlignment = HorizontalAlignment.Center;
                        board = ArrangeVerticalGroup(operand1, fractline, operand2);
                        break;
                    
                    default:
                        break;
                }
            }

            return board;
        }

    }
}

