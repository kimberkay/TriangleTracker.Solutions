using System;

namespace ShapeTracker.Models
{
  public class TriangleTracker
  {
    private int _side1;
    private int _side2;
    private int _side3;

    public TriangleTracker(int firstSide, int secondSide, int thirdSide)
    {
      _side1 = firstSide;
      _side2 = secondSide;
      _side3 = thirdSide;
    }

    public string CheckType()
    {
      if ((_side1 > (_side2 + _side3)) || (_side2 > (_side1 + _side3)) || (_side3 > (_side1 + _side2))) 
      {
        return "Not a triangle.";
      }
      else if ((_side1 != _side2) && ((_side1 != _side3)) && ((_side2 != _side3)))
      {
        return "Is a scalene triangle.";
      }
      else if ((_side1 == _side2) && (_side1 == _side3))
      {
        return "Is an equilateral triangle.";
      }
      else 
      {
        return "Is an isosceles triangle.";
      }
    }
  }
}
/*
Triangle.prototype.checkType = function() {
  if ((this.side1 > (this.side2 + this.side3)) || (this.side2 > (this.side1 + this.side3)) || (this.side3 > (this.side1 + this.side2))) {
    return "not a triangle";
  } else if ((this.side1 !== this.side2) && ((this.side1 !== this.side3)) && ((this.side2 !== this.side3))) {
    return "scalene triangle";
  } else if ((this.side1 === this.side2) && (this.side1 === this.side3)) {
      return "equilateral triangle";
  } else {
    return "isosceles triangle";
  }
};
*/