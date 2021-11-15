using DataAccess.Model;
using System.Collections.Generic;

namespace RecipeManager.Services
{
    public interface IRecipeService
    {
        //Methods

        //Create

        //Returns a recipe. Create method, passing the Recipe model of type recipe in.
        Recipe Create(Recipe recipe);   

        //Get
        //Grabbed from details page when you pass an ID to the method. /recipes/id
        Recipe Get(int id);
        //List
        List<Recipe> List();

        //Update
        Recipe Update(Recipe recipe);

        //Delete
        void Delete(int id);
    }
}
