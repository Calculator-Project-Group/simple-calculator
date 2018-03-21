// Generated from Calc.g4 by ANTLR 4.7
import org.antlr.v4.runtime.tree.ParseTreeVisitor;

/**
 * This interface defines a complete generic visitor for a parse tree produced
 * by {@link CalcParser}.
 *
 * @param <T> The return type of the visit operation. Use {@link Void} for
 * operations with no return type.
 */
public interface CalcVisitor<T> extends ParseTreeVisitor<T> {
	/**
	 * Visit a parse tree produced by {@link CalcParser#constPI}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitConstPI(CalcParser.ConstPIContext ctx);
	/**
	 * Visit a parse tree produced by {@link CalcParser#constE}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitConstE(CalcParser.ConstEContext ctx);
	/**
	 * Visit a parse tree produced by {@link CalcParser#node}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitNode(CalcParser.NodeContext ctx);
	/**
	 * Visit a parse tree produced by {@link CalcParser#log_exp}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitLog_exp(CalcParser.Log_expContext ctx);
	/**
	 * Visit a parse tree produced by {@link CalcParser#trig_exp}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitTrig_exp(CalcParser.Trig_expContext ctx);
	/**
	 * Visit a parse tree produced by {@link CalcParser#exp}.
	 * @param ctx the parse tree
	 * @return the visitor result
	 */
	T visitExp(CalcParser.ExpContext ctx);
}