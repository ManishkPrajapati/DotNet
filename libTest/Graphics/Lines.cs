using Hardware;
namespace Art;

public class Line:Shape,Iprinter{
    public Point start{get;set;}
    public Point end{get;set;}

    public Line():base(){
        this.start=new Point(0,0);
        this.end=new Point(0,0);
    }
    public Line(Point p1, Point p2, String c, int w):base(c,w){
        this.start=p1;
        this.end=p2;
    }
    public override void Draw(){
        Console.WriteLine("Drawing Line");
        Console.WriteLine(this);
    }
    public override string ToString(){
        return base.ToString()+ this.start+", "+this.end;
    }
    void Iprinter.Print(){
        Console.WriteLine("Printing line");
        Console.WriteLine(this);
    }
}
