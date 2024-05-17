WebApplicationBuilder builder = WebApplication.CreateBuilder(args);


// Statik dosyalarýn root klasör adýný deðiþtirmek istersek..
//builder.Enviroment.ContentRootPath="rootFolder";


//Controller ve view yapýsýný projeye dahil ediyoruz.
builder.Services.AddControllersWithViews();

WebApplication app = builder.Build();


//Https yönlendirmesini ve css, js vb statik sayfalarýn çalýþmasýný saðlayalým.
app.UseHttpsRedirection();
app.UseStaticFiles(); // root folder= wwwroot olarak klasör oluþturuyoruz.


//Controller seviyesinde otomatik Rotalama iþlemi devreye alalým
app.MapDefaultControllerRoute();

//app.MapControllerRoute(
//    name: "public",
//    pattern: "Public/{controller=Home}/{action=Index}/{sayfaNo?}"
//    );

//app.MapControllerRoute(
//    name: "admin",
//    pattern: "Admin/{controller=Dashboard}/{action=Index}/{id?}"
//    );

app.Run();
