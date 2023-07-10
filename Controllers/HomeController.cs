using Microsoft.AspNetCore.Mvc;

namespace TP06.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewBag.listaPartidos=BD.ListarPartidos();
        return View();
    }
    public IActionResult VerDetallesPartido(int idPar){
        ViewBag.listaCandidatos=BD.ListarCandidatos(idPar);
        ViewBag.datosPartido=BD.VerInfoPartido(idPar);
        return View();
    }
    public IActionResult VerDetallesCandidato(int idCan){
        ViewBag.datosCandidato=BD.VerInfoCandidato(idCan);
        return View();
    }
    public IActionResult AgregarCandidato(int idPar){
        return View();
    }
    [HttpPost] IActionResult GuardarCandidato(Candidato can){
        BD.AgregarCandidato(can);
        return RedirectToAction("VerDetallesPartido");
    }
    public IActionResult EliminarCandidato(int idCan){
        BD.EliminarCandidato(idCan);
        return RedirectToAction("VerDetallesPartido");
    }
    public IActionResult Elecciones(){
        return View();
    }
    public IActionResult Creditos(){
        return View();
    }
}
