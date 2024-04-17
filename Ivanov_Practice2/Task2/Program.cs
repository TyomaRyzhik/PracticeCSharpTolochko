using System;

class Program
{
    static void Main(string[] args)
    {
        Engine engine = new Engine();
        engine.Work();

        InternalCombustionEngine internalCombustionEngine = new InternalCombustionEngine();
        internalCombustionEngine.Work();

        Diesel diesel = new Diesel();
        diesel.Work();

        JetEngine jetEngine = new JetEngine();
        jetEngine.Work();
    }
}
