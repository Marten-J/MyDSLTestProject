using System;
using System.Collections.Generic;
using System.Text;

namespace MyDSLTestProject
{
    /// <summary>
    /// Builder pattern to build a delicious cake 
    /// </summary>
    public class CakeBuilder
    {
        private Dictionary<string, KeyValuePair<float, Unit>> ingredients;
        private List<string> cookingSteps;
        private String name;

        public CakeBuilder Name(String name)
        {
            this.name = name;
            return this;
        }

        public CakeBuilder AddIngredient(string name, float quantity, Unit unit)
        {
            if (ingredients == null)
            {
                ingredients = new Dictionary<string, KeyValuePair<float, Unit>>();
            }
            ingredients.Add(name, new KeyValuePair<float, Unit>(quantity, unit));
            return this;
        }

        public CakeBuilder AddCookingStep(string text)
        {
            if (cookingSteps == null)
            {
                cookingSteps = new List<string>();
            }
            cookingSteps.Add(text);
            return this;
        }


        public Cake Build()
        {
            if (String.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("No name for the cake is set");
            }

            if (cookingSteps == null || cookingSteps.Count == 0)
            {
                throw new ArgumentException("There are no cooking steps for the cake");
            }

            if (ingredients == null || ingredients.Count == 0)
            {
                throw new ArgumentException("There are no ingredients for the cake");
            }

            return new Cake(name, ingredients, cookingSteps);
        }
    }
}
