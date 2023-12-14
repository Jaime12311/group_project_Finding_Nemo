using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeWPF.Models
{
    public class RecipeService
    {
        private static List<Recipe> recipesList;

        public RecipeService()
        {
            recipesList = new List<Recipe>
            {
                new Recipe { Name = "Vanilla Cake", Ingredients = "flour, baking powder, salt, vanilla extract, Egg", Instructions = "Bake at  350°F (180°C)" }
            };
        }

        public List<Recipe> GetAll()
        {
            return recipesList;
        }

        public bool Add(Recipe newRecipe)
        {
            if (recipesList.Any(r => r.Name.Equals(newRecipe.Name, StringComparison.OrdinalIgnoreCase)))
            {
                throw new ArgumentException("Recipe with the same name already exists.");
            }

            recipesList.Add(newRecipe);
            return true;
        }

        public bool Update(Recipe updateRecipe)
        {
            var existingRecipe = recipesList.FirstOrDefault(r => r.Name.Equals(updateRecipe.Name, StringComparison.OrdinalIgnoreCase));

            if (existingRecipe != null)
            {
                existingRecipe.Instructions = updateRecipe.Instructions;
                existingRecipe.Ingredients = updateRecipe.Ingredients;
                return true;
            }

            return false;
        }

        public bool Delete(string recipeName)
        {
            var recipeToDelete = recipesList.FirstOrDefault(r => r.Name.Equals(recipeName, StringComparison.OrdinalIgnoreCase));

            if (recipeToDelete != null)
            {
                recipesList.Remove(recipeToDelete);
                return true;
            }

            return false;
        }

        public Recipe Search(string recipeName)
        {
            return recipesList.FirstOrDefault(r => r.Name.Equals(recipeName, StringComparison.OrdinalIgnoreCase));
        }
        public Recipe GetRecipe(string recipeName)
        {
            return recipesList.FirstOrDefault(r => r.Name.Equals(recipeName, StringComparison.OrdinalIgnoreCase));
        }
    }
}