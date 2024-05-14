using Example01.Fonksiyonlar;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

//Sunucunun davranýþ þekline müdahale edilebilecek alan
//Veri tabaný baðlantýsý ekleme-pattern ekleme-eklenti ekleme


builder.Services.AddControllersWithViews(); // View yapýsýyla birlikte Controller ekledik.

WebApplication app = builder.Build();

#region Map Yapýsý

//app.MapGet("/", () => "Hello World!");
//app.MapGet("/anasayfa", async (httpContext) =>
//{
//    string page = httpContext.Request.Query["page"];
//    string size = httpContext.Request.Query["size"];
//    string response = $"Anasayfaya hoþgeldiniz. Sayfa : {page} Boyut: {size}";

//    //localhost:7106/anasayfa?page=1&size=10

//    await httpContext.Response.WriteAsync(response);
//});


//Web apide bunlarý tekrar göreceðiz. Þimdi mvcye geçiyoruz yukarýda eklenti kýsmýna bakalým.

//app.MapGet("/anasayfa", async (httpContext) =>
//{
//    Anasayfa anasayfa = new Anasayfa(httpContext);
//    anasayfa.HelloWorld();
//});
#endregion

//rotadan önce css için statik dosyalarý kullanýlabilir hale getirmeliyiz. statik sayfalardan ulaþamýyoruz. css bir ara katmandýr 
app.UseStaticFiles();
//ara katmana ulasmak için https://localhost:1234/css/main.css

app.UseHsts(); // Header da security durumu kontrol ediyor..

app.UseHttpsRedirection(); // Secure olmayan sayfayý ana porta redirect eder. http->https 

app.MapDefaultControllerRoute(); // otomatik rotalama ekledik. https://localhost:1234/

//Eðer deafult þekilde rota oluþturmak istemiyorsak
//app.MapControllerRoute(
//    name: "default",
//    pattern: "{controller= Anasayfa}/{action=Index}/{sayfaNo?}");

app.Run();
