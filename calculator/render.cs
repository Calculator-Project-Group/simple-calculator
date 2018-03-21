using System;
using System.Windows;
using System.Windows.Controls;

namespace calculator
{
    public class MathText: TextBlock
    {
        public MathText(string formula)
        {
            FontFamily = new System.Windows.Media.FontFamily("Cambria Math");
            Text = formula;
            FontSize = 18;
            
        }
    }
    public class MathRenderer
    {

        public MathRenderer()
        {
        }

        public Canvas RenderElement(Calc_node exp)
        {
            Canvas board = new Canvas();
            
            if(exp is Value_node)
            {
                MathText text = new MathText(exp.result.ToString());
                text.Measure(new Size(Double.PositiveInfinity, Double.PositiveInfinity));
                board.Children.Add(text);
                board.Width = text.DesiredSize.Width;
                board.Height = text.DesiredSize.Height;
            }
            else if(exp is Bracket_node)
            {
                // we separate brackets and inner text
                MathText lparen = new MathText("(");
                Canvas inner_text = RenderElement((exp as Bracket_node).internal_node);
                MathText rparen = new MathText(")");
                // arrange positions of these elements
                lparen.Measure(new Size(Double.PositiveInfinity, Double.PositiveInfinity));
                inner_text.Measure(new Size(Double.PositiveInfinity, Double.PositiveInfinity));
                rparen.Measure(new Size(Double.PositiveInfinity, Double.PositiveInfinity));
                
                Canvas.SetLeft(lparen, 0);
                board.Children.Add(lparen);
                Canvas.SetLeft(inner_text, lparen.DesiredSize.Width);
                board.Children.Add(inner_text);
                Canvas.SetLeft(rparen, lparen.DesiredSize.Width + inner_text.Width);
                board.Children.Add(rparen);
                board.Width = lparen.DesiredSize.Width + rparen.DesiredSize.Width + inner_text.Width;
                board.Height = inner_text.Height;
            }

            return board;
        }

    }
}

