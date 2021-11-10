using System;

namespace ScrapInterpreter
{
    class MainClass
    {
        public static void Main()
        {
            // Load script as text
            string script = "";

            // Create interpreter
            Interpreter interpreter = new Interpreter();

            interpreter.AddGlobalFunction("print", new MemoryFunction(args =>
            {
                Console.Write(args[0]);
                return null;
            }));

            interpreter.AddGlobalFunction("println", new MemoryFunction(args =>
            {
                Console.WriteLine(args[0]);
                return null;
            }));

            interpreter.CallGlobalFunction("println", "Hello World");
            interpreter.CallGlobalFunction("print", "This");
            interpreter.CallGlobalFunction("println", " is a test execution");

            // Load script
            interpreter.LoadScript(script);

            // TODO Debug script

            //Execute script
            interpreter.ExecuteScript();
        }
    }
}
