using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecocipe.Models
{
    class Recipe
    {
        private int id;
        private string title;
        private float rating;
        private int ratingCount;
        private User author;
        private string[] ingredients;
        private string[] steps;
        private bool isDuplicate;
        private Recipe duplicateFrom;

        public int Id { get => id; }
        public string Title { get => title; set => title = value; }
        public float Rating { get => rating; set => rating = value; }
        public int RatingCount { get => ratingCount; set => ratingCount = value; }
        public string[] Ingredients { get => ingredients; set => ingredients = value; }
        public string[] Steps { get => steps; set => steps = value; }
        public bool IsDuplicate { get => isDuplicate; set => isDuplicate = value; }
        internal User Author { get => author; set => author = value; }
        internal Recipe DuplicateFrom { get => duplicateFrom; set => duplicateFrom = value; }
    }
}
