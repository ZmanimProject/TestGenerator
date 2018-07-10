using System;
using System.Collections.Generic;
using TestGenerator.Formatters;

namespace TestGenerator.MethodGenerators
{
    public interface ITestMethodGenerator
    {
        void Generate(Type type, Func<object> typeObject, IEnumerable<ITestFormatter> testFormatters);
    }
}