using System;

namespace Shapes.Models
{
  public class Sphere
  {
    public Circle NewCircle { get; set; }

    public Sphere (Circle radius)
    {
      NewCircle = radius;
    }

    public double GetVolume()
    {
    int radius = NewCircle.Radius;
    return (4f / 3f * 3.14 * (radius * radius * radius));
    }

    public double GetSurfaceArea()
    {
    int radius = NewCircle.Radius;
    return 4 * 3.14 * (radius * radius);
    }
  }
}