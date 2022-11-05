var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection(); // Uygulamada https g�venli ba�lant� y�nlendirmesi kullan
app.UseStaticFiles(); // Uygulamada Statik dosyalar (css, js k�t�phaneleri ve resim dosyalar�) kullan�ls�n

app.UseRouting(); // Uygulamada routing kullan�ls�n (/Home/Index)

app.UseAuthorization(); // Uygulamada oturum i�leminden sonra yetkilendirme kullan�ls�n

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"); // Uygulamada kullan�lacak olan routing yap�s�

app.Run(); // Uygulamay� yukar�daki ayarlara g�re �al��t�r.
