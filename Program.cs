using Microsoft.EntityFrameworkCore;
using PrimeiroApp.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(o =>
    o.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

//"www.loja;com/MinhaConta/MeusPedidos/2020/Cancelados ====> N�O RECOMENDADA
//app.MapControllerRoute(
//    name: "MinhaConta",
//    pattern: "{controller=MinhaConta}/{action=MeusPedidos}/{ano}/{status}");

//Sempre esta rota padr�o por �ltimo
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
