using System;
namespace ScrapInterpreter
{
    public class MemoryFunction
    {
        private Func<object[], object> func;
        public MemoryFunction(Func<object[], object> f)
        {
            func = f;
        }

        public object Call(object[] args)
        {
            return func(args);
        }
    }
}
