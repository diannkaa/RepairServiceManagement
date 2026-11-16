using Lab02.Data;
using Microsoft.EntityFrameworkCore;

namespace Lab02.App
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var factory = new AppDbContextFactory();

            using (var context = factory.CreateDbContext(Array.Empty<string>()))
            {
                DbInitializer.SeedData(context);
            }

            Application.Run(new Form1());
        }
    }
}