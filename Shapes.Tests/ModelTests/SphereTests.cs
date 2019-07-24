using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shapes.Models;

namespace Shapes.Tests
{
  [TestClass]
  public class SphereTests
  {

    [TestMethod]
    public void Sphere_GetVolume_VolumeOfCircle()
    {
      // Arrange
      Circle newCircle = new Circle(0, 5);
      Sphere newSphere = new Sphere(newCircle);
      // Act
      double result = newSphere.GetVolume();
      // Assert
      Assert.AreEqual(result, 523.333348929882);
    }

    [TestMethod]
    public void Sphere_GetSurfaceArea_SurfaceAreaOfSphere()
    {
     // Arrange
      Circle newCircle = new Circle(0, 5);
      Sphere newSphere = new Sphere(newCircle);
      // Act
      double result = newSphere.GetSurfaceArea();
      // Assert
      Assert.AreEqual(result, 314);
    }

  }  
}