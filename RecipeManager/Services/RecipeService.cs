using DataAccess.Data;
using DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;


namespace RecipeManager.Services
{
    //Implementing the IRecipeService Interface
    public class RecipeService : IRecipeService
    {
        private readonly ApplicationDbContext _db;

        public RecipeService(ApplicationDbContext db)
        {
            _db = db;
        }

        public Recipe Create(Recipe recipe)
        {
            // Define the date
            // Add new recipe
            // Save the recipe
            // Return the entity
            recipe.DateCreated= DateTime.Now; 
            recipe.DateUpdated= DateTime.Now;

            var newRecipe = _db.Recipes.Add(recipe);
            _db.SaveChanges();
            return newRecipe.Entity;
        }

        public void Delete(int id)
        {
             // Find the recipe and store it in var.
            var recipeToDelete = _db.Recipes.Find(id);

            //If the recipe is not null, remove it and save changes. 
            if(recipeToDelete != null)
            {
                _db.Remove(recipeToDelete);
                _db.SaveChanges(); 
            }

             }

        public Recipe Get(int id)
        {
            //Finds the element by its primary key 
            return _db.Recipes.Find(id);
        }

        public List<Recipe> List()
        {
            
            return _db.Recipes.OrderByDescending(recipe => recipe.DateUpdated).ToList();
        }

        public Recipe Update(Recipe recipe)
        {
            // Find the recipe and store it in var
            var dbRecipeUpdate = _db.Recipes.Find(recipe.Id);
            
            // If recipe is not null (it exists)
            if(dbRecipeUpdate != null)
            {
                // grab that recipe, and update it, and save changes in db
                dbRecipeUpdate = recipe;
                dbRecipeUpdate.DateUpdated = DateTime.Now;
                _db.SaveChanges();
            }
            return dbRecipeUpdate;
        }
    }
}
