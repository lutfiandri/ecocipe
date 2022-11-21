using Ecocipe.Forms;
using Ecocipe.Utils;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecocipe.Models
{
    public class Recipe
    {
        private int id;
        private string title;
        private User author;
        private string category;
        private string imageUrl;
        private string ingredients;
        private string steps;

        public Recipe(int id, string title, User author, string category, string imageUrl, string ingredients, string steps)
        {
            this.id = id;
            Title = title;
            Author = author;
            Category = category;
            ImageUrl = imageUrl;
            Ingredients = ingredients;
            Steps = steps;
        }

        public int Id { get => id; }
        public string Title { get => title; set => title = value; }
        public User Author { get => author; set => author = value; }
        public string Category { get => category; set => category = value; }
        public string ImageUrl { get => imageUrl; set => imageUrl = value; }
        public string Ingredients { get => ingredients; set => ingredients = value; }
        public string Steps { get => steps; set => steps = value; }

        public static List<Recipe> FindAll()
        {
            var recipes = new List<Recipe>();

            try
            {
                var sql = "select * from select_all_recipes()";

                var cmd = new NpgsqlCommand(sql, Database.Connection);
                var data = cmd.ExecuteReader();

                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        var author = new User(data.GetInt32(2), data.GetString(7));
                        recipes.Add(new Recipe(
                            data.GetInt32(0),
                            data.GetString(1),
                            author,
                            data.GetString(3),
                            data.GetString(4),
                            data.GetString(5),
                            data.GetString(6)
                        ));
                    }
                }

                data.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return recipes;
        }

        public static List<Recipe> FindAll(int authorId)
        {
            var recipes = new List<Recipe>();

            try
            {
                var sql = "select * from select_all_recipes(:author_id)";
                var cmd = new NpgsqlCommand(sql, Database.Connection);
                cmd.Parameters.AddWithValue("author_id", authorId);
                var data = cmd.ExecuteReader();

                if (data.HasRows)
                {
                    while (data.Read())
                    {
                        var author = new User(data.GetInt32(2), data.GetString(7));
                        recipes.Add(new Recipe(
                            data.GetInt32(0),
                            data.GetString(1),
                            author,
                            data.GetString(3),
                            data.GetString(4),
                            data.GetString(5),
                            data.GetString(6)
                        ));
                    }
                }

                data.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            return recipes;
        }

        public static bool Delete(int id)
        {
            try
            {
                var sql = @"select * from delete_recipe(:_id)";
                var cmd = new NpgsqlCommand(sql, Database.Connection);
                cmd.Parameters.AddWithValue("_id", id);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public static bool Update(Recipe recipe)
        {
            try
            {
                var sql = @"select * from update_recipe(:_id, :_title, :_category, :_imageurl, :_ingredients, :_steps)";
                var cmd = new NpgsqlCommand(sql, Database.Connection);
                cmd.Parameters.AddWithValue("_id", recipe.Id);
                cmd.Parameters.AddWithValue("_title", recipe.Title);
                cmd.Parameters.AddWithValue("_category", recipe.Category);
                cmd.Parameters.AddWithValue("_imageurl", recipe.imageUrl);
                cmd.Parameters.AddWithValue("_ingredients", recipe.Ingredients);
                cmd.Parameters.AddWithValue("_steps", recipe.Steps);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public static bool Create(Recipe recipe)
        {
            try
            {
                var sql = @"select * from insert_recipe(:_title, :_author_id, :_category, :_imageurl, :_ingredients, :_steps)";
                var cmd = new NpgsqlCommand(sql, Database.Connection);
                cmd.Parameters.AddWithValue("_title", recipe.Title);
                cmd.Parameters.AddWithValue("_author_id", recipe.Author.Id);
                cmd.Parameters.AddWithValue("_category", recipe.Category);
                cmd.Parameters.AddWithValue("_imageurl", recipe.imageUrl);
                cmd.Parameters.AddWithValue("_ingredients", recipe.Ingredients);
                cmd.Parameters.AddWithValue("_steps", recipe.Steps);

                if ((int)cmd.ExecuteScalar() == 1)
                {
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
