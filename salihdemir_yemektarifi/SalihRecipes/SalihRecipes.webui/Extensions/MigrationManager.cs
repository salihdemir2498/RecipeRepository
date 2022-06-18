using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SalihRecipes.data.Concrete.EfCore;
using SalihRecipes.webui.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalihRecipes.webui.Extensions
{
    public static class MigrationManager
    {
        public static IHost MigrateDatabase(this IHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                using (var applicationContext = scope.ServiceProvider.GetRequiredService<ApplicationContext>())
                {
                    try
                    {
                        applicationContext.Database.Migrate();
                    }
                    catch (System.Exception)
                    {
                        //loglama
                        throw;
                    }
                }

                using (var salihRecipesContext = scope.ServiceProvider.GetRequiredService<SalihRecipesContext>())
                {
                    try
                    {
                        salihRecipesContext.Database.Migrate();
                    }
                    catch (System.Exception)
                    {
                        //loglama
                        throw;
                    }
                }
            }

            return host;
        }
    }
}
