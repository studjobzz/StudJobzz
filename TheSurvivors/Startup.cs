using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SpaServices.ReactDevelopmentServer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace TheSurvivors
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //Example from another application

            //services.AddTransient<IRecipesRepository, RecipesRepository>();
            //services.AddTransient<IShoppingListRepository, ShoppingListRepository>();
            //services.AddTransient<IUserRepository, UserRepository>();
            //services.AddTransient<IMealPlanRepository, MealPlanRepository>();
            //services.AddSingleton(typeof(IConnectionStringProvider), new ConnectionStringProvider(Configuration.GetConnectionString("RecipesBox")));
            //services.AddSingleton<RecipesBoxContext>();
            //services.AddTransient<IRecipesService, RecipesService>();
            //services.AddTransient<IIngredientsService, IngredientsService>();
            //services.AddTransient<IShoppingListService, ShoppingListService>();
            //services.AddTransient<IUserService, UserService>();
            //services.AddTransient<IMealPlanService, MealPlanService>();
            //services.AddTransient<IFilteredListService, FilteredListService>();
            //services.AddAutoMapper();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            // In production, the React files will be served from this directory
            services.AddSpaStaticFiles(configuration =>
            {
                configuration.RootPath = "ClientApp/build";
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSpaStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller}/{action=Index}/{id?}");
            });

            app.UseSpa(spa =>
            {
                spa.Options.SourcePath = "ClientApp";

                if (env.IsDevelopment())
                {
                    spa.UseReactDevelopmentServer(npmScript: "start");
                }
            });
        }
    }
}
