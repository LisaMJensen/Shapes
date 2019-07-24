

namespace Shapes.Models
{
    public class Circle
    {
        public int Radius { get; set; }
        public double Circumference { get; set; }
        public int Diameter { get; set; }

    

    public Circle(int circleDiameter , int circleRadius)
    {
      Radius = circleRadius;
    //   Circumference = circleCircumference;
      Diameter = circleDiameter;
    }

    public int GetDiameter()
    {
        return 2 * Radius;
    }
    public double GetCircumference()
    {
      return 3.14 * Diameter;
    }

    public bool IsCircle()
    {
      if(Diameter % Radius == 0)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
