using Microsoft.AspNetCore.Http;

namespace Example01.Fonksiyonlar
{
    public class Anasayfa
    {
        private HttpContext _httpContext;
        public Anasayfa(HttpContext httpContext)
        {
            _httpContext = httpContext;
        }
        public async Task HelloWorld()
        {
            string page = _httpContext.Request.Query["page"];
            string size = _httpContext.Request.Query["size"];
            string response = $"Anasayfaya hoşgeldiniz. Sayfa : {page} Boyut: {size}";

            //localhost:7106/anasayfa?page=1&size=10

            await _httpContext.Response.WriteAsync(response);
        }
    }
}
