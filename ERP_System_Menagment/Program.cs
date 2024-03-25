using ERP_System_Menagment_Infrastuctor.Data;
using ERP_System_Menagment_Infrastuctor.Data.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace ERP_System_Menagment
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

           
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<ERPSystemDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.ConfigureApplicationCookie(option => {

                option.Cookie.SameSite = SameSiteMode.Strict;
                option.LoginPath = "/User/Login";
                option.LogoutPath = "/User/Login";
            });


            builder.Services.AddIdentity<Users, IdentityRole>(options =>
            {
                options.SignIn.RequireConfirmedAccount = true;
                options.Password.RequireDigit = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredLength = 6;
            })
            .AddDefaultUI()
            .AddEntityFrameworkStores<ERPSystemDbContext>()
            .AddDefaultTokenProviders();
            builder.Services.AddControllersWithViews();

            var app = builder.Build();

           
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();



            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");


            //using (var scope = app.Services.CreateScope())
            //{
            //    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            //    var roles = new[] { "Administrator", "User", "Menager" };

            //    foreach (var role in roles)
            //    {
            //        if (!await roleManager.RoleExistsAsync(role))
            //            await roleManager.CreateAsync(new IdentityRole(role));
            //    }
            //}

            //using (var scope = app.Services.CreateScope())
            //{
            //    var userManager = scope.ServiceProvider.GetRequiredService<UserManager<Users>>();

            //    string email = "Repoit@abv.bg";

            //    if (await userManager.FindByEmailAsync(email) == null)
            //    {
            //        var user = new Users()
            //        {
            //            Id = "b5a3dd97-a911-493b-88c0-cd062aef88bc",
            //            Avatar = "https://us.123rf.com/450wm/anatolir/anatolir2011/anatolir201105528/159470802-jurist-avatar-icon-flat-style.jpg?ver=6",
            //            FirstName = "Radoslav",
            //            LastName = "Hristov",
            //            Email = "Repoit@abv.bg",
            //            EmailConfirmed = true,
            //            UserName = "Admin",
            //            NormalizedUserName = "Admin",
            //            NormalizedEmail = "Repoit@abv.bg",
            //        };

            //        await userManager.CreateAsync(user, "Admin3516@");
            //        await userManager.AddToRoleAsync(user, "Administrator");
            //    }

            //    string menEmail = "maria89@gmail.com";

            //    if (await userManager.FindByEmailAsync(menEmail) == null)
            //    {
            //        var menagerUser = new Users()
            //        {
            //            Id = "e8d663de-89f9-40fb-a7a3-ec0f66a18aa5",
            //            Avatar = "https://cdn2.vectorstock.com/i/1000x1000/54/41/young-and-elegant-woman-avatar-profile-vector-9685441.jpg",
            //            FirstName = "Maria",
            //            LastName = "Atanasova",
            //            Email = "maria89@gmail.com",
            //            EmailConfirmed = true,
            //            UserName = "maria89@gmail.com",
            //            NormalizedEmail = "maria89@gmail.com",
            //            NormalizedUserName = "maria89@gmail.com"
            //        };

            //        await userManager.CreateAsync(menagerUser, "Maria123@");
            //        await userManager.AddToRoleAsync(menagerUser, "Menager");
            //    }

            //    string userEmail = "bobi1101@gmail.com";

            //    if (await userManager.FindByEmailAsync(userEmail) == null)
            //    {
            //        var menagerUser = new Users()
            //        {
            //            Id = "f620aaf2-03e7-4252-adf8-bc286f246a45",
            //            Avatar = "https://us.123rf.com/450wm/anatolir/anatolir2011/anatolir201105528/159470802-jurist-avatar-icon-flat-style.jpg?ver=6",
            //            FirstName = "Borislav",
            //            LastName = "Antonov",
            //            Email = "bobi1101@gmail.com",
            //            EmailConfirmed = true,
            //            UserName = "bobi1101@gmail.com",
            //            NormalizedEmail = "bobi1101@gmail.com",
            //            NormalizedUserName = "bobi1101@gmail.com"
            //        };

            //        await userManager.CreateAsync(menagerUser, "Bobi31126@");
            //        await userManager.AddToRoleAsync(menagerUser, "User");
            //    }
            //}


            app.Run();
        }
    }
}