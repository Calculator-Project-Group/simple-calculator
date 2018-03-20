// Generated from Calc.g4 by ANTLR 4.7
import org.antlr.v4.runtime.Lexer;
import org.antlr.v4.runtime.CharStream;
import org.antlr.v4.runtime.Token;
import org.antlr.v4.runtime.TokenStream;
import org.antlr.v4.runtime.*;
import org.antlr.v4.runtime.atn.*;
import org.antlr.v4.runtime.dfa.DFA;
import org.antlr.v4.runtime.misc.*;

@SuppressWarnings({"all", "warnings", "unchecked", "unused", "cast"})
public class CalcLexer extends Lexer {
	static { RuntimeMetaData.checkVersion("4.7", RuntimeMetaData.VERSION); }

	protected static final DFA[] _decisionToDFA;
	protected static final PredictionContextCache _sharedContextCache =
		new PredictionContextCache();
	public static final int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, Plus=6, Minus=7, Multiply=8, Divide=9, 
		Power=10, LeftParen=11, RightParen=12, Comma=13, LogID=14, TrigID=15, 
		Int=16, Float=17, WhiteSpace=18;
	public static String[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static String[] modeNames = {
		"DEFAULT_MODE"
	};

	public static final String[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "Plus", "Minus", "Multiply", "Divide", 
		"Power", "LeftParen", "RightParen", "Comma", "LogID", "TrigID", "Int", 
		"Float", "WhiteSpace"
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


	public CalcLexer(CharStream input) {
		super(input);
		_interp = new LexerATNSimulator(this,_ATN,_decisionToDFA,_sharedContextCache);
	}

	@Override
	public String getGrammarFileName() { return "Calc.g4"; }

	@Override
	public String[] getRuleNames() { return ruleNames; }

	@Override
	public String getSerializedATN() { return _serializedATN; }

	@Override
	public String[] getChannelNames() { return channelNames; }

	@Override
	public String[] getModeNames() { return modeNames; }

	@Override
	public ATN getATN() { return _ATN; }

	public static final String _serializedATN =
		"\3\u608b\ua72a\u8133\ub9ed\u417c\u3be7\u7786\u5964\2\24\u0080\b\1\4\2"+
		"\t\2\4\3\t\3\4\4\t\4\4\5\t\5\4\6\t\6\4\7\t\7\4\b\t\b\4\t\t\t\4\n\t\n\4"+
		"\13\t\13\4\f\t\f\4\r\t\r\4\16\t\16\4\17\t\17\4\20\t\20\4\21\t\21\4\22"+
		"\t\22\4\23\t\23\3\2\3\2\3\2\3\3\3\3\3\3\3\4\3\4\3\5\3\5\3\6\3\6\3\7\3"+
		"\7\3\b\3\b\3\t\3\t\3\n\3\n\3\13\3\13\3\f\3\f\3\r\3\r\3\16\3\16\3\17\3"+
		"\17\3\17\3\17\3\17\3\17\5\17J\n\17\3\20\3\20\3\20\3\20\3\20\3\20\3\20"+
		"\3\20\3\20\3\20\3\20\3\20\3\20\3\20\3\20\3\20\3\20\3\20\5\20^\n\20\3\21"+
		"\3\21\3\21\7\21c\n\21\f\21\16\21f\13\21\5\21h\n\21\3\22\3\22\7\22l\n\22"+
		"\f\22\16\22o\13\22\3\22\5\22r\n\22\3\22\3\22\6\22v\n\22\r\22\16\22w\3"+
		"\23\6\23{\n\23\r\23\16\23|\3\23\3\23\2\2\24\3\3\5\4\7\5\t\6\13\7\r\b\17"+
		"\t\21\n\23\13\25\f\27\r\31\16\33\17\35\20\37\21!\22#\23%\24\3\2\b\4\2"+
		"**\uff0a\uff0a\4\2++\uff0b\uff0b\4\2..\uff0e\uff0e\3\2\62;\3\2\63;\5\2"+
		"\13\f\17\17\"\"\2\u008b\2\3\3\2\2\2\2\5\3\2\2\2\2\7\3\2\2\2\2\t\3\2\2"+
		"\2\2\13\3\2\2\2\2\r\3\2\2\2\2\17\3\2\2\2\2\21\3\2\2\2\2\23\3\2\2\2\2\25"+
		"\3\2\2\2\2\27\3\2\2\2\2\31\3\2\2\2\2\33\3\2\2\2\2\35\3\2\2\2\2\37\3\2"+
		"\2\2\2!\3\2\2\2\2#\3\2\2\2\2%\3\2\2\2\3\'\3\2\2\2\5*\3\2\2\2\7-\3\2\2"+
		"\2\t/\3\2\2\2\13\61\3\2\2\2\r\63\3\2\2\2\17\65\3\2\2\2\21\67\3\2\2\2\23"+
		"9\3\2\2\2\25;\3\2\2\2\27=\3\2\2\2\31?\3\2\2\2\33A\3\2\2\2\35I\3\2\2\2"+
		"\37]\3\2\2\2!g\3\2\2\2#q\3\2\2\2%z\3\2\2\2\'(\7R\2\2()\7K\2\2)\4\3\2\2"+
		"\2*+\7r\2\2+,\7k\2\2,\6\3\2\2\2-.\7\u03c2\2\2.\b\3\2\2\2/\60\7G\2\2\60"+
		"\n\3\2\2\2\61\62\7g\2\2\62\f\3\2\2\2\63\64\7-\2\2\64\16\3\2\2\2\65\66"+
		"\7/\2\2\66\20\3\2\2\2\678\7,\2\28\22\3\2\2\29:\7\61\2\2:\24\3\2\2\2;<"+
		"\7`\2\2<\26\3\2\2\2=>\t\2\2\2>\30\3\2\2\2?@\t\3\2\2@\32\3\2\2\2AB\t\4"+
		"\2\2B\34\3\2\2\2CD\7n\2\2DE\7q\2\2EJ\7i\2\2FG\7N\2\2GH\7q\2\2HJ\7i\2\2"+
		"IC\3\2\2\2IF\3\2\2\2J\36\3\2\2\2KL\7u\2\2LM\7k\2\2M^\7p\2\2NO\7U\2\2O"+
		"P\7k\2\2P^\7p\2\2QR\7e\2\2RS\7q\2\2S^\7u\2\2TU\7E\2\2UV\7q\2\2V^\7u\2"+
		"\2WX\7v\2\2XY\7c\2\2Y^\7p\2\2Z[\7V\2\2[\\\7c\2\2\\^\7p\2\2]K\3\2\2\2]"+
		"N\3\2\2\2]Q\3\2\2\2]T\3\2\2\2]W\3\2\2\2]Z\3\2\2\2^ \3\2\2\2_h\t\5\2\2"+
		"`d\t\6\2\2ac\t\5\2\2ba\3\2\2\2cf\3\2\2\2db\3\2\2\2de\3\2\2\2eh\3\2\2\2"+
		"fd\3\2\2\2g_\3\2\2\2g`\3\2\2\2h\"\3\2\2\2im\t\6\2\2jl\t\5\2\2kj\3\2\2"+
		"\2lo\3\2\2\2mk\3\2\2\2mn\3\2\2\2nr\3\2\2\2om\3\2\2\2pr\t\5\2\2qi\3\2\2"+
		"\2qp\3\2\2\2rs\3\2\2\2su\7\60\2\2tv\t\5\2\2ut\3\2\2\2vw\3\2\2\2wu\3\2"+
		"\2\2wx\3\2\2\2x$\3\2\2\2y{\t\7\2\2zy\3\2\2\2{|\3\2\2\2|z\3\2\2\2|}\3\2"+
		"\2\2}~\3\2\2\2~\177\b\23\2\2\177&\3\2\2\2\13\2I]dgmqw|\3\b\2\2";
	public static final ATN _ATN =
		new ATNDeserializer().deserialize(_serializedATN.toCharArray());
	static {
		_decisionToDFA = new DFA[_ATN.getNumberOfDecisions()];
		for (int i = 0; i < _ATN.getNumberOfDecisions(); i++) {
			_decisionToDFA[i] = new DFA(_ATN.getDecisionState(i), i);
		}
	}
}