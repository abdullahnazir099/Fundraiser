using FundRaisers.Areas.Identity.Data;
using FundRaisers.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


    var builder = WebApplication.CreateBuilder(args);
    var connectionString = builder.Configuration.GetConnectionString("FundRaisersDbContextConnection") ?? throw new InvalidOperationException("Connection string 'FundRaisersDbContextConnection' not found.");

    builder.Services.AddDbContext<FundRaisersDbContext>(options =>
        options.UseSqlServer(connectionString));

    builder.Services.AddDefaultIdentity<FundRaisersUser>(options => options.SignIn.RequireConfirmedAccount = true)
        .AddRoles<IdentityRole>()
        .AddEntityFrameworkStores<FundRaisersDbContext>();

    // Add services to the container.
    builder.Services.AddControllersWithViews();
    builder.Services.AddRazorPages();
    var app = builder.Build();

    // Configure the HTTP request pipeline.
    if (!app.Environment.IsDevelopment())
    {
        app.UseExceptionHandler("/Home/Error");

        app.UseHsts();
    }

    app.UseHttpsRedirection();
    app.UseStaticFiles();

    app.UseRouting();
    app.UseAuthentication(); ;

    app.UseAuthorization();

    app.MapControllerRoute(
        name: "default",
        pattern: "{controller=Home}/{action=Index}/{id?}");
    app.MapRazorPages();
    //using(var scope =app.Services.CreateScope())
    //{
    //    var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();
    //    var roles = new[] { "Admin","Manager","user"};
    //    foreach (var role in roles)
    //    {
    //        if (!await roleManager.RoleExistsAsync(role))
    //            await roleManager.CreateAsync(new IdentityRole(role));  
    //        {
            
    //        }
    //    }
    //}
Dbinitilizer.SeedUsersAndRolesAsync(app).Wait();

app.Run();

