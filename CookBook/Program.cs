using CookBook.UI;
using DataAccessLayer.Contracts;
using DataAccessLayer.Repositories;

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

            IIngredientsRepository ingredientsRepository = new IngredientsRepository();
            Application.Run(new IngredientsForm(ingredientsRepository));
        }
    }
}