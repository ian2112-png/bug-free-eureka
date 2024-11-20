using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Reference reference1 = new Reference("John", 3, 16); 
        Reference reference2 = new Reference("Ether", 9, 4);
        Scripture scripture1 = new Scripture(reference1);

        reference1.Display();
        reference2.Display();
        scripture1.Display();

    }
}