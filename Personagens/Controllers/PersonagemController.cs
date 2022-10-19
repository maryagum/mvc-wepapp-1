using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Personagens.Models;
namespace Personagens.Controllers;
public class PersonagemController : Controller
{
    private readonly AppDbContext _db;
    public PersonagemController(AppDbContext db)
    {
        _db = db;
    }

    public IActionResult Index()
    {
    // essa linha de código transforma a tabela Personagens, presente no banco de dados, em uma lista. Essa lista será armazenada na variável de tipo var, personagens
        var personagens = _db.Personagens.AsNoTracking().ToList();
        return View(personagens);
    }

    [HttpGet]
    public IActionResult Cadastrar()
    {
        var personagem = new Personagem();
        return View(personagem);
    }

    [HttpPost]
    public IActionResult Cadastrar(Personagem personagem)
    {
        // retorna a view apenas se os dados inseridos forem validos, ou seja, dentro dos tipos determinados no model Personagem.cs
        if(!ModelState.IsValid){
            return View(personagem);
        }
        // adiciona ao banco de dados um novo personagem, recebendo os dados inseridos pelo usuario
        _db.Personagens.Add(personagem);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Alterar(int id)
    {
        // a partir desse comando, é pesquisado no banco de dados uma instancia de Personagem que tenha o id passado como parametro — e é armazenado na variável tipo var personagemOriginal
        var personagemOriginal = _db.Personagens.Find(id);
        if(personagemOriginal is null)
        {
            return RedirectToAction("Index");
        }

        return View(personagemOriginal);
        
    }

    [HttpPost]
    public IActionResult Alterar(int id, Personagem personagem)
    {
        var personagemOriginal = _db.Personagens.Find(id);
        if (personagemOriginal is null)
        {
            return RedirectToAction("Index");
        }
        if (!ModelState.IsValid)
        {
            return View(personagem);
        }

        //atribui as propriedades de personagemoriginal para personagem, alterando os dados de personagem no banco de dados
        personagemOriginal.Nome = personagem.Nome;
        personagemOriginal.Altura = personagem.Altura;
        personagemOriginal.DataEstreia = personagem.DataEstreia;
        personagemOriginal.IsAlive = personagem.IsAlive;
        _db.SaveChanges();
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Excluir(int id)
    {
        var personagem = _db.Personagens.Find(id);
        if (personagem is null)
            return RedirectToAction("Index");

        return View(personagem);
    }

    [HttpPost]
    //"Route" determina a rota para acessar a action desejada. Essa rota aparece no URL do browser ao acessar a aplicação web.
    [Route("Personagem/Excluir/{id}")]
    public IActionResult ProcessarExcluir(int id)
    {
        var personagem = _db.Personagens.Find(id);
        if (personagem is null)
            return RedirectToAction("Index");

        _db.Personagens.Remove(personagem);
        _db.SaveChanges();
        return RedirectToAction("Index");
    }
}


