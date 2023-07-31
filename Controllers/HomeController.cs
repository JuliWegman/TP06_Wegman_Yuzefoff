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
        ViewBag.idpar=idPar;
        return View();
    }
    public IActionResult GuardarCandidato(int idPar,string Apellido,string Nombre, DateTime fechaNacimiento,string foto, string postulacion){
        BD.AgregarCandidato(new Candidato(1,idPar,Apellido,Nombre,fechaNacimiento,foto,postulacion));
        return RedirectToAction("VerDetallesPartido",new {idPar=idPar});
    }
    public IActionResult EliminarCandidato(int idCan,int idPar){
        BD.EliminarCandidato(idCan);
        return RedirectToAction("VerDetallesPartido",new {idPar=idPar});
    }
    public IActionResult Elecciones(){
        return View();
    }
    public IActionResult Creditos(){
        return View();
    }
}
