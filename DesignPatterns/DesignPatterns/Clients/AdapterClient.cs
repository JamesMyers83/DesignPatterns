using System;

namespace DesignPatterns.Clients
{
    public class AdapterClient
    {
        public void PrintAdapter()
        {
            Console.WriteLine("Adapter Example.");

            Console.WriteLine();
            Console.WriteLine("Using object adapter");

            Structural.Adapter.AmericanBreadRecipe recipe = new Structural.Adapter.AmericanBreadRecipe();
            Structural.Adapter.IRecipeTarget target = new Structural.Adapter.RecipeObjectAdapter();
            Structural.Adapter.Bread bread = target.BakeBread(recipe);
            Console.WriteLine($"American Bread Recipe: {recipe}");
            Console.WriteLine($"French bread made: {bread.BreadDescription()}");

            Console.WriteLine();
            Console.WriteLine("Using class adapter");

            target = new Structural.Adapter.RecipeClassAdapter();
            bread = target.BakeBread(recipe);
            Console.WriteLine($"American Bread Recipe: {recipe}");
            Console.WriteLine($"French bread made: {bread.BreadDescription()}");

            Console.WriteLine();
            Console.WriteLine("End Adapter Example");
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
