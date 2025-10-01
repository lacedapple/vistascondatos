using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using VistasMVC.Models;

namespace VistasMVC.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        LibreriaVistas.Alumno alumno1 = new LibreriaVistas.Alumno
        {
            Nombre = "María José Hernández Martínez",
            NumeroControl = "24328051050248"
        };

        LibreriaVistas.Alumno alumno2 = new LibreriaVistas.Alumno();
        alumno2.Nombre = "Ana Beatriz Hernández Pavón";
        alumno2.NumeroControl = "24328051050249";

        LibreriaVistas.HojaPresentacion presentacion = new LibreriaVistas.HojaPresentacion();
        presentacion.Alumnos.Add(alumno1);
        presentacion.Alumnos.Add(alumno2);
        presentacion.Carrera = "Técnico en Programación";
        presentacion.Grupo = "D";
        presentacion.NombrePlantel = "Ing. Alejandro Prieto Quintero";
        presentacion.Plantel = "Centro de Bachillerato Tecnológico Industrial y de Servicios No.105";
        presentacion.Semestre = 3;

        return View(presentacion);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
