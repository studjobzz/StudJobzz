//using AutoMapper;
//using FluentAssert;
//using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Moq;
//using RecipesBox.Domain.Models;
//using RecipesBox.Domain.Repositories;
//using RecipesBox.Services;
//using System.Collections.Generic;
//using NutrientTypesModel = RecipesBox.Domain.Models.NutrientTypes;
//using NutrientTypesViewModel = RecipesBox.ViewModels.NutrientTypes;
//using QuantityTypesModel = RecipesBox.Domain.Models.QuantityTypes;

//namespace RecipesBox.Tests.Services
//{
//    [TestClass]
//    public class RecipesServiceTests : BaseTests
//    {
//        private IRecipesService _sut; // sut = system under test
//        private Mock<IRecipesRepository> _recipesRepositoryMock;

//        [TestInitialize]
//        public new void Setup()
//        {
//            base.Setup();
//            _recipesRepositoryMock = new Mock<IRecipesRepository>();
//            _sut = new RecipesService(_recipesRepositoryMock.Object, Mapper.Instance);
//        }

//        [TestMethod]
//        public void GetAll_ReturnsAllRecipes_WhenTableContainsRecords()
//        {
//            //arrange
//            _recipesRepositoryMock.Setup(x => x.GetAll()).Returns(new List<RecipeModel>
//            {
//                new RecipeModel(),
//                new RecipeModel()
//            });

//            //act
//            var result = _sut.GetAll();

//            //assert
//            result.Count.ShouldBeEqualTo(2);
//        }

//        [TestMethod]
//        public void GetAll_TitleFieldIsMapped_ForExistingRecord()
//        {
//            //arrange
//            var existingRecipe = new RecipeModel { Name = "sample text" };
//            _recipesRepositoryMock.Setup(x => x.GetAll()).Returns(new List<RecipeModel> { existingRecipe });

//            //act
//            var result = _sut.GetAll()[0];

//            //assert
//            result.Name.ShouldBeEqualTo(existingRecipe.Name);
//        }

//        [TestMethod]
//        public void GetAll_TitleAndNutritionInfosIsMapped_ForExistingRecord()
//        {
//            //arrange
//            List<NutritionInfoModel> nutritionInfoModels = new List<NutritionInfoModel>
//            {
//                new NutritionInfoModel()
//                {
//                    NutrientType = NutrientTypesModel.Calories,
//                    Quantity = 300,
//                    QuantityType = QuantityTypesModel.Kcal
//                },
//                new NutritionInfoModel()
//                {
//                    NutrientType = NutrientTypesModel.Fats,
//                    Quantity = 300,
//                    QuantityType = QuantityTypesModel.Mg
//                }

//            };
//            var existingRecipe = new RecipeModel { Name = "sample text", NutritionInfos = nutritionInfoModels };
//            _recipesRepositoryMock.Setup(x => x.GetAll()).Returns(new List<RecipeModel> { existingRecipe });

//            //act
//            var result = _sut.GetAll()[0];

//            //assert
//            result.NutritionInfos.Count.ShouldBeEqualTo(2);
//        }

//        [TestMethod]
//        public void GetNutrientType_TitleAndNutritionInfoIsMapped_ForExistingRecord()
//        {
//            //arrange
//            List<NutritionInfoModel> nutritionInfoModels = new List<NutritionInfoModel>
//            {
//                new NutritionInfoModel()
//                {
//                    NutrientType = NutrientTypesModel.Calories,
//                    Quantity = 300,
//                    QuantityType = QuantityTypesModel.Kcal
//                },
//                new NutritionInfoModel()
//                {
//                    NutrientType = NutrientTypesModel.Fats,
//                    Quantity = 200,
//                    QuantityType = QuantityTypesModel.Grams
//                }

//            };
//            var existingRecipe = new RecipeModel { Name = "Recipe Test", NutritionInfos = nutritionInfoModels };
//            _recipesRepositoryMock.Setup(x => x.GetAll()).Returns(new List<RecipeModel> { existingRecipe });

//            //act
//            var result = _sut.GetAll()[0];

//            //assert
//            result.NutritionInfos[0].NutrientType.ShouldBeEqualTo(NutrientTypesViewModel.Calories);
//        }

//        [TestMethod]
//        public void GetAll_ReturnsAllSteps_WhenTableContainsRecords()
//        {
//            //arrange
//            var existingRecipe = new RecipeModel
//            {
//                Steps = new List<StepModel>
//                {
//                    new StepModel(),
//                    new StepModel()
//                }
//            };

//            _recipesRepositoryMock.Setup(x => x.GetAll()).Returns(new List<RecipeModel> { existingRecipe });

//            //act
//            var result = _sut.GetAll()[0];

//            //assert
//            result.Steps.Count.ShouldBeEqualTo(2);
//        }

//        [TestMethod]
//        public void GetAll_ContentFieldIsMapped_ForExistingStep()
//        {
//            //arrange
//            var existingRecipe = new RecipeModel { Steps = new List<StepModel>() { new StepModel() { Content = "" } } };
//            _recipesRepositoryMock.Setup(x => x.GetAll()).Returns(new List<RecipeModel> { existingRecipe });

//            //act
//            var result = _sut.GetAll()[0];

//            //assert
//            result.Steps[0].Content.ShouldBeEqualTo(existingRecipe.Steps[0].Content);
//        }

//        [TestMethod]
//        public void GetAll_ReturnsAllNotes_WhenTableContainsRecords()
//        {
//            //arrange
//            var existingRecipe = new RecipeModel
//            {
//                Notes = new List<NoteModel>
//                {
//                    new NoteModel(),
//                    new NoteModel()
//                }
//            };

//            _recipesRepositoryMock.Setup(x => x.GetAll()).Returns(new List<RecipeModel> { existingRecipe });

//            //act
//            var result = _sut.GetAll()[0];

//            //assert
//            result.Notes.Count.ShouldBeEqualTo(2);
//        }

//        [TestMethod]
//        public void GetAll_ContentFieldIsMapped_ForExistingNote()
//        {
//            //arrange
//            var existingRecipe = new RecipeModel { Notes = new List<NoteModel>() { new NoteModel() { NoteContent = "Note" } } };
//            _recipesRepositoryMock.Setup(x => x.GetAll()).Returns(new List<RecipeModel> { existingRecipe });

//            //act
//            var result = _sut.GetAll()[0];

//            //assert
//            result.Notes[0].NoteContent.ShouldBeEqualTo(existingRecipe.Notes[0].NoteContent);
//        }
//    }
//}
