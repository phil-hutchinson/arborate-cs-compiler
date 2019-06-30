using System;

namespace ArborateCompiler
{
    public class Compiler
    {
        public Hime.Redist.ParseResult Compile(string program)
        {
            var parser = new Arborate.GrammarParser(new Arborate.GrammarLexer(program));
            return parser.Parse();
        }
    }
}
