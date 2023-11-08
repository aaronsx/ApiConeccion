using ConeccionApi.Models;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();
var urlUsuario = "https://localhost:7051/api/Usuario";
var urlAcceso= "https://localhost:7051/api/Acceso";
JsonSerializerOptions option= new JsonSerializerOptions() { PropertyNameCaseInsensitive=true};
using (var httpCliente =new HttpClient())
{
    var responseUsuario = await httpCliente.GetAsync(urlUsuario);
    var responseAcceso = await httpCliente.GetAsync(urlAcceso);
    if (responseUsuario.IsSuccessStatusCode)
    {
        var content=await responseUsuario.Content.ReadAsStringAsync();
        var usuario= JsonSerializer.Deserialize<List<Usuario>>(content, option);
        foreach (var cadaUsuario in usuario)
        {
            Console.WriteLine(cadaUsuario.ToString());
        }
    }
    if (responseAcceso.IsSuccessStatusCode)
    {
        var content = await responseAcceso.Content.ReadAsStringAsync();
        var acceso = JsonSerializer.Deserialize<List<Acceso>>(content, option);
        foreach (var cadaAcceso in acceso)
        {
            Console.WriteLine(cadaAcceso.ToString());
        }
    }
}
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

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
