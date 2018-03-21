using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    public class CalcVisitor<Result> : CalcBaseVisitor<Result>
    {

        public override Result VisitConstPI([NotNull] CalcParser.ConstPIContext context)
        {
            return VisitChildren(context);
        }

        public override Result VisitConstE([NotNull] CalcParser.ConstEContext context)
        {
            return VisitChildren(context);
        }

        public override Result VisitNode([NotNull] CalcParser.NodeContext context)
        {
            return VisitChildren(context);
        }

        public override Result VisitLog_exp([NotNull] CalcParser.Log_expContext context)
        {
            return VisitChildren(context);
        }

        public override Result VisitTrig_exp([NotNull] CalcParser.Trig_expContext context)
        {
            return VisitChildren(context);
        }

        public override Result VisitExp([NotNull] CalcParser.ExpContext context)
        {
            context.children
            return VisitChildren(context);
        }
    }
}
