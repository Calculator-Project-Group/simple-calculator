// Generated from /media/songchaow/DATA/Codes/simple-calculator/calculator/calculator/parser/Calc.g4 by ANTLR 4.7.1
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.misc.*;
import org.antlr.v4.runtime.tree.*;
import java.util.List;
import java.util.Iterator;
import java.util.ArrayList;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class CalcParser extends Parser {
	static { RuntimeMetaData.checkVersion("4.7.1", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, Plus=6, Minus=7, Multiply=8, Divide=9, 
		Power=10, LeftParen=11, RightParen=12, Comma=13, LogID=14, TrigID=15, 
		Int=16, Float=17, WhiteSpace=18;
	public static final int
		RULE_constPI = 0, RULE_constE = 1, RULE_node = 2, RULE_log_exp = 3, RULE_trig_exp = 4, 
		RULE_exp = 5;
	public static final String[] ruleNames = {
		"constPI", "constE", "node", "log_exp", "trig_exp", "exp"
	};

	private static final String[] _LITERAL_NAMES = {
		null, "'PI'", "'pi'", "'\u03C0'", "'E'", "'e'", "'+'", "'-'", "'*'", "'/'", 
		"'^'"
	};
	private static final String[] _SYMBOLIC_NAMES = {
		null, null, null, null, null, null, "Plus", "Minus", "Multiply", "Divide", 
		"Power", "LeftParen", "RightParen", "Comma", "LogID", "TrigID", "Int", 
		"Float", "WhiteSpace"
	};
	public static final Vocabulary VOCABULARY = new VocabularyImpl(_LITERAL_NAMES, _SYMBOLIC_NAMES);

	/**
	 * @deprecated Use {@link #VOCABULARY} instead.
	 */
	@Deprecated
	public static final String[] tokenNames;
	static {
		tokenNames = new String[_SYMBOLIC_NAMES.length];
		for (int i = 0; i < tokenNames.length; i++) {
			tokenNames[i] = VOCABULARY.getLiteralName(i);
			if (tokenNames[i] == null) {
				tokenNames[i] = VOCABULARY.getSymbolicName(i);
			}

			if (tokenNames[i] == null) {
				tokenNames[i] = "<INVALID>";
			}
		}
	}

	@Override
	@Deprecated
	public String[] getTokenNames() {
		return tokenNames;
	}

	@Override

	public Vocabulary getVocabulary() {
		return VOCABULARY;
	}

	@Override
	public String getGrammarFileName() { return "Calc.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public ATN getATN() { return _ATN; }

	public CalcParser(TokenStream input) {
		super(input);
		_interp = new ParserATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}
	public static class ConstPIContext extends ParserRuleContext {
		public ConstPIContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_constPI; }
	}

	public final ConstPIContext constPI() throws RecognitionException {
		ConstPIContext _localctx = new ConstPIContext(_ctx, getState());
		enterRule(_localctx, 0, RULE_constPI);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(12);
			_la = _input.LA(1);
			if ( !((((_la) & ~0x3f) == 0 && ((1L << _la) & ((1L << T__0) | (1L << T__1) | (1L << T__2))) != 0)) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ConstEContext extends ParserRuleContext {
		public ConstEContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_constE; }
	}

	public final ConstEContext constE() throws RecognitionException {
		ConstEContext _localctx = new ConstEContext(_ctx, getState());
		enterRule(_localctx, 2, RULE_constE);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(14);
			_la = _input.LA(1);
			if ( !(_la==T__3 || _la==T__4) ) {
			_errHandler.recoverInline(this);
			}
			else {
				if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
				_errHandler.reportMatch(this);
				consume();
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class NodeContext extends ParserRuleContext {
		public TerminalNode Int() { return getToken(CalcParser.Int, 0); }
		public TerminalNode Float() { return getToken(CalcParser.Float, 0); }
		public ConstPIContext constPI() {
			return getRuleContext(ConstPIContext.class,0);
		}
		public ConstEContext constE() {
			return getRuleContext(ConstEContext.class,0);
		}
		public NodeContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_node; }
	}

	public final NodeContext node() throws RecognitionException {
		NodeContext _localctx = new NodeContext(_ctx, getState());
		enterRule(_localctx, 4, RULE_node);
		try {
			setState(20);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case Int:
				enterOuterAlt(_localctx, 1);
				{
				setState(16);
				match(Int);
				}
				break;
			case Float:
				enterOuterAlt(_localctx, 2);
				{
				setState(17);
				match(Float);
				}
				break;
			case T__0:
			case T__1:
			case T__2:
				enterOuterAlt(_localctx, 3);
				{
				setState(18);
				constPI();
				}
				break;
			case T__3:
			case T__4:
				enterOuterAlt(_localctx, 4);
				{
				setState(19);
				constE();
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Log_expContext extends ParserRuleContext {
		public TerminalNode LogID() { return getToken(CalcParser.LogID, 0); }
		public TerminalNode LeftParen() { return getToken(CalcParser.LeftParen, 0); }
		public TerminalNode Comma() { return getToken(CalcParser.Comma, 0); }
		public TerminalNode RightParen() { return getToken(CalcParser.RightParen, 0); }
		public List<ExpContext> exp() {
			return getRuleContexts(ExpContext.class);
		}
		public ExpContext exp(int i) {
			return getRuleContext(ExpContext.class,i);
		}
		public Log_expContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_log_exp; }
	}

	public final Log_expContext log_exp() throws RecognitionException {
		Log_expContext _localctx = new Log_expContext(_ctx, getState());
		enterRule(_localctx, 6, RULE_log_exp);
		try {
			setState(41);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,4,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(22);
				match(LogID);
				setState(23);
				match(LeftParen);
				setState(26);
				_errHandler.sync(this);
				switch (_input.LA(1)) {
				case T__0:
				case T__1:
				case T__2:
				case T__3:
				case T__4:
				case Minus:
				case LeftParen:
				case LogID:
				case TrigID:
				case Int:
				case Float:
					{
					setState(24);
					exp(0);
					}
					break;
				case Comma:
					{
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				setState(28);
				match(Comma);
				setState(31);
				_errHandler.sync(this);
				switch (_input.LA(1)) {
				case T__0:
				case T__1:
				case T__2:
				case T__3:
				case T__4:
				case Minus:
				case LeftParen:
				case LogID:
				case TrigID:
				case Int:
				case Float:
					{
					setState(29);
					exp(0);
					}
					break;
				case RightParen:
					{
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				setState(33);
				match(RightParen);
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(34);
				match(LogID);
				setState(35);
				match(LeftParen);
				setState(38);
				_errHandler.sync(this);
				switch (_input.LA(1)) {
				case T__0:
				case T__1:
				case T__2:
				case T__3:
				case T__4:
				case Minus:
				case LeftParen:
				case LogID:
				case TrigID:
				case Int:
				case Float:
					{
					setState(36);
					exp(0);
					}
					break;
				case RightParen:
					{
					}
					break;
				default:
					throw new NoViableAltException(this);
				}
				setState(40);
				match(RightParen);
				}
				break;
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class Trig_expContext extends ParserRuleContext {
		public TerminalNode TrigID() { return getToken(CalcParser.TrigID, 0); }
		public TerminalNode LeftParen() { return getToken(CalcParser.LeftParen, 0); }
		public TerminalNode RightParen() { return getToken(CalcParser.RightParen, 0); }
		public ExpContext exp() {
			return getRuleContext(ExpContext.class,0);
		}
		public Trig_expContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_trig_exp; }
	}

	public final Trig_expContext trig_exp() throws RecognitionException {
		Trig_expContext _localctx = new Trig_expContext(_ctx, getState());
		enterRule(_localctx, 8, RULE_trig_exp);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(43);
			match(TrigID);
			setState(44);
			match(LeftParen);
			setState(47);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case T__0:
			case T__1:
			case T__2:
			case T__3:
			case T__4:
			case Minus:
			case LeftParen:
			case LogID:
			case TrigID:
			case Int:
			case Float:
				{
				setState(45);
				exp(0);
				}
				break;
			case RightParen:
				{
				}
				break;
			default:
				throw new NoViableAltException(this);
			}
			setState(49);
			match(RightParen);
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			exitRule();
		}
		return _localctx;
	}

	public static class ExpContext extends ParserRuleContext {
		public TerminalNode Minus() { return getToken(CalcParser.Minus, 0); }
		public List<ExpContext> exp() {
			return getRuleContexts(ExpContext.class);
		}
		public ExpContext exp(int i) {
			return getRuleContext(ExpContext.class,i);
		}
		public TerminalNode LeftParen() { return getToken(CalcParser.LeftParen, 0); }
		public TerminalNode RightParen() { return getToken(CalcParser.RightParen, 0); }
		public Log_expContext log_exp() {
			return getRuleContext(Log_expContext.class,0);
		}
		public Trig_expContext trig_exp() {
			return getRuleContext(Trig_expContext.class,0);
		}
		public NodeContext node() {
			return getRuleContext(NodeContext.class,0);
		}
		public TerminalNode Power() { return getToken(CalcParser.Power, 0); }
		public TerminalNode Multiply() { return getToken(CalcParser.Multiply, 0); }
		public TerminalNode Divide() { return getToken(CalcParser.Divide, 0); }
		public TerminalNode Plus() { return getToken(CalcParser.Plus, 0); }
		public ExpContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_exp; }
	}

	public final ExpContext exp() throws RecognitionException {
		return exp(0);
	}

	private ExpContext exp(int _p) throws RecognitionException {
		ParserRuleContext _parentctx = _ctx;
		int _parentState = getState();
		ExpContext _localctx = new ExpContext(_ctx, _parentState);
		ExpContext _prevctx = _localctx;
		int _startState = 10;
		enterRecursionRule(_localctx, 10, RULE_exp, _p);
		int _la;
		try {
			int _alt;
			enterOuterAlt(_localctx, 1);
			{
			setState(63);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,6,_ctx) ) {
			case 1:
				{
				setState(52);
				match(Minus);
				setState(53);
				exp(8);
				}
				break;
			case 2:
				{
				setState(54);
				match(LeftParen);
				setState(55);
				exp(0);
				setState(56);
				match(RightParen);
				}
				break;
			case 3:
				{
				setState(58);
				log_exp();
				}
				break;
			case 4:
				{
				setState(59);
				trig_exp();
				}
				break;
			case 5:
				{
				setState(60);
				match(LeftParen);
				setState(61);
				match(RightParen);
				}
				break;
			case 6:
				{
				setState(62);
				node();
				}
				break;
			}
			_ctx.stop = _input.LT(-1);
			setState(76);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,8,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					setState(74);
					_errHandler.sync(this);
					switch ( getInterpreter().adaptivePredict(_input,7,_ctx) ) {
					case 1:
						{
						_localctx = new ExpContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_exp);
						setState(65);
						if (!(precpred(_ctx, 9))) throw new FailedPredicateException(this, "precpred(_ctx, 9)");
						setState(66);
						match(Power);
						setState(67);
						exp(10);
						}
						break;
					case 2:
						{
						_localctx = new ExpContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_exp);
						setState(68);
						if (!(precpred(_ctx, 7))) throw new FailedPredicateException(this, "precpred(_ctx, 7)");
						setState(69);
						_la = _input.LA(1);
						if ( !(_la==Multiply || _la==Divide) ) {
						_errHandler.recoverInline(this);
						}
						else {
							if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
							_errHandler.reportMatch(this);
							consume();
						}
						setState(70);
						exp(8);
						}
						break;
					case 3:
						{
						_localctx = new ExpContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_exp);
						setState(71);
						if (!(precpred(_ctx, 6))) throw new FailedPredicateException(this, "precpred(_ctx, 6)");
						setState(72);
						_la = _input.LA(1);
						if ( !(_la==Plus || _la==Minus) ) {
						_errHandler.recoverInline(this);
						}
						else {
							if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
							_errHandler.reportMatch(this);
							consume();
						}
						setState(73);
						exp(7);
						}
						break;
					}
					} 
				}
				setState(78);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,8,_ctx);
			}
			}
		}
		catch (RecognitionException re) {
			_localctx.exception = re;
			_errHandler.reportError(this, re);
			_errHandler.recover(this, re);
		}
		finally {
			unrollRecursionContexts(_parentctx);
		}
		return _localctx;
	}

	public boolean sempred(RuleContext _localctx, int ruleIndex, int predIndex) {
		switch (ruleIndex) {
		case 5:
			return exp_sempred((ExpContext)_localctx, predIndex);
		}
		return true;
	}
	private boolean exp_sempred(ExpContext _localctx, int predIndex) {
		switch (predIndex) {
		case 0:
			return precpred(_ctx, 9);
		case 1:
			return precpred(_ctx, 7);
		case 2:
			return precpred(_ctx, 6);
		}
		return true;
	}

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\3\24R\4\2\t\2\4\3\t"+
		"\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\3\2\3\2\3\3\3\3\3\4\3\4\3\4\3\4\5\4"+
		"\27\n\4\3\5\3\5\3\5\3\5\5\5\35\n\5\3\5\3\5\3\5\5\5\"\n\5\3\5\3\5\3\5\3"+
		"\5\3\5\5\5)\n\5\3\5\5\5,\n\5\3\6\3\6\3\6\3\6\5\6\62\n\6\3\6\3\6\3\7\3"+
		"\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\5\7B\n\7\3\7\3\7\3\7\3\7\3"+
		"\7\3\7\3\7\3\7\3\7\7\7M\n\7\f\7\16\7P\13\7\3\7\2\3\f\b\2\4\6\b\n\f\2\6"+
		"\3\2\3\5\3\2\6\7\3\2\n\13\3\2\b\t\2[\2\16\3\2\2\2\4\20\3\2\2\2\6\26\3"+
		"\2\2\2\b+\3\2\2\2\n-\3\2\2\2\fA\3\2\2\2\16\17\t\2\2\2\17\3\3\2\2\2\20"+
		"\21\t\3\2\2\21\5\3\2\2\2\22\27\7\22\2\2\23\27\7\23\2\2\24\27\5\2\2\2\25"+
		"\27\5\4\3\2\26\22\3\2\2\2\26\23\3\2\2\2\26\24\3\2\2\2\26\25\3\2\2\2\27"+
		"\7\3\2\2\2\30\31\7\20\2\2\31\34\7\r\2\2\32\35\5\f\7\2\33\35\3\2\2\2\34"+
		"\32\3\2\2\2\34\33\3\2\2\2\35\36\3\2\2\2\36!\7\17\2\2\37\"\5\f\7\2 \"\3"+
		"\2\2\2!\37\3\2\2\2! \3\2\2\2\"#\3\2\2\2#,\7\16\2\2$%\7\20\2\2%(\7\r\2"+
		"\2&)\5\f\7\2\')\3\2\2\2(&\3\2\2\2(\'\3\2\2\2)*\3\2\2\2*,\7\16\2\2+\30"+
		"\3\2\2\2+$\3\2\2\2,\t\3\2\2\2-.\7\21\2\2.\61\7\r\2\2/\62\5\f\7\2\60\62"+
		"\3\2\2\2\61/\3\2\2\2\61\60\3\2\2\2\62\63\3\2\2\2\63\64\7\16\2\2\64\13"+
		"\3\2\2\2\65\66\b\7\1\2\66\67\7\t\2\2\67B\5\f\7\n89\7\r\2\29:\5\f\7\2:"+
		";\7\16\2\2;B\3\2\2\2<B\5\b\5\2=B\5\n\6\2>?\7\r\2\2?B\7\16\2\2@B\5\6\4"+
		"\2A\65\3\2\2\2A8\3\2\2\2A<\3\2\2\2A=\3\2\2\2A>\3\2\2\2A@\3\2\2\2BN\3\2"+
		"\2\2CD\f\13\2\2DE\7\f\2\2EM\5\f\7\fFG\f\t\2\2GH\t\4\2\2HM\5\f\7\nIJ\f"+
		"\b\2\2JK\t\5\2\2KM\5\f\7\tLC\3\2\2\2LF\3\2\2\2LI\3\2\2\2MP\3\2\2\2NL\3"+
		"\2\2\2NO\3\2\2\2O\r\3\2\2\2PN\3\2\2\2\13\26\34!(+\61ALN";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}