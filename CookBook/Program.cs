using System.Configuration;
using CookBook.UI;
using DataAccessLayer.Contracts;
using DataAccessLayer.Repositories;
using Microsoft.Extensions.DependencyInjection;

namespace CookBook
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Logger.Initialize(); // Initialize the logger

            ServiceCollection services = ConfigureServices();
            ServiceProvider serviceProvider = services.BuildServiceProvider();

            var startForm = serviceProvider.GetRequiredService<IngredientsForm>();
            Application.Run(startForm);
        }

        private static ServiceCollection ConfigureServices()
        {
            ServiceCollection services = new ServiceCollection();

            services.AddTransient<IIngredientsRepository>(_ => new IngredientsRepository());

            services.AddTransient<IngredientsForm>();

            return services;
        }
    }
}