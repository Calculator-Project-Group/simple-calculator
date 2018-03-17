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
using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using DFA = Antlr4.Runtime.Dfa.DFA;

[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.7")]
[System.CLSCompliant(false)]
public partial class CalcLexer : Lexer {
	protected static DFA[] decisionToDFA;
	protected static PredictionContextCache sharedContextCache = new PredictionContextCache();
	public const int
		T__0=1, T__1=2, T__2=3, T__3=4, T__4=5, Plus=6, Minus=7, Multiply=8, Divide=9, 
		Power=10, LeftParen=11, RightParen=12, Comma=13, LogID=14, TrigID=15, 
		Int=16, Float=17, WhiteSpace=18;
	public static string[] channelNames = {
		"DEFAULT_TOKEN_CHANNEL", "HIDDEN"
	};

	public static string[] modeNames = {
		"DEFAULT_MODE"
	};

	public static readonly string[] ruleNames = {
		"T__0", "T__1", "T__2", "T__3", "T__4", "Plus", "Minus", "Multiply", "Divide", 
		"Power", "LeftParen", "RightParen", "Comma", "LogID", "TrigID", "Int", 
		"Float", "WhiteSpace"
	};


	public CalcLexer(ICharStream input)
	: this(input, Console.Out, Console.Error) { }

	public CalcLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
	: base(input, output, errorOutput)
	{
		Interpreter = new LexerATNSimulator(this, _ATN, decisionToDFA, sharedContextCache);
	}

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

	public override string[] ChannelNames { get { return channelNames; } }

	public override string[] ModeNames { get { return modeNames; } }

	public override string SerializedAtn { get { return new string(_serializedATN); } }

	static CalcLexer() {
		decisionToDFA = new DFA[_ATN.NumberOfDecisions];
		for (int i = 0; i < _ATN.NumberOfDecisions; i++) {
			decisionToDFA[i] = new DFA(_ATN.GetDecisionState(i), i);
		}
	}
	private static char[] _serializedATN = {
		'\x3', '\x608B', '\xA72A', '\x8133', '\xB9ED', '\x417C', '\x3BE7', '\x7786', 
		'\x5964', '\x2', '\x14', '}', '\b', '\x1', '\x4', '\x2', '\t', '\x2', 
		'\x4', '\x3', '\t', '\x3', '\x4', '\x4', '\t', '\x4', '\x4', '\x5', '\t', 
		'\x5', '\x4', '\x6', '\t', '\x6', '\x4', '\a', '\t', '\a', '\x4', '\b', 
		'\t', '\b', '\x4', '\t', '\t', '\t', '\x4', '\n', '\t', '\n', '\x4', '\v', 
		'\t', '\v', '\x4', '\f', '\t', '\f', '\x4', '\r', '\t', '\r', '\x4', '\xE', 
		'\t', '\xE', '\x4', '\xF', '\t', '\xF', '\x4', '\x10', '\t', '\x10', '\x4', 
		'\x11', '\t', '\x11', '\x4', '\x12', '\t', '\x12', '\x4', '\x13', '\t', 
		'\x13', '\x3', '\x2', '\x3', '\x2', '\x3', '\x2', '\x3', '\x3', '\x3', 
		'\x3', '\x3', '\x3', '\x3', '\x4', '\x3', '\x4', '\x3', '\x5', '\x3', 
		'\x5', '\x3', '\x6', '\x3', '\x6', '\x3', '\a', '\x3', '\a', '\x3', '\b', 
		'\x3', '\b', '\x3', '\t', '\x3', '\t', '\x3', '\n', '\x3', '\n', '\x3', 
		'\v', '\x3', '\v', '\x3', '\f', '\x3', '\f', '\x3', '\r', '\x3', '\r', 
		'\x3', '\xE', '\x3', '\xE', '\x3', '\xF', '\x3', '\xF', '\x3', '\xF', 
		'\x3', '\xF', '\x3', '\xF', '\x3', '\xF', '\x5', '\xF', 'J', '\n', '\xF', 
		'\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', 
		'\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', 
		'\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x3', '\x10', 
		'\x3', '\x10', '\x3', '\x10', '\x3', '\x10', '\x5', '\x10', '^', '\n', 
		'\x10', '\x3', '\x11', '\x3', '\x11', '\a', '\x11', '\x62', '\n', '\x11', 
		'\f', '\x11', '\xE', '\x11', '\x65', '\v', '\x11', '\x3', '\x12', '\x3', 
		'\x12', '\a', '\x12', 'i', '\n', '\x12', '\f', '\x12', '\xE', '\x12', 
		'l', '\v', '\x12', '\x3', '\x12', '\x5', '\x12', 'o', '\n', '\x12', '\x3', 
		'\x12', '\x3', '\x12', '\x6', '\x12', 's', '\n', '\x12', '\r', '\x12', 
		'\xE', '\x12', 't', '\x3', '\x13', '\x6', '\x13', 'x', '\n', '\x13', '\r', 
		'\x13', '\xE', '\x13', 'y', '\x3', '\x13', '\x3', '\x13', '\x2', '\x2', 
		'\x14', '\x3', '\x3', '\x5', '\x4', '\a', '\x5', '\t', '\x6', '\v', '\a', 
		'\r', '\b', '\xF', '\t', '\x11', '\n', '\x13', '\v', '\x15', '\f', '\x17', 
		'\r', '\x19', '\xE', '\x1B', '\xF', '\x1D', '\x10', '\x1F', '\x11', '!', 
		'\x12', '#', '\x13', '%', '\x14', '\x3', '\x2', '\b', '\x4', '\x2', '*', 
		'*', '\xFF0A', '\xFF0A', '\x4', '\x2', '+', '+', '\xFF0B', '\xFF0B', '\x4', 
		'\x2', '.', '.', '\xFF0E', '\xFF0E', '\x3', '\x2', '\x33', ';', '\x3', 
		'\x2', '\x32', ';', '\x5', '\x2', '\v', '\f', '\xF', '\xF', '\"', '\"', 
		'\x2', '\x87', '\x2', '\x3', '\x3', '\x2', '\x2', '\x2', '\x2', '\x5', 
		'\x3', '\x2', '\x2', '\x2', '\x2', '\a', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\t', '\x3', '\x2', '\x2', '\x2', '\x2', '\v', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '\r', '\x3', '\x2', '\x2', '\x2', '\x2', '\xF', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x11', '\x3', '\x2', '\x2', '\x2', '\x2', '\x13', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x15', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'\x17', '\x3', '\x2', '\x2', '\x2', '\x2', '\x19', '\x3', '\x2', '\x2', 
		'\x2', '\x2', '\x1B', '\x3', '\x2', '\x2', '\x2', '\x2', '\x1D', '\x3', 
		'\x2', '\x2', '\x2', '\x2', '\x1F', '\x3', '\x2', '\x2', '\x2', '\x2', 
		'!', '\x3', '\x2', '\x2', '\x2', '\x2', '#', '\x3', '\x2', '\x2', '\x2', 
		'\x2', '%', '\x3', '\x2', '\x2', '\x2', '\x3', '\'', '\x3', '\x2', '\x2', 
		'\x2', '\x5', '*', '\x3', '\x2', '\x2', '\x2', '\a', '-', '\x3', '\x2', 
		'\x2', '\x2', '\t', '/', '\x3', '\x2', '\x2', '\x2', '\v', '\x31', '\x3', 
		'\x2', '\x2', '\x2', '\r', '\x33', '\x3', '\x2', '\x2', '\x2', '\xF', 
		'\x35', '\x3', '\x2', '\x2', '\x2', '\x11', '\x37', '\x3', '\x2', '\x2', 
		'\x2', '\x13', '\x39', '\x3', '\x2', '\x2', '\x2', '\x15', ';', '\x3', 
		'\x2', '\x2', '\x2', '\x17', '=', '\x3', '\x2', '\x2', '\x2', '\x19', 
		'?', '\x3', '\x2', '\x2', '\x2', '\x1B', '\x41', '\x3', '\x2', '\x2', 
		'\x2', '\x1D', 'I', '\x3', '\x2', '\x2', '\x2', '\x1F', ']', '\x3', '\x2', 
		'\x2', '\x2', '!', '_', '\x3', '\x2', '\x2', '\x2', '#', 'n', '\x3', '\x2', 
		'\x2', '\x2', '%', 'w', '\x3', '\x2', '\x2', '\x2', '\'', '(', '\a', 'R', 
		'\x2', '\x2', '(', ')', '\a', 'K', '\x2', '\x2', ')', '\x4', '\x3', '\x2', 
		'\x2', '\x2', '*', '+', '\a', 'r', '\x2', '\x2', '+', ',', '\a', 'k', 
		'\x2', '\x2', ',', '\x6', '\x3', '\x2', '\x2', '\x2', '-', '.', '\a', 
		'\x3C2', '\x2', '\x2', '.', '\b', '\x3', '\x2', '\x2', '\x2', '/', '\x30', 
		'\a', 'G', '\x2', '\x2', '\x30', '\n', '\x3', '\x2', '\x2', '\x2', '\x31', 
		'\x32', '\a', 'g', '\x2', '\x2', '\x32', '\f', '\x3', '\x2', '\x2', '\x2', 
		'\x33', '\x34', '\a', '-', '\x2', '\x2', '\x34', '\xE', '\x3', '\x2', 
		'\x2', '\x2', '\x35', '\x36', '\a', '/', '\x2', '\x2', '\x36', '\x10', 
		'\x3', '\x2', '\x2', '\x2', '\x37', '\x38', '\a', ',', '\x2', '\x2', '\x38', 
		'\x12', '\x3', '\x2', '\x2', '\x2', '\x39', ':', '\a', '\x31', '\x2', 
		'\x2', ':', '\x14', '\x3', '\x2', '\x2', '\x2', ';', '<', '\a', '`', '\x2', 
		'\x2', '<', '\x16', '\x3', '\x2', '\x2', '\x2', '=', '>', '\t', '\x2', 
		'\x2', '\x2', '>', '\x18', '\x3', '\x2', '\x2', '\x2', '?', '@', '\t', 
		'\x3', '\x2', '\x2', '@', '\x1A', '\x3', '\x2', '\x2', '\x2', '\x41', 
		'\x42', '\t', '\x4', '\x2', '\x2', '\x42', '\x1C', '\x3', '\x2', '\x2', 
		'\x2', '\x43', '\x44', '\a', 'n', '\x2', '\x2', '\x44', '\x45', '\a', 
		'q', '\x2', '\x2', '\x45', 'J', '\a', 'i', '\x2', '\x2', '\x46', 'G', 
		'\a', 'N', '\x2', '\x2', 'G', 'H', '\a', 'q', '\x2', '\x2', 'H', 'J', 
		'\a', 'i', '\x2', '\x2', 'I', '\x43', '\x3', '\x2', '\x2', '\x2', 'I', 
		'\x46', '\x3', '\x2', '\x2', '\x2', 'J', '\x1E', '\x3', '\x2', '\x2', 
		'\x2', 'K', 'L', '\a', 'u', '\x2', '\x2', 'L', 'M', '\a', 'k', '\x2', 
		'\x2', 'M', '^', '\a', 'p', '\x2', '\x2', 'N', 'O', '\a', 'U', '\x2', 
		'\x2', 'O', 'P', '\a', 'k', '\x2', '\x2', 'P', '^', '\a', 'p', '\x2', 
		'\x2', 'Q', 'R', '\a', '\x65', '\x2', '\x2', 'R', 'S', '\a', 'q', '\x2', 
		'\x2', 'S', '^', '\a', 'u', '\x2', '\x2', 'T', 'U', '\a', '\x45', '\x2', 
		'\x2', 'U', 'V', '\a', 'q', '\x2', '\x2', 'V', '^', '\a', 'u', '\x2', 
		'\x2', 'W', 'X', '\a', 'v', '\x2', '\x2', 'X', 'Y', '\a', '\x63', '\x2', 
		'\x2', 'Y', '^', '\a', 'p', '\x2', '\x2', 'Z', '[', '\a', 'V', '\x2', 
		'\x2', '[', '\\', '\a', '\x63', '\x2', '\x2', '\\', '^', '\a', 'p', '\x2', 
		'\x2', ']', 'K', '\x3', '\x2', '\x2', '\x2', ']', 'N', '\x3', '\x2', '\x2', 
		'\x2', ']', 'Q', '\x3', '\x2', '\x2', '\x2', ']', 'T', '\x3', '\x2', '\x2', 
		'\x2', ']', 'W', '\x3', '\x2', '\x2', '\x2', ']', 'Z', '\x3', '\x2', '\x2', 
		'\x2', '^', ' ', '\x3', '\x2', '\x2', '\x2', '_', '\x63', '\t', '\x5', 
		'\x2', '\x2', '`', '\x62', '\t', '\x6', '\x2', '\x2', '\x61', '`', '\x3', 
		'\x2', '\x2', '\x2', '\x62', '\x65', '\x3', '\x2', '\x2', '\x2', '\x63', 
		'\x61', '\x3', '\x2', '\x2', '\x2', '\x63', '\x64', '\x3', '\x2', '\x2', 
		'\x2', '\x64', '\"', '\x3', '\x2', '\x2', '\x2', '\x65', '\x63', '\x3', 
		'\x2', '\x2', '\x2', '\x66', 'j', '\t', '\x5', '\x2', '\x2', 'g', 'i', 
		'\t', '\x6', '\x2', '\x2', 'h', 'g', '\x3', '\x2', '\x2', '\x2', 'i', 
		'l', '\x3', '\x2', '\x2', '\x2', 'j', 'h', '\x3', '\x2', '\x2', '\x2', 
		'j', 'k', '\x3', '\x2', '\x2', '\x2', 'k', 'o', '\x3', '\x2', '\x2', '\x2', 
		'l', 'j', '\x3', '\x2', '\x2', '\x2', 'm', 'o', '\t', '\x6', '\x2', '\x2', 
		'n', '\x66', '\x3', '\x2', '\x2', '\x2', 'n', 'm', '\x3', '\x2', '\x2', 
		'\x2', 'o', 'p', '\x3', '\x2', '\x2', '\x2', 'p', 'r', '\a', '\x30', '\x2', 
		'\x2', 'q', 's', '\t', '\x6', '\x2', '\x2', 'r', 'q', '\x3', '\x2', '\x2', 
		'\x2', 's', 't', '\x3', '\x2', '\x2', '\x2', 't', 'r', '\x3', '\x2', '\x2', 
		'\x2', 't', 'u', '\x3', '\x2', '\x2', '\x2', 'u', '$', '\x3', '\x2', '\x2', 
		'\x2', 'v', 'x', '\t', '\a', '\x2', '\x2', 'w', 'v', '\x3', '\x2', '\x2', 
		'\x2', 'x', 'y', '\x3', '\x2', '\x2', '\x2', 'y', 'w', '\x3', '\x2', '\x2', 
		'\x2', 'y', 'z', '\x3', '\x2', '\x2', '\x2', 'z', '{', '\x3', '\x2', '\x2', 
		'\x2', '{', '|', '\b', '\x13', '\x2', '\x2', '|', '&', '\x3', '\x2', '\x2', 
		'\x2', '\n', '\x2', 'I', ']', '\x63', 'j', 'n', 't', 'y', '\x3', '\b', 
		'\x2', '\x2',
	};

	public static readonly ATN _ATN =
		new ATNDeserializer().Deserialize(_serializedATN);


}
