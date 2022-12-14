using System.Collections.Generic;

namespace PlacesBeen.Models
{
  public class Places
  {
    public string CityName { get; set; }

    public string Durration { get; set; }

    public string Accomp { get; set; }

    public string Journal { get; set; }

    public int Id { get; }

    private static List<Places> _places = new List<Places> { };

    public Places(string cityname, string durration, string accomp, string journal)
    {
      CityName = cityname;
      Durration = durration;
      Accomp = accomp;
      Journal = journal;
      _places.Add(this);
      Id = _places.Count;
      
    }


    public static List<Places> GetAll()
    {
      return _places;
    }

    public static void ClearAll()
    {
      _places.Clear();
    }

    public static Places Find(int searchId)
    {
      return _places[searchId-1];
    }




  }
}
