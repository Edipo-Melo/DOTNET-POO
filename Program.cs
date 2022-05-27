using System;
using DOTNET_POO.SRC.Entities;

class Program
{
    static void Main(string[] args)

    {
        Knight arus = new Knight("Arus ", 23, " Kinght ");
        Wizard wizard = new Wizard("Jennica ", 23, " White Wizard");

        
        Console.WriteLine(arus);
        Console.WriteLine(arus.Attack());
        Console.WriteLine(wizard);
        Console.WriteLine(wizard.Attack(7));


    }
    
}