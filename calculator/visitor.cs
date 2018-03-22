using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;


namespace calculator
{
    public class CalcVisitor: CalcBaseVisitor<Calc_node>
    {

        public override Calc_node VisitConstPI([NotNull] CalcParser.ConstPIContext context)
        {
            Value_node node = new Value_node
            {
                isint = false,
                fresult = Math.PI
            };
            return node;
        }

        public override Calc_node VisitConstE([NotNull] CalcParser.ConstEContext context)
        {
            Value_node node = new Value_node
            {
                isint = false,
                fresult = Math.E
            };
            return node;
        }

        public override Calc_node VisitNode([NotNull] CalcParser.NodeContext context)
        {
            Value_node node = new Value_node();
            string text = context.GetText();
            if(text.ToLower() == "pi" || text == "π")
            {
                node.isint = false;
                node.fresult = Math.PI;
            }
            else if(text.ToLower() == "e")
            {
                node.isint = false;
                node.fresult = Math.E;
            }
            else
            {
                try
                {
                    node.isint = true;
                    node.result = Convert.ToInt32(text);
                }
                catch
                {
                    node.isint = false;
                    node.fresult = Convert.ToDouble(text);
                }
            }
            return node;
        }

        public override Calc_node VisitLog_exp([NotNull] CalcParser.Log_expContext context)
        {
            // 生成 log 节点
            Binary_node node = new Binary_node
            {
                op = Binary_node.Operator.LOG,
                node1 = Visit(context.exp(0)),
                node2 = Visit(context.exp(1))
            };
            return node;
        }

        public override Calc_node VisitTrig_exp([NotNull] CalcParser.Trig_expContext context)
        {
            Unary_node node = new Unary_node();
            switch(context.TrigID().GetText().ToLower())
            {
                case "sin":
                    node.func = Unary_node.FuncID.Sin;
                    break;
                case "cos":               
                    node.func = Unary_node.FuncID.Cos;
                    break;
                case "tan":
                    node.func = Unary_node.FuncID.Tan;
                    break;
            }
            node.node1 = Visit(context.exp());
            return node;
        }

        public override Calc_node VisitExp([NotNull] CalcParser.ExpContext context)
        {

            int i = context.ChildCount;
            if (i == 1)
            {
                //node log_exp trig_exp
                var subtree = context.GetChild(0);
                return Visit(subtree);
            }
            else if(i == 2)
            {
                // LeftParen RightParen 空括号节点
                return new Bracket_node();
            }
            else
            {
                
                var child = context.GetChild(1);
                if(child.ChildCount == 0)
                {
                    // + - * / ^
                    Binary_node node = new Binary_node();
                    switch (child.GetText())
                    {
                        case "+":
                            node.op = Binary_node.Operator.ADD;
                            break;
                        case "-":
                            node.op = Binary_node.Operator.MINUS;
                            break;
                        case "*":
                            node.op = Binary_node.Operator.MULTI;
                            break;
                        case "/":
                            node.op = Binary_node.Operator.DIVIDE;
                            break;
                        case "^":
                            node.op = Binary_node.Operator.EXPO;
                            break;
                    }
                    node.node1 = Visit(context.GetChild(0));
                    node.node2 = Visit(context.GetChild(2));
                    return node;
                }
                else
                {
                    //(exp)
                    return new Bracket_node
                    {
                        internal_node = Visit(context.GetChild(1))
                    };
                }                
            }
        }
    }
}
