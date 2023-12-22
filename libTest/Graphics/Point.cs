namespace Art;
public class Point{
    public int X{get;set;}
    public int Y{get;set;}

    public Point(){
        this.X=0;
        this.Y=0;
    }
    public Point(int a, int b){
        this.X=a;
        this.Y=b;
    }
    public override string ToString(){
         string str=string.Format("X={0}, Y={1}", this.X, this.Y);
        return str;
    }
}