﻿using System;
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
    public class Value_node:Calc_node
    {       
        public override void Calculate()
        {
            calculated = true;
        }
    }
    // 此类用来表示括号。可嵌套。
    public class Bracket_node:Calc_node
    {
        public Calc_node internal_node = null;
        public override void Calculate()
        {
            internal_node.Calculate();
            if(internal_node.isint)
            {
                isint = true;
                result = internal_node.result;
            }
            else
            {
                isint = false;
                fresult = internal_node.fresult;
            }
        }
    }
    // 此类用来表示各种二元运算表达式和函数。可嵌套。
    public class Binary_node:Calc_node
    {
        // 指明运算符：加、减、乘、除、乘方
        public enum Operator{ ADD, MINUS, MULTI, DIVIDE,EXPO,LOG};
        // 包含两个节点的引用
        public Calc_node node1;
        public Calc_node node2;
        public Operator op;
        public override void Calculate()
        {
            // 
            throw new NotImplementedException();
        }
    }
    // 表示各一元函数。可嵌套。
    public class Unary_node:Calc_node
    {
        public enum FuncID { Sin,Cos,Tan};
        public FuncID func;
        public override void Calculate()
        {
            int a = 5;
            a++;
            throw new NotImplementedException();
        }

    }
}
