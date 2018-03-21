// Generated from Calc.g4 by ANTLR 4.7
import org.antlr.v4.runtime.tree.ParseTreeListener;

/**
 * This interface defines a complete listener for a parse tree produced by
 * {@link CalcParser}.
 */
public interface CalcListener extends ParseTreeListener {
	/**
	 * Enter a parse tree produced by {@link CalcParser#constPI}.
	 * @param ctx the parse tree
	 */
	void enterConstPI(CalcParser.ConstPIContext ctx);
	/**
	 * Exit a parse tree produced by {@link CalcParser#constPI}.
	 * @param ctx the parse tree
	 */
	void exitConstPI(CalcParser.ConstPIContext ctx);
	/**
	 * Enter a parse tree produced by {@link CalcParser#constE}.
	 * @param ctx the parse tree
	 */
	void enterConstE(CalcParser.ConstEContext ctx);
	/**
	 * Exit a parse tree produced by {@link CalcParser#constE}.
	 * @param ctx the parse tree
	 */
	void exitConstE(CalcParser.ConstEContext ctx);
	/**
	 * Enter a parse tree produced by {@link CalcParser#node}.
	 * @param ctx the parse tree
	 */
	void enterNode(CalcParser.NodeContext ctx);
	/**
	 * Exit a parse tree produced by {@link CalcParser#node}.
	 * @param ctx the parse tree
	 */
	void exitNode(CalcParser.NodeContext ctx);
	/**
	 * Enter a parse tree produced by {@link CalcParser#log_exp}.
	 * @param ctx the parse tree
	 */
	void enterLog_exp(CalcParser.Log_expContext ctx);
	/**
	 * Exit a parse tree produced by {@link CalcParser#log_exp}.
	 * @param ctx the parse tree
	 */
	void exitLog_exp(CalcParser.Log_expContext ctx);
	/**
	 * Enter a parse tree produced by {@link CalcParser#trig_exp}.
	 * @param ctx the parse tree
	 */
	void enterTrig_exp(CalcParser.Trig_expContext ctx);
	/**
	 * Exit a parse tree produced by {@link CalcParser#trig_exp}.
	 * @param ctx the parse tree
	 */
	void exitTrig_exp(CalcParser.Trig_expContext ctx);
	/**
	 * Enter a parse tree produced by {@link CalcParser#exp}.
	 * @param ctx the parse tree
	 */
	void enterExp(CalcParser.ExpContext ctx);
	/**
	 * Exit a parse tree produced by {@link CalcParser#exp}.
	 * @param ctx the parse tree
	 */
	void exitExp(CalcParser.ExpContext ctx);
}