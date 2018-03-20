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
                board.Children.Add(text);
            }
            else if(exp is Bracket_node)
            {
                // we separate brackets and inner text
                MathText lparen = new MathText("(");
                Canvas inner_text = RenderElement((exp as Bracket_node).internal_node);
                MathText rparen = new MathText("(");
                // arrange positions of these elements
                Canvas.SetLeft(lparen, 0);
                Canvas.SetLeft(inner_text, lparen.ActualWidth);
                Canvas.SetLeft(rparen, lparen.ActualWidth + inner_text.ActualWidth);
                board.Children.Add(lparen);
                board.Children.Add(inner_text);
                board.Children.Add(rparen);
            }
            // calculate height and width of this canvas
            double width = 0, height = 0;
            foreach(var child in board.Children)
            {
                width += (child as FrameworkElement).ActualWidth;
                height+= (child as FrameworkElement).ActualHeight;
            }

            return board;
        }

    }
}

