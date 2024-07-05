using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    // 
    // GET: /HelloWorld/
    public IActionResult Index()
    {
        return View();
    }
    // 
    // GET: /HelloWorld/Welcome/ 
    // On modifie la méthode Welcome d'origine qui prenait un name et un ID
    // pour qu'elle prenne en paramètre un modèle de vue.

    // public string Welcome(string name, int numTimes = 1)
    // {
    //     return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
    // }

    // Nouvelle méthode Welcome
    // L'objet dictionnaire ViewData contient des données passées à la vue
    public IActionResult Welcome(string name, int numTimes = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }
}