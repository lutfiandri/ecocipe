using Ecocipe.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecocipe.Models
{
    sealed class AuthenticatedUser : User
    {
        private string username;

        public AuthenticatedUser(string username)
        {
            this.username = username;
        }

        public string Username { get => username; }

        public bool Logout()
        {
            return true;
        }

        public Recipe CreateRecipe()
        {
            var recipe = new Recipe();
            return recipe;
        }

        public Recipe DuplicateRecipe()
        {
            var recipe = new Recipe();
            return recipe;
        }

        public Recipe[] GetAllMyRecipes()
        {
            Recipe[] recipes = { };
            return recipes;
        }

        public bool EditRecipe(Recipe recipe)
        {
            return true;
        }

        public bool DeleteRecipe(int recipeId)
        {
            return true;
        }

        public Recipe[] SearchRecipes(Recipe[] recipes, string keyword)
        {
            Recipe[] filteredRecipes = { };
            return filteredRecipes;
        }

        public bool RateRecipe(Recipe recipe, byte points)
        {
            return true;
        }
    }
}
