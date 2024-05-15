WebApplicationBuilder builder = WebApplication.CreateBuilder(args); //1

builder.Services.AddControllersWithViews(); //2 - application olusturmadan önce view eklemeliyiz.

WebApplication app = builder.Build(); //3


//app.MapDefaultControllerRoute(); //4

app.MapControllerRoute( //bu yaptýðýmýz manuel map route 

    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run(); //5

// 6 MVC projemiz hazýr. Controller klasörü ve HomeController açýyoruz