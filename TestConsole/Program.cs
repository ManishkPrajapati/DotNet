// See https://aka.ms/new-console-template for more information
using Hardware;
using Art;
using System.Collections.Generic;

Console.WriteLine("Hello, World!");

Hdrive p = new Hdrive();
p.Print();
p.Scan();

List<Shape> s1 =new List<Shape>();
Line l = new Line();
l.start=new Art.Point(45,25);
l.end=new Art.Point(52,63);
l.color = "Blue";
l.Width = 3;

Point Centre =new Point(45,72);
Circle c= new Circle(Centre,10,"blue",3);
c.Draw();
s1.Add(l);
s1.Add(c);

Console.WriteLine("All Shapes Showing");
foreach(Shape s in s1 ){
    Console.WriteLine(s);
}