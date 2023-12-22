namespace Art;

public abstract class Shape{
    public Shape(){
        this.color="blue";
        this.Width =1;
    }
    public Shape(String s, int w){
        this.color=s;
        this.Width=w;
    }

    public String color{get;set;}
    public int Width{get;set;}
    public abstract void Draw();
    public override string ToString(){
        return "Width = "+this.Width + ", Color = "+this.color;
    }
}