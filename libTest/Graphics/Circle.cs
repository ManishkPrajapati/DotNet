using Hardware;
namespace Art;

public class Circle:Shape,Iprinter{
    public Point Centre{get;set;}
    public int Radius{get;set;}

    public Circle ():base(){
        this.Centre = new Point(0,0);
        this.Radius=4;
    }
    public Circle(Point p1, int r, string s, int w):base(s,w){
        this.Centre = p1;
        this.Radius=r;
    }
    public override void Draw(){
        Console.WriteLine("Printing Circle");
        Console.WriteLine(this);
    }
    public override string ToString(){
        const float pi=3.14f;
        float area = pi*Radius*Radius;
        return base.ToString()+this.Centre+", radius "+this.Radius+", Area = "+area;
    }
    void Iprinter.Print(){
        Console.WriteLine("Printing Circle");
        Console.WriteLine(this);
    }
}