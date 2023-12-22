namespace Hardware;

public class Hdrive:Iprinter, IScan{
    public void Print(){
        Console.WriteLine("Printing Pages.....");
    }
    public void Scan(){
        Console.WriteLine("Scanning Don't know why");
    }
}