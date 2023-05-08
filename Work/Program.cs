using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Newtonsoft.Json.Serialization;
using Work.BL.Helper.Hubs;
using Work.BL.Interface;
using Work.BL.Mapper;
using Work.BL.Models;
using Work.BL.Repository;
using Work.DAL.Database;
using Work.DAL.Extend;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews(options => options.SuppressImplicitRequiredAttributeForNonNullableReferenceTypes = true)
    .AddNewtonsoftJson(opt => {

        opt.SerializerSettings.ContractResolver = new DefaultContractResolver();
    });


// DbContext Configuration
builder.Services.AddDbContextPool<WorkContext>(opt =>
                opt.UseSqlServer(builder.Configuration.GetConnectionString("WorkConnection"))
                );


// Auto Mapper
builder.Services.AddAutoMapper(x => x.AddProfile(new DomainProfile()));

// Dependency Injection
builder.Services.AddScoped<IUserRep, UserRep>();
builder.Services.AddScoped<IRolesRep, RolesRep>();
builder.Services.AddScoped<IPostRep,PostRep>();
builder.Services.AddScoped<IProjectRep, ProjectRep>();
builder.Services.AddScoped<IProjectAttachmentsRep, ProjectAttachmentsRep>();
builder.Services.AddScoped<IChatRep,ChatRep>();
builder.Services.AddScoped<IReplyRep,ReplyRep>();
builder.Services.AddScoped<IRequestRep, RequestRep>();
builder.Services.AddScoped<IRateRep, RateRep>();


// ------------------------ Identity Configrations  ------------------------------------
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme,
                options =>
                {
                    options.LoginPath = new PathString("/Home/Index");
                    options.AccessDeniedPath = new PathString("/Account/Login");
                });

builder.Services.AddIdentity<ApplicationUser, IdentityRole>(options =>
{
    // Default Password settings.
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequireUppercase = true;
    options.Password.RequiredLength = 6;
    options.Password.RequiredUniqueChars = 0;
}).AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<WorkContext>()
    .AddTokenProvider<DataProtectorTokenProvider<ApplicationUser>>(TokenOptions.DefaultProvider);

// ------------------------ Identity Configrations  ------------------------------------


builder.Services.AddSignalR();

var app = builder.Build();

app.MapHub<ChatHub>("/chatHub");
app.MapHub<NotificationHub>("/notificationHub");
// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();

// ----- Identity Configrations  ------
app.UseAuthorization();


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
