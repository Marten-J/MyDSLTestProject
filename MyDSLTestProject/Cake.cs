using System;
using System.Collections.Generic;
using System.Text;

namespace MyDSLTestProject
{
    /// <summary>
    /// Units for an ingredient
    /// </summary>
    public enum Unit
    {
        Kilograms, Gram, Liter, NumberOfPieces, Tablespoon
    }

    /// <summary>
    /// Model which shows the production of a cake
    /// </summary>
    public class Cake
    {
        /// <summary>
        /// Dictionary of all ingredients for the cake
        /// </summary>
        public Dictionary<string, KeyValuePair<float, Unit>> Ingredients { get; set; }
        /// <summary>
        /// Steps to bake the cake. The list order defines the back order.
        /// </summary>
        public List<string> CookingSteps { get; set; }
        /// <summary>
        /// Name of the cake
        /// </summary>
        public String Name { get; set; }

        public Cake(string name, Dictionary<string, KeyValuePair<float, Unit>> ingredients, List<string> cookingSteps)
        {
            this.Name = name;
            this.Ingredients = ingredients;
            this.CookingSteps = cookingSteps;
        }

        /// <summary>
        /// Format the recipe
        /// </summary>
        /// <returns>The formated cake recipe</returns>
        public string GetFormatedRecipe()
        {
            string recipe = $"{Name}\n\nZutaten:\n";
            foreach (var ingredient in Ingredients)
            {
                recipe += $"{ingredient.Value.Key} {GetFormatedUnit(ingredient.Value.Value)}\t {ingredient.Key}\n";
            }
            recipe += "\n\n";
            int stepCounter = 1;
            foreach (var step in CookingSteps)
            {
                recipe += $"Schritt {stepCounter}: {step}\n";
                stepCounter += 1;
            }
            return recipe;
        }

        private string GetFormatedUnit(Unit unit)
        {
            switch (unit)
            {
                case Unit.Gram:
                    return "g";
                case Unit.Kilograms:
                    return "Kg";
                case Unit.Liter:
                    return "l";
                case Unit.Tablespoon:
                    return "EL";
                default:
                case Unit.NumberOfPieces:
                    return "g";
            }
        }
    }
}
