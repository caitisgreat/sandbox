using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

class OrangeFruit: Fruit {
  public OrangeFruit() {
    Name = "Orange";
  }
}

class RedFruit : Fruit {
  public RedFruit () {
    Name = "Apple";
  }
}

class Fruit {
  public string Name { get; set; }
}

class Program
{
    public static void Main()
    {
      Func<Fruit, Fruit> ToUpper = f => { f.Name = f.Name.ToUpper(); return f; };
      // string[] fruit = { "apple", "orange", "banana", "pear", "cherry" };

      IEnumerable<Fruit> fruit = new List<Fruit>() {  new RedFruit(), new OrangeFruit(), ToUpper(new OrangeFruit()) };

      foreach(var f in fruit) {
        Console.WriteLine(f.Name);
      }
    }
}