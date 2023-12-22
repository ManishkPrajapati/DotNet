using Art;
using System.Drawing;
namespace TestPaint;

public partial class Form1 : Form
{   
    Art.Point start;
    Art.Point end;
    public Form1()
    {
        InitializeComponent();
        start = new Art.Point(0,0);
        end = new Art.Point(0,0);
        Paint += new System.Windows.Forms.PaintEventHandler(OnPaint);
        MouseDown+=new System.Windows.Forms.MouseEventHandler(onMouseDown);
        MouseUp+=new System.Windows.Forms.MouseEventHandler(onMouseUp);
    }

    public void OnPaint(object sender,PaintEventArgs e){

    }
    public void onMouseDown(object sender,MouseEventArgs e){
        start = new Art.Point(e.X,e.Y);
    }
    public void onMouseUp(object sender, MouseEventArgs e){
        end = new Art.Point(e.X,e.Y);
        Line l = new Line(start,end,"Blue",3);
        Pen pen = new Pen(Color.FromArgb(255,255,0,0));
        Graphics g=this.CreateGraphics();
        g.DrawLine(pen,l.start.X,l.start.Y,l.end.X,l.end.Y);
    }
}
