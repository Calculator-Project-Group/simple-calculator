// Generated from Calc.g4 by ANTLR 4.7
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
	static { RuntimeMetaData.checkVersion("4.7", RuntimeMetaData.VERSION); }

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
		"'^'", "'('", "')'", "','"
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
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof CalcListener ) ((CalcListener)listener).enterConstPI(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof CalcListener ) ((CalcListener)listener).exitConstPI(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof CalcVisitor ) return ((CalcVisitor<? extends T>)visitor).visitConstPI(this);
			else return visitor.visitChildren(this);
		}
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
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof CalcListener ) ((CalcListener)listener).enterConstE(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof CalcListener ) ((CalcListener)listener).exitConstE(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof CalcVisitor ) return ((CalcVisitor<? extends T>)visitor).visitConstE(this);
			else return visitor.visitChildren(this);
		}
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
		public NodeContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_node; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof CalcListener ) ((CalcListener)listener).enterNode(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof CalcListener ) ((CalcListener)listener).exitNode(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof CalcVisitor ) return ((CalcVisitor<? extends T>)visitor).visitNode(this);
			else return visitor.visitChildren(this);
		}
	}

	public final NodeContext node() throws RecognitionException {
		NodeContext _localctx = new NodeContext(_ctx, getState());
		enterRule(_localctx, 4, RULE_node);
		int _la;
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(16);
			_la = _input.LA(1);
			if ( !(_la==Int || _la==Float) ) {
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
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof CalcListener ) ((CalcListener)listener).enterLog_exp(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof CalcListener ) ((CalcListener)listener).exitLog_exp(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof CalcVisitor ) return ((CalcVisitor<? extends T>)visitor).visitLog_exp(this);
			else return visitor.visitChildren(this);
		}
	}

	public final Log_expContext log_exp() throws RecognitionException {
		Log_expContext _localctx = new Log_expContext(_ctx, getState());
		enterRule(_localctx, 6, RULE_log_exp);
		try {
			setState(37);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,3,_ctx) ) {
			case 1:
				enterOuterAlt(_localctx, 1);
				{
				setState(18);
				match(LogID);
				setState(19);
				match(LeftParen);
				setState(22);
				_errHandler.sync(this);
				switch (_input.LA(1)) {
				case LeftParen:
				case LogID:
				case TrigID:
				case Int:
				case Float:
					{
					setState(20);
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
				setState(24);
				match(Comma);
				setState(27);
				_errHandler.sync(this);
				switch (_input.LA(1)) {
				case LeftParen:
				case LogID:
				case TrigID:
				case Int:
				case Float:
					{
					setState(25);
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
				setState(29);
				match(RightParen);
				}
				break;
			case 2:
				enterOuterAlt(_localctx, 2);
				{
				setState(30);
				match(LogID);
				setState(31);
				match(LeftParen);
				setState(34);
				_errHandler.sync(this);
				switch (_input.LA(1)) {
				case LeftParen:
				case LogID:
				case TrigID:
				case Int:
				case Float:
					{
					setState(32);
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
				setState(36);
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
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof CalcListener ) ((CalcListener)listener).enterTrig_exp(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof CalcListener ) ((CalcListener)listener).exitTrig_exp(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof CalcVisitor ) return ((CalcVisitor<? extends T>)visitor).visitTrig_exp(this);
			else return visitor.visitChildren(this);
		}
	}

	public final Trig_expContext trig_exp() throws RecognitionException {
		Trig_expContext _localctx = new Trig_expContext(_ctx, getState());
		enterRule(_localctx, 8, RULE_trig_exp);
		try {
			enterOuterAlt(_localctx, 1);
			{
			setState(39);
			match(TrigID);
			setState(40);
			match(LeftParen);
			setState(43);
			_errHandler.sync(this);
			switch (_input.LA(1)) {
			case LeftParen:
			case LogID:
			case TrigID:
			case Int:
			case Float:
				{
				setState(41);
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
			setState(45);
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
		public TerminalNode LeftParen() { return getToken(CalcParser.LeftParen, 0); }
		public List<ExpContext> exp() {
			return getRuleContexts(ExpContext.class);
		}
		public ExpContext exp(int i) {
			return getRuleContext(ExpContext.class,i);
		}
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
		public TerminalNode Minus() { return getToken(CalcParser.Minus, 0); }
		public ExpContext(ParserRuleContext parent, int invokingState) {
			super(parent, invokingState);
		}
		@Override public int getRuleIndex() { return RULE_exp; }
		@Override
		public void enterRule(ParseTreeListener listener) {
			if ( listener instanceof CalcListener ) ((CalcListener)listener).enterExp(this);
		}
		@Override
		public void exitRule(ParseTreeListener listener) {
			if ( listener instanceof CalcListener ) ((CalcListener)listener).exitExp(this);
		}
		@Override
		public <T> T accept(ParseTreeVisitor<? extends T> visitor) {
			if ( visitor instanceof CalcVisitor ) return ((CalcVisitor<? extends T>)visitor).visitExp(this);
			else return visitor.visitChildren(this);
		}
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
			setState(57);
			_errHandler.sync(this);
			switch ( getInterpreter().adaptivePredict(_input,5,_ctx) ) {
			case 1:
				{
				setState(48);
				match(LeftParen);
				setState(49);
				exp(0);
				setState(50);
				match(RightParen);
				}
				break;
			case 2:
				{
				setState(52);
				log_exp();
				}
				break;
			case 3:
				{
				setState(53);
				trig_exp();
				}
				break;
			case 4:
				{
				setState(54);
				match(LeftParen);
				setState(55);
				match(RightParen);
				}
				break;
			case 5:
				{
				setState(56);
				node();
				}
				break;
			}
			_ctx.stop = _input.LT(-1);
			setState(70);
			_errHandler.sync(this);
			_alt = getInterpreter().adaptivePredict(_input,7,_ctx);
			while ( _alt!=2 && _alt!=org.antlr.v4.runtime.atn.ATN.INVALID_ALT_NUMBER ) {
				if ( _alt==1 ) {
					if ( _parseListeners!=null ) triggerExitRuleEvent();
					_prevctx = _localctx;
					{
					setState(68);
					_errHandler.sync(this);
					switch ( getInterpreter().adaptivePredict(_input,6,_ctx) ) {
					case 1:
						{
						_localctx = new ExpContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_exp);
						setState(59);
						if (!(precpred(_ctx, 8))) throw new FailedPredicateException(this, "precpred(_ctx, 8)");
						setState(60);
						match(Power);
						setState(61);
						exp(9);
						}
						break;
					case 2:
						{
						_localctx = new ExpContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_exp);
						setState(62);
						if (!(precpred(_ctx, 7))) throw new FailedPredicateException(this, "precpred(_ctx, 7)");
						setState(63);
						_la = _input.LA(1);
						if ( !(_la==Multiply || _la==Divide) ) {
						_errHandler.recoverInline(this);
						}
						else {
							if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
							_errHandler.reportMatch(this);
							consume();
						}
						setState(64);
						exp(8);
						}
						break;
					case 3:
						{
						_localctx = new ExpContext(_parentctx, _parentState);
						pushNewRecursionContext(_localctx, _startState, RULE_exp);
						setState(65);
						if (!(precpred(_ctx, 6))) throw new FailedPredicateException(this, "precpred(_ctx, 6)");
						setState(66);
						_la = _input.LA(1);
						if ( !(_la==Plus || _la==Minus) ) {
						_errHandler.recoverInline(this);
						}
						else {
							if ( _input.LA(1)==Token.EOF ) matchedEOF = true;
							_errHandler.reportMatch(this);
							consume();
						}
						setState(67);
						exp(7);
						}
						break;
					}
					} 
				}
				setState(72);
				_errHandler.sync(this);
				_alt = getInterpreter().adaptivePredict(_input,7,_ctx);
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
			return precpred(_ctx, 8);
		case 1:
			return precpred(_ctx, 7);
		case 2:
			return precpred(_ctx, 6);
		}
		return true;
	}

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\3\24L\4\2\t\2\4\3\t"+
		"\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\3\2\3\2\3\3\3\3\3\4\3\4\3\5\3\5\3\5"+
		"\3\5\5\5\31\n\5\3\5\3\5\3\5\5\5\36\n\5\3\5\3\5\3\5\3\5\3\5\5\5%\n\5\3"+
		"\5\5\5(\n\5\3\6\3\6\3\6\3\6\5\6.\n\6\3\6\3\6\3\7\3\7\3\7\3\7\3\7\3\7\3"+
		"\7\3\7\3\7\3\7\5\7<\n\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\3\7\7\7G\n\7\f"+
		"\7\16\7J\13\7\3\7\2\3\f\b\2\4\6\b\n\f\2\7\3\2\3\5\3\2\6\7\3\2\22\23\3"+
		"\2\n\13\3\2\b\t\2Q\2\16\3\2\2\2\4\20\3\2\2\2\6\22\3\2\2\2\b\'\3\2\2\2"+
		"\n)\3\2\2\2\f;\3\2\2\2\16\17\t\2\2\2\17\3\3\2\2\2\20\21\t\3\2\2\21\5\3"+
		"\2\2\2\22\23\t\4\2\2\23\7\3\2\2\2\24\25\7\20\2\2\25\30\7\r\2\2\26\31\5"+
		"\f\7\2\27\31\3\2\2\2\30\26\3\2\2\2\30\27\3\2\2\2\31\32\3\2\2\2\32\35\7"+
		"\17\2\2\33\36\5\f\7\2\34\36\3\2\2\2\35\33\3\2\2\2\35\34\3\2\2\2\36\37"+
		"\3\2\2\2\37(\7\16\2\2 !\7\20\2\2!$\7\r\2\2\"%\5\f\7\2#%\3\2\2\2$\"\3\2"+
		"\2\2$#\3\2\2\2%&\3\2\2\2&(\7\16\2\2\'\24\3\2\2\2\' \3\2\2\2(\t\3\2\2\2"+
		")*\7\21\2\2*-\7\r\2\2+.\5\f\7\2,.\3\2\2\2-+\3\2\2\2-,\3\2\2\2./\3\2\2"+
		"\2/\60\7\16\2\2\60\13\3\2\2\2\61\62\b\7\1\2\62\63\7\r\2\2\63\64\5\f\7"+
		"\2\64\65\7\16\2\2\65<\3\2\2\2\66<\5\b\5\2\67<\5\n\6\289\7\r\2\29<\7\16"+
		"\2\2:<\5\6\4\2;\61\3\2\2\2;\66\3\2\2\2;\67\3\2\2\2;8\3\2\2\2;:\3\2\2\2"+
		"<H\3\2\2\2=>\f\n\2\2>?\7\f\2\2?G\5\f\7\13@A\f\t\2\2AB\t\5\2\2BG\5\f\7"+
		"\nCD\f\b\2\2DE\t\6\2\2EG\5\f\7\tF=\3\2\2\2F@\3\2\2\2FC\3\2\2\2GJ\3\2\2"+
		"\2HF\3\2\2\2HI\3\2\2\2I\r\3\2\2\2JH\3\2\2\2\n\30\35$\'-;FH";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}