using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PlacesBeen.Models;
using System;

namespace PlacesBeen.Tests
{
  [TestClass]
  public class PlacesTests : IDisposable
  {

    public void Dispose()
    {
      Places.ClearAll();
    }

    [TestMethod]

    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Places newPlaces = new Places("1", "2", "3", "4");
      Assert.AreEqual(typeof(Places), newPlaces.GetType());
    }

    [TestMethod]
    public void GetAll_ReturnsPlaces_PlacesList()
    {
      // Arrange
      string places = "Delaware";
      string durration = "1 Week";
      string accomp = "The Rock";
      string journal = "It was great!";
      Places newPlaces1 = new Places(places, durration, accomp, journal);
      List<Places> newList = new List<Places> { newPlaces1 };

      //Act
      List<Places> result = Places.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ResturnsPlace_Places()
    {
      //Arrange
      string places = "Delaware";
      string durration = "1 Week";
      string accomp = "The Rock";
      string journal = "It was great!";

      Places newPlaces1 = new Places(places, durration, accomp, journal);

      //Act
      Places result = Places.Find(1);

      //Assert
      Assert.AreEqual("Delaware", result.CityName);
    }
  }
}