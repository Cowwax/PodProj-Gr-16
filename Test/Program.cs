namespace Test
{
    internal static class Program
    {
        // Hej hej hej hej hej
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        /// //hej d�r
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
            Console.WriteLine("Hello");
        }
    }
}