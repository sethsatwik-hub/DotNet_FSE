namespace SingletonPatternExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Logger logger1 = Logger.GetInstance();
            Logger logger2 = Logger.GetInstance();

            logger1.Log("Application Started");
            logger2.Log("Logging another message");

            if (logger1 == logger2)
            {
                Console.WriteLine("Only one Logger instance exists.");
            }
            else
            {
                Console.WriteLine("Multiple Logger instances created.");
            }
        }
    }
}