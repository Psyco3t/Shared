using System;
using System.Collections.Generic;
using System.Text;

namespace kulonAllo
{
  class Point
  {
    private int x;
    private int y;
    public Point(int x, int y)//default constructor because it is empty turn it into param construct
    {
      this.x = x;
      this.y = y;
    }
    public int X
    {
      set
      {
        x = value;
      }
      get
      {
        return x;
      }
    }
    public int Y
    {
      set
      {
        y = value;
      }
      get
      {
        return y;
      }
    }
    public double distance(Point b)
    {
      return Math.Sqrt((b.X - x) * (b.X - x) * (b.Y - y) * (b.Y - y));
    }
    ~Point() //destructor
    {
      Console.WriteLine("");
    }
    public override string ToString()
    {
      return "(" + x.ToString() + "," + y.ToString() + ")";// (1,2)
    }
  }
}