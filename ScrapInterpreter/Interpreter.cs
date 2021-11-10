using System;
using System.Collections.Generic;

namespace ScrapInterpreter
{
    public class Interpreter
    {
        private Dictionary<string, MemoryFunction> globalFunctionMemory;

        public Interpreter()
        {
            globalFunctionMemory = new Dictionary<string, MemoryFunction>();
        }


        // List of instructions

        public void LoadScript(string script)
        {
            // Load and tokenise
        }

        public void ExecuteScript()
        {

        }

        public void AddGlobalFunction(string name, MemoryFunction function)
        {
            globalFunctionMemory.Add(name, function);
        }

        public object CallGlobalFunction(string name, params object[] args)
        {
            globalFunctionMemory.TryGetValue(name, out MemoryFunction func);

            if(func == null)
            {
                return null;
            }

            return func.Call(args);
        }
    }
}
