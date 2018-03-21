//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.7
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from Calc.g4 by ANTLR 4.7

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

using System;
using System.IO;
using System.Text;
using System.Diagnostics;
using System.Collections.Generic;
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using Antlr4.Runtime.Tree;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public partial class CalcParser : Parser {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, Plus=6, Minus=7, Multiply=8, Divide=9, 
		Power=10, LeftParen=11, RightParen=12, Comma=13, LogID=14, TrigID=15, 
		Int=16, Float=17, WhiteSpace=18;
	public const int
		RULE_constPI = 0, RULE_constE = 1, RULE_node = 2, RULE_log_exp = 3, RULE_trig_exp = 4, 
		RULE_exp = 5;
	public static readonly string[] ruleNames = {
		"constPI", "constE", "node", "log_exp", "trig_exp", "exp"
	};

	private static readonly string[] _LiteralNames = {
		null, "'PI'", "'pi'", "'\u03C0'", "'E'", "'e'", "'+'", "'-'", "'*'", "'/'", 
		"'^'"
	};
	private static readonly string[] _SymbolicNames = {
		null, null, null, null, null, null, "Plus", "Minus", "Multiply", "Divide", 
		"Power", "LeftParen", "RightParen", "Comma", "LogID", "TrigID", "Int", 
		"Float", "WhiteSpace"
	};
	public static readonly IVocabulary DefaultVocabulary = new Vocabulary(_LiteralNames, _SymbolicNames);

	[NotNull]
	public override IVocabulary Vocabulary
	{
		get
		{
			return DefaultVocabulary;
		}
	}

	public override string GrammarFileName { get { return "Calc.g4"; } }

	public override string[] RuleNames { get { return ruleNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static CalcParser() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}

		public CalcParser(ITokenStream input) : this(input, Console.Out, Console.Error) { }

		public CalcParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
		: base(input, output, errorOutput)
	{
		Interpreter = new ParserATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}
	public partial class ConstPIContext : ParserRuleContext {
		public ConstPIContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_constPI; } }
		public override void EnterRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.EnterConstPI(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.ExitConstPI(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICalcVisitor<TResult> typedVisitor = visitor as ICalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitConstPI(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ConstPIContext constPI() {
		ConstPIContext _localctx = new ConstPIContext(Context, State);
		EnterRule(_localctx, 0, RULE_constPI);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 12;
			_la = TokenStream.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2))) != 0)) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ConstEContext : ParserRuleContext {
		public ConstEContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_constE; } }
		public override void EnterRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.EnterConstE(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.ExitConstE(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICalcVisitor<TResult> typedVisitor = visitor as ICalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitConstE(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ConstEContext constE() {
		ConstEContext _localctx = new ConstEContext(Context, State);
		EnterRule(_localctx, 2, RULE_constE);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 14;
			_la = TokenStream.LA(1);
			if ( !(_la==T__3 || _la==T__4) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class NodeContext : ParserRuleContext {
		public ITerminalNode Int() { return GetToken(CalcParser.Int, 0); }
		public ITerminalNode Float() { return GetToken(CalcParser.Float, 0); }
		public NodeContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_node; } }
		public override void EnterRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.EnterNode(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.ExitNode(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICalcVisitor<TResult> typedVisitor = visitor as ICalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitNode(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public NodeContext node() {
		NodeContext _localctx = new NodeContext(Context, State);
		EnterRule(_localctx, 4, RULE_node);
		int _la;
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 16;
			_la = TokenStream.LA(1);
			if ( !(_la==Int || _la==Float) ) {
			ErrorHandler.RecoverInline(this);
			}
			else {
				ErrorHandler.ReportMatch(this);
			    Consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Log_expContext : ParserRuleContext {
		public ITerminalNode LogID() { return GetToken(CalcParser.LogID, 0); }
		public ITerminalNode LeftParen() { return GetToken(CalcParser.LeftParen, 0); }
		public ITerminalNode Comma() { return GetToken(CalcParser.Comma, 0); }
		public ITerminalNode RightParen() { return GetToken(CalcParser.RightParen, 0); }
		public ExpContext[] exp() {
			return GetRuleContexts<ExpContext>();
		}
		public ExpContext exp(int i) {
			return GetRuleContext<ExpContext>(i);
		}
		public Log_expContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_log_exp; } }
		public override void EnterRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.EnterLog_exp(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.ExitLog_exp(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICalcVisitor<TResult> typedVisitor = visitor as ICalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitLog_exp(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Log_expContext log_exp() {
		Log_expContext _localctx = new Log_expContext(Context, State);
		EnterRule(_localctx, 6, RULE_log_exp);
		try {
			State = 37;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,3,Context) ) {
			case 1:
				EnterOuterAlt(_localctx, 1);
				{
				State = 18; Match(LogID);
				State = 19; Match(LeftParen);
				State = 22;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case LeftParen:
				case LogID:
				case TrigID:
				case Int:
				case Float:
					{
					State = 20; exp(0);
					}
					break;
				case Comma:
					{
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 24; Match(Comma);
				State = 27;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case LeftParen:
				case LogID:
				case TrigID:
				case Int:
				case Float:
					{
					State = 25; exp(0);
					}
					break;
				case RightParen:
					{
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 29; Match(RightParen);
				}
				break;
			case 2:
				EnterOuterAlt(_localctx, 2);
				{
				State = 30; Match(LogID);
				State = 31; Match(LeftParen);
				State = 34;
				ErrorHandler.Sync(this);
				switch (TokenStream.LA(1)) {
				case LeftParen:
				case LogID:
				case TrigID:
				case Int:
				case Float:
					{
					State = 32; exp(0);
					}
					break;
				case RightParen:
					{
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				State = 36; Match(RightParen);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class Trig_expContext : ParserRuleContext {
		public ITerminalNode TrigID() { return GetToken(CalcParser.TrigID, 0); }
		public ITerminalNode LeftParen() { return GetToken(CalcParser.LeftParen, 0); }
		public ITerminalNode RightParen() { return GetToken(CalcParser.RightParen, 0); }
		public ExpContext exp() {
			return GetRuleContext<ExpContext>(0);
		}
		public Trig_expContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_trig_exp; } }
		public override void EnterRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.EnterTrig_exp(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.ExitTrig_exp(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICalcVisitor<TResult> typedVisitor = visitor as ICalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitTrig_exp(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public Trig_expContext trig_exp() {
		Trig_expContext _localctx = new Trig_expContext(Context, State);
		EnterRule(_localctx, 8, RULE_trig_exp);
		try {
			EnterOuterAlt(_localctx, 1);
			{
			State = 39; Match(TrigID);
			State = 40; Match(LeftParen);
			State = 43;
			ErrorHandler.Sync(this);
			switch (TokenStream.LA(1)) {
			case LeftParen:
			case LogID:
			case TrigID:
			case Int:
			case Float:
				{
				State = 41; exp(0);
				}
				break;
			case RightParen:
				{
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			State = 45; Match(RightParen);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			ExitRule();
		}
		return _localctx;
	}

	public partial class ExpContext : ParserRuleContext {
		public ITerminalNode LeftParen() { return GetToken(CalcParser.LeftParen, 0); }
		public ExpContext[] exp() {
			return GetRuleContexts<ExpContext>();
		}
		public ExpContext exp(int i) {
			return GetRuleContext<ExpContext>(i);
		}
		public ITerminalNode RightParen() { return GetToken(CalcParser.RightParen, 0); }
		public Log_expContext log_exp() {
			return GetRuleContext<Log_expContext>(0);
		}
		public Trig_expContext trig_exp() {
			return GetRuleContext<Trig_expContext>(0);
		}
		public NodeContext node() {
			return GetRuleContext<NodeContext>(0);
		}
		public ITerminalNode Power() { return GetToken(CalcParser.Power, 0); }
		public ITerminalNode Multiply() { return GetToken(CalcParser.Multiply, 0); }
		public ITerminalNode Divide() { return GetToken(CalcParser.Divide, 0); }
		public ITerminalNode Plus() { return GetToken(CalcParser.Plus, 0); }
		public ITerminalNode Minus() { return GetToken(CalcParser.Minus, 0); }
		public ExpContext(ParserRuleContext parent, int invokingState)
			: base(parent, invokingState)
		{
		}
		public override int RuleIndex { get { return RULE_exp; } }
		public override void EnterRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.EnterExp(this);
		}
		public override void ExitRule(IParseTreeListener listener) {
			ICalcListener typedListener = listener as ICalcListener;
			if (typedListener != null) typedListener.ExitExp(this);
		}
		public override TResult Accept<TResult>(IParseTreeVisitor<TResult> visitor) {
			ICalcVisitor<TResult> typedVisitor = visitor as ICalcVisitor<TResult>;
			if (typedVisitor != null) return typedVisitor.VisitExp(this);
			else return visitor.VisitChildren(this);
		}
	}

	[RuleVersion(0)]
	public ExpContext exp() {
		return exp(0);
	}

	private ExpContext exp(int _p) {
		ParserRuleContext _parentctx = Context;
		int _parentState = State;
		ExpContext _localctx = new ExpContext(Context, _parentState);
		ExpContext _prevctx = _localctx;
		int _startState = 10;
		EnterRecursionRule(_localctx, 10, RULE_exp, _p);
		int _la;
		try {
			int _alt;
			EnterOuterAlt(_localctx, 1);
			{
			State = 57;
			ErrorHandler.Sync(this);
			switch ( Interpreter.AdaptivePredict(TokenStream,5,Context) ) {
			case 1:
				{
				State = 48; Match(LeftParen);
				State = 49; exp(0);
				State = 50; Match(RightParen);
				}
				break;
			case 2:
				{
				State = 52; log_exp();
				}
				break;
			case 3:
				{
				State = 53; trig_exp();
				}
				break;
			case 4:
				{
				State = 54; Match(LeftParen);
				State = 55; Match(RightParen);
				}
				break;
			case 5:
				{
				State = 56; node();
				}
				break;
			}
			Context.Stop = TokenStream.LT(-1);
			State = 70;
			ErrorHandler.Sync(this);
			_alt = Interpreter.AdaptivePredict(TokenStream,7,Context);
			while ( _alt!=2 && _alt!=global::Antlr4.Runtime.Atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( ParseListeners!=null )
						TriggerExitRuleEvent();
					_prevctx = _localctx;
					{
					State = 68;
					ErrorHandler.Sync(this);
					switch ( Interpreter.AdaptivePredict(TokenStream,6,Context) ) {
					case 1:
						{
						_localctx = new ExpContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_exp);
						State = 59;
						if (!(Precpred(Context, 8))) throw new FailedPredicateException(this, "Precpred(Context, 8)");
						State = 60; Match(Power);
						State = 61; exp(9);
						}
						break;
					case 2:
						{
						_localctx = new ExpContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_exp);
						State = 62;
						if (!(Precpred(Context, 7))) throw new FailedPredicateException(this, "Precpred(Context, 7)");
						State = 63;
						_la = TokenStream.LA(1);
						if ( !(_la==Multiply || _la==Divide) ) {
						ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 64; exp(8);
						}
						break;
					case 3:
						{
						_localctx = new ExpContext(_parentctx, _parentState);
						PushNewRecursionContext(_localctx, _startState, RULE_exp);
						State = 65;
						if (!(Precpred(Context, 6))) throw new FailedPredicateException(this, "Precpred(Context, 6)");
						State = 66;
						_la = TokenStream.LA(1);
						if ( !(_la==Plus || _la==Minus) ) {
						ErrorHandler.RecoverInline(this);
						}
						else {
							ErrorHandler.ReportMatch(this);
						    Consume();
						}
						State = 67; exp(7);
						}
						break;
					}
					} 
				}
				State = 72;
				ErrorHandler.Sync(this);
				_alt = Interpreter.AdaptivePredict(TokenStream,7,Context);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			ErrorHandler.ReportError(this, re);
			ErrorHandler.Recover(this, re);
		}
		finally {
			UnrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public override bool Sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 5: return exp_sempred((ExpContext)_localctx, predIndex);
		}
		return true;
	}
	private bool exp_sempred(ExpContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0: return Precpred(Context, 8);
		case 1: return Precpred(Context, 7);
		case 2: return Precpred(Context, 6);
		}
		return true;
	}

	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x3', '\x14', 'L', '\x4', '\x2', '\t', '\x2', '\x4', '\x3', 
		'\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', '\x5', '\x4', 
		'\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x3', '\x2', '\x3', '\x2', 
		'\x3', '\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', 
		'\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x5', '\x5', '\x19', '\n', 
		'\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x5', '\x5', '\x1E', 
		'\n', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', '\x5', '\x3', 
		'\x5', '\x5', '\x5', '%', '\n', '\x5', '\x3', '\x5', '\x5', '\x5', '(', 
		'\n', '\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\x6', '\x5', 
		'\x6', '.', '\n', '\x6', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', 
		'\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', 
		'\x3', '\a', '\x3', '\a', '\x3', '\a', '\x5', '\a', '<', '\n', '\a', '\x3', 
		'\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', '\x3', '\a', 
		'\x3', '\a', '\x3', '\a', '\x3', '\a', '\a', '\a', 'G', '\n', '\a', '\f', 
		'\a', '\xE', '\a', 'J', '\v', '\a', '\x3', '\a', '\x2', '\x3', '\f', '\b', 
		'\x2', '\x4', '\x6', '\b', '\n', '\f', '\x2', '\a', '\x3', '\x2', '\x3', 
		'\x5', '\x3', '\x2', '\x6', '\a', '\x3', '\x2', '\x12', '\x13', '\x3', 
		'\x2', '\n', '\v', '\x3', '\x2', '\b', '\t', '\x2', 'Q', '\x2', '\xE', 
		'\x3', '\x2', '\x2', '\x2', '\x4', '\x10', '\x3', '\x2', '\x2', '\x2', 
		'\x6', '\x12', '\x3', '\x2', '\x2', '\x2', '\b', '\'', '\x3', '\x2', '\x2', 
		'\x2', '\n', ')', '\x3', '\x2', '\x2', '\x2', '\f', ';', '\x3', '\x2', 
		'\x2', '\x2', '\xE', '\xF', '\t', '\x2', '\x2', '\x2', '\xF', '\x3', '\x3', 
		'\x2', '\x2', '\x2', '\x10', '\x11', '\t', '\x3', '\x2', '\x2', '\x11', 
		'\x5', '\x3', '\x2', '\x2', '\x2', '\x12', '\x13', '\t', '\x4', '\x2', 
		'\x2', '\x13', '\a', '\x3', '\x2', '\x2', '\x2', '\x14', '\x15', '\a', 
		'\x10', '\x2', '\x2', '\x15', '\x18', '\a', '\r', '\x2', '\x2', '\x16', 
		'\x19', '\x5', '\f', '\a', '\x2', '\x17', '\x19', '\x3', '\x2', '\x2', 
		'\x2', '\x18', '\x16', '\x3', '\x2', '\x2', '\x2', '\x18', '\x17', '\x3', 
		'\x2', '\x2', '\x2', '\x19', '\x1A', '\x3', '\x2', '\x2', '\x2', '\x1A', 
		'\x1D', '\a', '\xF', '\x2', '\x2', '\x1B', '\x1E', '\x5', '\f', '\a', 
		'\x2', '\x1C', '\x1E', '\x3', '\x2', '\x2', '\x2', '\x1D', '\x1B', '\x3', 
		'\x2', '\x2', '\x2', '\x1D', '\x1C', '\x3', '\x2', '\x2', '\x2', '\x1E', 
		'\x1F', '\x3', '\x2', '\x2', '\x2', '\x1F', '(', '\a', '\xE', '\x2', '\x2', 
		' ', '!', '\a', '\x10', '\x2', '\x2', '!', '$', '\a', '\r', '\x2', '\x2', 
		'\"', '%', '\x5', '\f', '\a', '\x2', '#', '%', '\x3', '\x2', '\x2', '\x2', 
		'$', '\"', '\x3', '\x2', '\x2', '\x2', '$', '#', '\x3', '\x2', '\x2', 
		'\x2', '%', '&', '\x3', '\x2', '\x2', '\x2', '&', '(', '\a', '\xE', '\x2', 
		'\x2', '\'', '\x14', '\x3', '\x2', '\x2', '\x2', '\'', ' ', '\x3', '\x2', 
		'\x2', '\x2', '(', '\t', '\x3', '\x2', '\x2', '\x2', ')', '*', '\a', '\x11', 
		'\x2', '\x2', '*', '-', '\a', '\r', '\x2', '\x2', '+', '.', '\x5', '\f', 
		'\a', '\x2', ',', '.', '\x3', '\x2', '\x2', '\x2', '-', '+', '\x3', '\x2', 
		'\x2', '\x2', '-', ',', '\x3', '\x2', '\x2', '\x2', '.', '/', '\x3', '\x2', 
		'\x2', '\x2', '/', '\x30', '\a', '\xE', '\x2', '\x2', '\x30', '\v', '\x3', 
		'\x2', '\x2', '\x2', '\x31', '\x32', '\b', '\a', '\x1', '\x2', '\x32', 
		'\x33', '\a', '\r', '\x2', '\x2', '\x33', '\x34', '\x5', '\f', '\a', '\x2', 
		'\x34', '\x35', '\a', '\xE', '\x2', '\x2', '\x35', '<', '\x3', '\x2', 
		'\x2', '\x2', '\x36', '<', '\x5', '\b', '\x5', '\x2', '\x37', '<', '\x5', 
		'\n', '\x6', '\x2', '\x38', '\x39', '\a', '\r', '\x2', '\x2', '\x39', 
		'<', '\a', '\xE', '\x2', '\x2', ':', '<', '\x5', '\x6', '\x4', '\x2', 
		';', '\x31', '\x3', '\x2', '\x2', '\x2', ';', '\x36', '\x3', '\x2', '\x2', 
		'\x2', ';', '\x37', '\x3', '\x2', '\x2', '\x2', ';', '\x38', '\x3', '\x2', 
		'\x2', '\x2', ';', ':', '\x3', '\x2', '\x2', '\x2', '<', 'H', '\x3', '\x2', 
		'\x2', '\x2', '=', '>', '\f', '\n', '\x2', '\x2', '>', '?', '\a', '\f', 
		'\x2', '\x2', '?', 'G', '\x5', '\f', '\a', '\v', '@', '\x41', '\f', '\t', 
		'\x2', '\x2', '\x41', '\x42', '\t', '\x5', '\x2', '\x2', '\x42', 'G', 
		'\x5', '\f', '\a', '\n', '\x43', '\x44', '\f', '\b', '\x2', '\x2', '\x44', 
		'\x45', '\t', '\x6', '\x2', '\x2', '\x45', 'G', '\x5', '\f', '\a', '\t', 
		'\x46', '=', '\x3', '\x2', '\x2', '\x2', '\x46', '@', '\x3', '\x2', '\x2', 
		'\x2', '\x46', '\x43', '\x3', '\x2', '\x2', '\x2', 'G', 'J', '\x3', '\x2', 
		'\x2', '\x2', 'H', '\x46', '\x3', '\x2', '\x2', '\x2', 'H', 'I', '\x3', 
		'\x2', '\x2', '\x2', 'I', '\r', '\x3', '\x2', '\x2', '\x2', 'J', 'H', 
		'\x3', '\x2', '\x2', '\x2', '\n', '\x18', '\x1D', '$', '\'', '-', ';', 
		'\x46', 'H',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
