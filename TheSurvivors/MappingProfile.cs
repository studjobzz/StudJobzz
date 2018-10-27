using AutoMapper;

namespace TheSurvivors
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //Examples from another application

            //CreateMap<RecipeModel, RecipeQueryViewModel>()
            //   .ForMember(d => d.RecipesMedia, opt => opt.MapFrom(x => x.RecipesMedia))
            //   .ForMember(d => d.NutritionInfos, opt => opt.MapFrom(x => x.NutritionInfos));
            //CreateMap<RecipeCommandViewModel, RecipeModel>()
            //    .ForMember(RecipeCommandViewModel => RecipeCommandViewModel.RecipesMedia, mediaViewModelInModel => mediaViewModelInModel.Ignore())
            //    .ForMember(d => d.NutritionInfos, opt => opt.MapFrom(x => x.NutritionInfos));
            //CreateMap<ShoppingListModel, ShoppingListQueryViewModel>()
            //    .ForMember(model => model.ShoppingListMedia, opt => opt.MapFrom(x => x.ShoppingListMedia));
            //CreateMap<ShoppingListCommandViewModel, ShoppingListQueryViewModel>()
            //    .ForMember(model => model.ShoppingListMedia, viewModel => viewModel.Ignore());
            //CreateMap<ShoppingListCommandViewModel, ShoppingListModel>()
            //    .ForMember(model => model.ShoppingListMedia, viewModel => viewModel.Ignore());

            //CreateMap<IngredientModel, IngredientViewModel>();
            //CreateMap<IngredientViewModel, IngredientModel>();

            //CreateMap<QuantityTypeViewModel, QuantityType>()
            //    .ConvertUsing(qtype => (QuantityType)qtype.Id);
            //CreateMap<QuantityType, QuantityTypeViewModel>()
            //    .ForMember(qtypevm => qtypevm.Id, opts => opts.ResolveUsing(qtype => (int)qtype))
            //    .ForMember(qtypevm => qtypevm.Name, opts => opts.ResolveUsing(qtype => qtype.ToString()));
            //CreateMap<ShoppingListModel, ShoppingListViewModel>();
            //CreateMap<ShoppingListViewModel, ShoppingListModel>();

            //CreateMap<StepModel, StepViewModel>();
            //CreateMap<StepViewModel, StepModel>();
            //CreateMap<NoteViewModel, NoteModel>();
            //CreateMap<NoteModel, NoteViewModel>();
            //CreateMap<ItemListViewModel, ItemListModel>();
        }
    }
}