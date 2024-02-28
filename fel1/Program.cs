using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.fel
{
  class Program
  {
    static void Main(string[] args)
    {
      List<int> nums = new List<int>(); //list for data
      Console.WriteLine("Kerem a szamok szamat: ");
      string db = Console.ReadLine();
      int db2 = int.Parse(db);
      Random rand = new Random();
      int randy=rand.Next(10, 31);
      nums.Add(randy);
      for (int i=0;i < db2; i++)
      {
        int other = rand.Next(1, 6) + randy;
        randy = other;
        nums.Add(randy);
      }
      foreach (var item in nums)
      {
        Console.WriteLine(item);
      }
    }
  }
}
