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

    public class AlignCanvas: Canvas
    {
        public double alignHeight = 0;
    }

    public class MathRenderer
    {
        public const double shrinkRatio = (double)5 / 6;
        public const double expoRatio = (double)2/3;
        public const double logRatio = (double)2 / 3;
        public const double defaultFontSize = 18.0;
        public const double fractionBarHeight = 1.5;
        public readonly string[] funcID = { "sin", "cos", "tan" };
        public readonly string[] opID = { "+", "-", "×", "oops 代码写错啦", "oops 代码写错啦", "oops 代码写错啦" };

        public MathRenderer()
        {
        }
        /*
         * Align elements horizontally and return a canvas.
         * Elements include Canvas and MathText.
        */
        public AlignCanvas ArrangeHorizontalGroup(params FrameworkElement[] elements)
        {
            AlignCanvas board = new AlignCanvas();
            //  maxAlignDepth: the max depth from the top, where all nodes are to be aligned
            double startWidth = 0, maxAlignDepth=0;
            // set each element's left margin
            foreach (var element in elements)
            {
                
                AlignCanvas.SetLeft(element, startWidth);
                if(element is MathText)
                {
                    element.Measure(new Size(Double.PositiveInfinity, Double.PositiveInfinity));
                    startWidth += element.DesiredSize.Width;
                    if (maxAlignDepth < element.DesiredSize.Height/2)
                        maxAlignDepth = element.DesiredSize.Height/2;
                }
                else
                {
                    // it's a canvas.
                    startWidth += element.Width;
                    if (maxAlignDepth < (element as AlignCanvas).alignHeight)
                        maxAlignDepth = (element as AlignCanvas).alignHeight;
                }
            }

            // set each element's top margin
            double maxDepth = 0;
            foreach(var element in elements)
            {
                if(element is MathText)
                {
                    AlignCanvas.SetTop(element, maxAlignDepth - element.DesiredSize.Height/2);
                    if (element.DesiredSize.Height + maxAlignDepth - element.DesiredSize.Height / 2 > maxDepth)
                        maxDepth = element.DesiredSize.Height + maxAlignDepth - element.DesiredSize.Height / 2;
                }
                else
                {
                    AlignCanvas.SetTop(element, maxAlignDepth - (element as AlignCanvas).alignHeight);
                    if (element.Height + maxAlignDepth - (element as AlignCanvas).alignHeight > maxDepth)
                        maxDepth = element.Height + maxAlignDepth - (element as AlignCanvas).alignHeight;
                }
                board.Children.Add(element);
            }
            board.Width = startWidth;
            board.Height = maxDepth;
            board.alignHeight = maxAlignDepth;
            return board;
        }
        public AlignCanvas ArrangeVerticalGroup(params FrameworkElement[] elements)
        {
            AlignCanvas board = new AlignCanvas();
            double startDepth = 0, maxWidth = 0;
            // set each element's left margin
            foreach (var element in elements)
            {
                AlignCanvas.SetTop(element, startDepth);
                if (element is Rectangle) // fraction bar
                    board.alignHeight = startDepth;
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
                    AlignCanvas.SetLeft(element, (maxWidth - element.DesiredSize.Width) / 2);
                else
                    AlignCanvas.SetLeft(element, (maxWidth - element.Width) / 2);
                board.Children.Add(element);
            }
            board.Height = startDepth;
            board.Width = maxWidth;
            if (board.alignHeight == 0)
                board.alignHeight = startDepth;
            return board;
        }

        public AlignCanvas RenderElement(Calc_node exp, double fontsize=defaultFontSize)
        {
            AlignCanvas board = null;

            if (exp is Value_node)
            {
                MathText text = null;
                if (exp.isint)
                    text = new MathText(exp.result.ToString(), fontsize);
                else
                    text = new MathText(exp.fresult.ToString(), fontsize);
                board = ArrangeHorizontalGroup(text);
                // board.alignHeight = text.DesiredSize.Height;
            }
            else if (exp is Bracket_node)
            {
                // we separate brackets and inner text
                MathText lparen = new MathText("(",fontsize);
                AlignCanvas inner_text = RenderElement((exp as Bracket_node).internal_node,fontsize);
                MathText rparen = new MathText(")",fontsize);
                // arrange positions of these elements
                board = ArrangeHorizontalGroup(lparen, inner_text, rparen);
            }
            else if (exp is Binary_node)
            {
                AlignCanvas operand1 = null, operand2 = null;
                switch ((exp as Binary_node).op)
                {
                    // horizontal expressions
                    case Binary_node.Operator.ADD:
                    case Binary_node.Operator.MINUS:
                    case Binary_node.Operator.MULTI:
                        operand1 = RenderElement((exp as Binary_node).node1, fontsize);
                        MathText add = new MathText(opID[(int)(exp as Binary_node).op],fontsize);
                        operand2 = RenderElement((exp as Binary_node).node2, fontsize);
                        board = ArrangeHorizontalGroup(operand1, add, operand2);
                        break;
                        
                    // vertical expressions
                    case Binary_node.Operator.DIVIDE:
                        operand1 = RenderElement((exp as Binary_node).node1, fontsize*shrinkRatio);
                        operand2 = RenderElement((exp as Binary_node).node2, fontsize * shrinkRatio);
                        // strip the bracket if operand2 is a bracket node
                        if (operand2.Children.Count==3 && operand2.Children[0] is MathText && operand2.Children[2] is MathText)
                        {
                            AlignCanvas inner_node = operand2.Children[1] as AlignCanvas;
                            operand2.Children.Remove(inner_node);
                            operand2 = inner_node;
                        }
                        Rectangle fractline = new Rectangle();
                        // fractline's width should be the longer of two elements
                        fractline.Width = (operand1.Width > operand2.Width ? operand1.Width : operand2.Width)*1.1;
                        fractline.Height = fractionBarHeight;
                        fractline.Fill = System.Windows.Media.Brushes.Black;
                        fractline.HorizontalAlignment = HorizontalAlignment.Center;
                        board = ArrangeVerticalGroup(operand1, fractline, operand2);
                        break;
                    // miscellaneous
                    case Binary_node.Operator.EXPO:
                        operand1 = RenderElement((exp as Binary_node).node1, fontsize);
                        operand2 = RenderElement((exp as Binary_node).node2, fontsize * expoRatio);
                        board = new AlignCanvas();
                        Canvas.SetTop(operand1, operand2.Height/2);
                        Canvas.SetLeft(operand1, 0);
                        board.Children.Add(operand1);
                        Canvas.SetTop(operand2, 0);
                        Canvas.SetLeft(operand2, operand1.Width);
                        board.Children.Add(operand2);
                        board.Height = operand1.Height + operand2.Height/2;
                        board.Width = operand1.Width + operand2.Width;
                        board.alignHeight = operand1.alignHeight+operand2.Height/2; // this step is important
                        break;
                    case Binary_node.Operator.LOG:
                        MathText logID = new MathText("log", fontsize);
                        operand1 = RenderElement((exp as Binary_node).node1, fontsize*logRatio);
                        MathText lparen = new MathText("(", fontsize);
                        operand2 = RenderElement((exp as Binary_node).node2, fontsize);
                        MathText rparen = new MathText(")", fontsize);
                        // first, we apply ArrangeHorizontal
                        board = ArrangeHorizontalGroup(logID, operand1, lparen, operand2, rparen);
                        // then, adjust operand1
                        board.Children.Remove(operand1);
                        Canvas.SetTop(operand1, Canvas.GetTop(board.Children[0])+ board.Children[0].DesiredSize.Height*2/3);
                        board.Children.Add(operand1);
                        // update height of canvas `board`
                        board.Height = Math.Max(Canvas.GetTop(board.Children[0])+board.Children[0].DesiredSize.Height*2/3+operand1.Height,board.Height);
                        break;
                    default:
                        break;
                }
            }
            else if(exp is Unary_node)
            {
                MathText funcText = new MathText(funcID[(int)(exp as Unary_node).func]+"(",fontsize);
                AlignCanvas inner_node = RenderElement((exp as Unary_node).node1,fontsize);
                MathText rparen = new MathText(")", fontsize);
                board = ArrangeHorizontalGroup(funcText, inner_node,rparen);
            }
            else if(exp == null)
            {
                Rectangle placeholder = new Rectangle();
                placeholder.Width = fontsize;
                placeholder.Height = fontsize;
                placeholder.Fill = System.Windows.Media.Brushes.LightBlue;
                board = new AlignCanvas();
                board.Children.Add(placeholder);
                board.Height = placeholder.Height;
                board.Width = placeholder.Width;
                board.alignHeight = board.Height / 2;
            }
            return board;
        }

    }
}

