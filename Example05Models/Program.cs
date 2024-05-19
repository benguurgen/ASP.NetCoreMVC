WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Controllers ve View yapýsýný service eklentisini dahil ediyoruz.
builder.Services.AddControllersWithViews();

WebApplication app = builder.Build();

//Https otomatik yönlendirme
app.UseHttpsRedirection();


//css,js vb statik statik sayfalarý çaðýrmak için ekliyoruz.
app.UseStaticFiles();


//Otomatik rotolama ekliyoruz.
app.MapDefaultControllerRoute();

app.Run();
