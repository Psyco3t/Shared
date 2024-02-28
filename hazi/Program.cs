using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;


namespace kulonAllo
{
 class Program
 {
   static void Main(string[] args)
   {
     string path1 = @"C:\Users\studenti\Desktop\pontok.txt";
     List<string> lines = File.ReadAllLines(path1).ToList();
     List<Point> points = new List<Point>(); //empty list need to fill with points obj
     for (int i = 0; i < lines.Count; ++i) //need to count lines repeat until i > lines
     {
       Point point = new Point(1, 2); //every cycle a new point obj is created 
       string[] data = lines[i].Split(','); //split string at ,
       int x = int.Parse(data[0]); //convert to int 
       int y = int.Parse(data[1]); //need both lines from txt
       point.X = x;
       point.Y = y;
       points.Add(point); //hozzáadás a listához
     }
     printPoints(points);
    //Lista elemeinek kiírása függvénnyel

     Point p1 = points[0];
     Point p2 = points[1];
     double minDistance = p1.distance(p2);
   // legkisebb táv kiszámítása és a legközelebbi pontok meghtározása
   for (int i = 0; i < points.Count-1; i++)
    {
    for (int j = i + 1; j < points.Count; j++)  //vegig megyunk
     {
      double distance = points[i].distance(points[j]);
      if(distance<minDistance)
      {
       minDistance=distance;
       p1=points[i];
       p2=points[j];
      }
     }
    }
   Console.WriteLine("A legrövidebb táv a {0} és {1} pontok között van!", p1,p2 ); //object needs to be converted to string 
   Console.WriteLine("A legrövidebb táv értéke: {0} ", minDistance);
   }
  public static void printPoints(List<Point> p) //bigbrain
   {
   foreach (var item in p)
    {
      Console.WriteLine("({0},{1})\n", item.X, item.Y);
    }

   }        
  }
 }