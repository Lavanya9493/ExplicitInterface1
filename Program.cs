using System;
interface I1
{
    void InterfaceMethod();
}
interface I2
{
    void InterfaceMethod();
}
class Myclass:I1,I2
{
    public void InterfaceMethod()
    {
       Console.WriteLine("I1 InterfaceMethod");
    }
    void I2.InterfaceMethod()
    {
        Console.WriteLine("I2 InterfaceMethod");
    }
}
class Program
{
    public static void Main(string[] args)
    {
        Myclass c=new Myclass();
        c.InterfaceMethod();
        I2 i2=c;
        i2.InterfaceMethod();
    }
}
