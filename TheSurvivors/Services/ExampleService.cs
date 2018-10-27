using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheSurvivors.Services
{
    public class ExampleService
    {/*
        using AutoMapper;
using RecipesBox.Domain.Models;
using RecipesBox.Domain.Repositories;
using RecipesBox.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;

namespace RecipesBox.Services
{
    public class RecipesService : IRecipesService
    {
        private readonly IRecipesRepository _recipesRepository;
        private readonly IMapper _mapper;

        public RecipesService(IRecipesRepository recipesRepository, IMapper mapper)
        {
            _recipesRepository = recipesRepository;
            _mapper = mapper;
        }

        public List<RecipeQueryViewModel> GetAll()
        {
            return _mapper.Map<List<RecipeQueryViewModel>>(_recipesRepository.GetAll());
        }
        
           

        public RecipeQueryViewModel GetRecipeById(int id)
        {
            return _mapper.Map<RecipeQueryViewModel>(_recipesRepository.GetRecipeById(id));
        }

        private List<string> HandleFileUploads(RecipeCommandViewModel recipe)
        {
            var filenames = new List<string>();
            if (recipe.RecipesMedia == null || recipe.RecipesMedia.Count == 0)
            {
                return new List<string>();
            }

            foreach (var recipeMedia in recipe.RecipesMedia)
            {
                string guid = Guid.NewGuid().ToString();
                var filename = guid + "." + Path.GetExtension(recipeMedia.FileName).Substring(1);
                var directory = Directory.GetCurrentDirectory() + "\\ClientApp\\public\\Images";
                var path = Path.Combine(directory, filename);
                if (!Directory.Exists(directory))
                {
                    Directory.CreateDirectory(directory);
                }
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    recipeMedia.CopyTo(stream);
                    filenames.Add(filename);
                }
            }

            return filenames;
        }

        public RecipeModel AddUploadedFiles(RecipeModel recipe, List<string> recipesMedia)
        {
            recipe.RecipesMedia = new List<RecipeMediaModel>();
            foreach (var filename in recipesMedia)
            {
                recipe.RecipesMedia.Add(new RecipeMediaModel { ImageName = filename });
            }
            return recipe;
        }

        public void AddOrUpdateRecipe(RecipeCommandViewModel recipe)
        {
            var filenames = HandleFileUploads(recipe);
            if (recipe.RecipesMediaFiles != null)
            {
                foreach (var data in recipe.RecipesMediaFiles)
                {
                    filenames.Add(data.ImageName);
                }
            }
            var recipeModel = _mapper.Map<RecipeModel>(recipe);
            AddUploadedFiles(recipeModel, filenames);

            _recipesRepository.AddOrUpdateRecipe(recipeModel);
        }
        public void DeleteRecipe(int recipeId)
        {
            var recipe = _recipesRepository.GetRecipeById(recipeId);
            foreach(var recipeMedia in recipe.RecipesMedia)
            {
                var filename = recipeMedia.ImageName;
                var directory = Directory.GetCurrentDirectory() + "\\ClientApp\\public\\Images";
                var path = Path.Combine(directory, filename);
                try
                {
                    File.Delete(path);
                }
                catch (IOException)
                {
                    //log exception when logger will be present
                }
            }
            _recipesRepository.Delete(recipe);
        }

    }
}

        */
    }
}
