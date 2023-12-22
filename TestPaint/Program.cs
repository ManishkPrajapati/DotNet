using Art;
namespace TestPaint;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {   
        Line l = new Line();
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        l.color = "Blue";
        l.Width = 2;
        l.Draw();
        ApplicationConfiguration.Initialize();
        Application.Run(new Form1());
    }    
}