using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;
using System.Text;

namespace ArborateCompiler.Test
{
    public abstract class ArborateTests
    {
        public abstract string GetSourceFolder();

        protected string GetSourceCodeFromResource(string sourceFileName)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var resourceName = $"ArborateCompiler.Test.{GetSourceFolder()}.{sourceFileName}.rb8";

            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            using (StreamReader reader = new StreamReader(stream))
            {
                string result = reader.ReadToEnd();
                return result;
            }
        }

    }
}
