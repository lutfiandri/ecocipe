using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecocipe.Models
{
    abstract class User
    {
        public Recipe[] GetAllRecipe()
        {
            // TODO: Implement get recipes
            Recipe[] recipes = { };
            return recipes;
        }

        public Recipe GetOneRecipe()
        {
            // TODO: Implement get one recipe
            Recipe recipe = new Recipe();
            return recipe;
        }

    }
}
