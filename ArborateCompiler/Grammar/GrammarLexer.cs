/*
 * WARNING: this file has been generated by
 * Hime Parser Generator 3.4.0.0
 */
using System.Collections.Generic;
using System.IO;
using Hime.Redist;
using Hime.Redist.Lexer;

namespace Arborate
{
	/// <summary>
	/// Represents a lexer
	/// </summary>
	internal class GrammarLexer : ContextFreeLexer
	{
		/// <summary>
		/// The automaton for this lexer
		/// </summary>
		private static readonly Automaton commonAutomaton = Automaton.Find(typeof(GrammarLexer), "GrammarLexer.bin");
		/// <summary>
		/// Contains the constant IDs for the terminals for this lexer
		/// </summary>
		public class ID
		{
			/// <summary>
			/// The unique identifier for terminal WHITE_SPACE
			/// </summary>
			public const int TerminalWhiteSpace = 0x0003;
			/// <summary>
			/// The unique identifier for terminal SEPARATOR
			/// </summary>
			public const int TerminalSeparator = 0x0004;
			/// <summary>
			/// The unique identifier for terminal LCURLY
			/// </summary>
			public const int TerminalLcurly = 0x0005;
			/// <summary>
			/// The unique identifier for terminal RCURLY
			/// </summary>
			public const int TerminalRcurly = 0x0006;
			/// <summary>
			/// The unique identifier for terminal KW_FUNC
			/// </summary>
			public const int TerminalKwFunc = 0x0007;
			/// <summary>
			/// The unique identifier for terminal KW_ENDFUNC
			/// </summary>
			public const int TerminalKwEndfunc = 0x0008;
		}
		/// <summary>
		/// Contains the constant IDs for the contexts for this lexer
		/// </summary>
		public class Context
		{
			/// <summary>
			/// The unique identifier for the default context
			/// </summary>
			public const int Default = 0;
		}
		/// <summary>
		/// The collection of terminals matched by this lexer
		/// </summary>
		/// <remarks>
		/// The terminals are in an order consistent with the automaton,
		/// so that terminal indices in the automaton can be used to retrieve the terminals in this table
		/// </remarks>
		private static readonly Symbol[] terminals = {
			new Symbol(0x0001, "ε"),
			new Symbol(0x0002, "$"),
			new Symbol(0x0003, "WHITE_SPACE"),
			new Symbol(0x0004, "SEPARATOR"),
			new Symbol(0x0005, "LCURLY"),
			new Symbol(0x0006, "RCURLY"),
			new Symbol(0x0007, "KW_FUNC"),
			new Symbol(0x0008, "KW_ENDFUNC") };
		/// <summary>
		/// Initializes a new instance of the lexer
		/// </summary>
		/// <param name="input">The lexer's input</param>
		public GrammarLexer(string input) : base(commonAutomaton, terminals, 0x0004, input) {}
		/// <summary>
		/// Initializes a new instance of the lexer
		/// </summary>
		/// <param name="input">The lexer's input</param>
		public GrammarLexer(TextReader input) : base(commonAutomaton, terminals, 0x0004, input) {}
	}
}
