using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace TheSurvivors.Controllers
{
    public class ExampleController : Controller
    {
        //    using Microsoft.AspNetCore.Mvc;
        //using RecipesBox.Services;
        //using RecipesBox.ViewModels;
        //using System.Collections.Generic;
        //using Newtonsoft.Json;
        //using System;

        //namespace RecipesBox.Controllers
        //{
        //    [Route("api/[controller]")]
        //    public class RecipesController : Controller
        //    {
        //        private readonly IRecipesService _recipesService;

        //        public RecipesController(IRecipesService recipesService)
        //        {
        //            _recipesService = recipesService;
        //        }

        //        [HttpGet("[action]")]
        //        public IEnumerable<RecipeQueryViewModel> All()
        //        {
        //            return _recipesService.GetAll();
        //        }

        //        [Route("GetRecipeById/{id}")]
        //        public RecipeQueryViewModel GetRecipeById(int id)
        //        {
        //            return _recipesService.GetRecipeById(id);
        //        }

        //        [Route("AddOrUpdateRecipe")]
        //        public ActionResult AddOrUpdateRecipe(RecipeCommandViewModel recipe)
        //        {
        //            var recipeInputData = JsonConvert.DeserializeObject<RecipeCommandViewModel>(recipe.InputData);
        //            recipeInputData.RecipesMedia = recipe.RecipesMedia;
        //            _recipesService.AddOrUpdateRecipe(recipeInputData);
        //            return Ok(new { status = "Ok" });

        //        }

        //        [HttpDelete("[action]")]
        //        public ActionResult Delete([FromBody] int recipeId)
        //        {
        //            try
        //            {
        //                _recipesService.DeleteRecipe(recipeId);
        //                return StatusCode(200);
        //            }
        //            catch (Exception)
        //            {
        //                return StatusCode(500);
        //            }
        //        }
        //    }
        //}
    }
}