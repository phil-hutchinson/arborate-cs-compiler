using System;
using Xunit;

namespace ArborateCompiler.Test
{
    public class FunctionTests: ArborateTests
    {
        public override string GetSourceFolder()
        {
            return "FunctionTests";
        }

        [Fact]
        public void EmptyFunctionCompiles()
        {
            string program = GetSourceCodeFromResource("EmptyFunctionCompiles");
            var actual = (new Compiler()).Compile(program);
            Assert.Equal(0, actual.Errors.Count);
        }

        [Fact]
        public void MissingEndfunctionHasCompileErrors()
        {
            string program = GetSourceCodeFromResource("MissingEndfunctionHasCompileErrors");
            var actual = (new Compiler()).Compile(program);
            Assert.NotEqual(0, actual.Errors.Count);
        }
    }
}
