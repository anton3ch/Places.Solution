using System.Collections.Generic;
using System.Web.Helpers;

namespace Places.Models
{
  public class Place
  {
    public string City { get; set; }
    public string Companion { get; set; }
    public string Duration { get; set; }
    public string ImgURL { get; set; }
    public string Entry { get; set; }
    public int Id { get; }

    private static List<Place> _instances = new List<Place> { };

    public Place(string city, string companion, string duration, string imgURL, string entry)
    {
      City = city;
      Companion = companion;
      Duration = duration;
      ImgURL = imgURL;
      Entry = entry;
      _instances.Add(this);
      Id = _instances.Count;
    }

    public static List<Place> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }

    public static Place Find(int searchId)
    {
      return _instances[searchId-1];
    }

  }
}
