using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public abstract class Calc_node
    {
        public bool isint = true; // 该节点是否为整型
        protected bool calculated = false; // 该节点是否已计算
        public long result;
        public double fresult;
        public abstract void Calculate();
    }
    public class Value_node : Calc_node
    {
        public override void Calculate()
        {
            calculated = true;
        }
    }
    // 此类用来表示括号。可嵌套。
    public class Bracket_node : Calc_node
    {
        public Calc_node internal_node = null;
        public override void Calculate()
        {
            if (internal_node != null)
            {
                internal_node.Calculate();
                if (internal_node.isint)
                {
                    isint = true;
                    result = internal_node.result;
                }
                else
                {
                    isint = false;
                    fresult = internal_node.fresult;
                }
                calculated = true;
            }
        }
    }

    // 此类用来表示各种二元运算表达式和函数。可嵌套。
    public class Binary_node : Calc_node
    {
        // 指明运算符：加、减、乘、除、乘方
        public enum Operator { ADD, MINUS, MULTI, DIVIDE, EXPO, LOG };
        // 包含两个节点的引用
        public Calc_node node1;
        public Calc_node node2;
        public Operator op;
        public override void Calculate()
        {
            isint = node1.isint && node2.isint && (op != Operator.EXPO) && (op != Operator.LOG)
            && ((op != Operator.DIVIDE) || (node1.result % node2.result == 0));
            if (isint)
            {
                checked
                {
                    try
                    {
                        switch (op)
                        {
                            case Operator.ADD:
                                result = node1.result + node2.result; break;
                            case Operator.MINUS:
                                result = node1.result - node2.result; break;
                            case Operator.MULTI:
                                result = node1.result * node2.result; break;
                            case Operator.DIVIDE:
                                result = node1.result / node2.result; break;
                            default: break;
                        }
                    }
                    catch (OverflowException)
                    {
                        isint = false;
                    }
                }
            }
            if (!isint)
            {
                if (node1.isint) node1.fresult = node1.result;
                if (node2.isint) node2.fresult = node2.result;
                switch (op)
                { 
                    case Operator.ADD:
                        fresult = node1.fresult + node2.fresult; break;
                    case Operator.MINUS:
                        fresult = node1.fresult - node2.fresult; break;
                    case Operator.MULTI:
                        fresult = node1.fresult * node2.fresult; break;
                    case Operator.DIVIDE:
                        fresult = node1.fresult / node2.fresult; break;
                    case Operator.EXPO:
                        fresult = Math.Pow(node1.fresult, node2.fresult); break;
                    case Operator.LOG:
                        fresult = Math.Log(node2.fresult, node1.fresult); break;
                    default: break;
                }
            }
            calculated = true;
        }
    }


    // 表示各一元函数。可嵌套。
    public class Unary_node : Calc_node
    {
        public enum FuncID { Sin, Cos, Tan };
        public FuncID func;
        public Calc_node node1;
        public override void Calculate()
        {
            isint = false;
            double src = node1.isint ? result : fresult;
            switch (func)
            {
                case FuncID.Sin:
                    fresult = Math.Sin(src);break;
                case FuncID.Cos:
                    fresult = Math.Cos(src); break;
                case FuncID.Tan:
                    fresult = Math.Tan(src); break;
                default: break;
            }
            calculated = true;
        }

    }
}


