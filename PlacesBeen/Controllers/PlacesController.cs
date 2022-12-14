using Microsoft.AspNetCore.Mvc;
using PlacesBeen.Models;


namespace PlacesBeen.Controllers
{
  public class PlacesController : Controller
  {

    [HttpGet("/places")]
    public ActionResult Index()
    {
      List<Places> allPlaces = Places.GetAll();
      return View(allPlaces);
    }

    [HttpGet("/places/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/places")]
    public ActionResult Create(string cityname, string durration, string accomp, string journal)
    {
      Places newPlaces1 = new Places(cityname, durration, accomp, journal);
      return RedirectToAction("Index");
    }

    [HttpPost("/places/delete")]
    public ActionResult Delete()
    {
      Places.ClearAll();
      return View();
    }

    [HttpGet("/places/{id}")]
    public ActionResult Show(int id)
    {
      Places foundPlace = Places.Find(id);
      return View(foundPlace);
    }
  }
}