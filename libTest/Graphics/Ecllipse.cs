using Hardware;
namespace Art;

public class Ellipse:Shape,Iprinter{
    public Point start{get;set;}
    public Point end{get;set;}

    public Ellipse():base(){
        this.start=new Point(0,0);
        this.end=new Point(0,0);
    }
    public Ellipse(Point p1, Point p2, String s, int w):base(s,w){
        this.start=p1;
        this.end=p2;
    }
    public override void Draw(){
        Console.WriteLine("Drawing Ecllipse");
        Console.WriteLine(this);
    }
    public override string ToString(){
        return base.ToString()+this.start+", "+this.end;
    }
    void Iprinter.Print(){
        Console.WriteLine("Printing Ellipse");
        Console.WriteLine(this);
    }
}