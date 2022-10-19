using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

builder.Services
// habilita o serviço de MVC na aplicação web, permitindo uma arquitetura baseada no modelo MVC - model, views, controllers
.AddControllersWithViews()
//explique aqui
.AddRazorRuntimeCompilation();

// Habilita o serviço do SQLite na aplicação web, permitindo a criação de um banco de dados
builder.Services.AddDbContext<AppDbContext>(opt => {
opt.UseSqlite("Data Source=dados.db");
});

var app = builder.Build();

// Determina o uso de uma página de resposta para o erro. 
//No entanto, isso é apenas para uma aplicação em ambiente de desenvolvimento ( "ASPNETCORE_ENVIRONMENT": "Development")
app.UseDeveloperExceptionPage();

//Força o uso de https
//app.UseHttpsRedirection();

//explique
app.UseStaticFiles();

// Habilita o roteamento de URL
// Isso significa que, de acordo com a rota no URL, a aplicação poderá decodificar a URL para saber qual controller e ação usar, bem como, opcionalmente, a id

app.UseRouting();

//define o mapeamento do padrao de rota
app.MapControllerRoute(
    name: "default", 
    pattern: "{controller=Home}/{action=Index}/{id?}");// o primeiro componente da URL é o controller (por padrão, é o home).
    //Depois da barra, vem a action, que é index por padrão. O terceiro é a ID, que tem interrogação pois não é obrigatório. Exemplo: action para alterar um produto (alterar produto com id 36: Produto/Alterar/36)


app.Run();
