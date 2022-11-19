using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecocipe.Models
{
    public class Recipe
    {
        private int id;
        private string title;
        private int authorId;
        private string category;
        private string imageUrl;
        private string ingredients;
        private string steps;

        public Recipe(int id, string title, int authorId, string category, string imageUrl, string ingredients, string steps)
        {
            this.id = id;
            Title = title;
            AuthorId = authorId;
            Category = category;
            ImageUrl = imageUrl;
            Ingredients = ingredients;
            Steps = steps;
        }

        public int Id { get => id; }
        public string Title { get => title; set => title = value; }
        public int AuthorId { get => authorId; set => authorId = value; }
        public string Category { get => category; set => category = value; }
        public string ImageUrl { get => imageUrl; set => imageUrl = value; }
        public string Ingredients { get => ingredients; set => ingredients = value; }
        public string Steps { get => steps; set => steps = value; }
    }
}
