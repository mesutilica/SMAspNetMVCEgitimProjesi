using AspNetCoreMVCProjesi.Models;
using FluentValidation;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddScoped<IValidator<Kullanici>, KullaniciValidator>(); // FluentValidation kullanarak validasyon yapacaðýmýzý uygulamaya bildiriyoruz

builder.Services.AddSession(option => option.IdleTimeout = TimeSpan.FromMinutes(3)); // servis olarak session ý ekledik

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection(); // Uygulamada https güvenli baðlantý yönlendirmesi kullan
app.UseStaticFiles(); // Uygulamada Statik dosyalar (css, js kütüphaneleri ve resim dosyalarý) kullanýlsýn

app.UseSession(); // uygulamada session kullanmak istediðimizi belirttik

app.UseRouting(); // Uygulamada routing kullanýlsýn (/Home/Index)

app.UseAuthorization(); // Uygulamada oturum iþleminden sonra yetkilendirme kullanýlsýn

app.MapControllerRoute(
            name: "admin",
            pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
          );

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); // Uygulamada kullanýlacak olan routing yapýsý

app.Run(); // Uygulamayý yukarýdaki ayarlara göre çalýþtýr.
