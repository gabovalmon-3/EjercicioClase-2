﻿
using Entities;
using System.Data.Common;

public class Program
{

    public static void Main(string[] args)
    {
        //Instancia del gato

        var myCat = new Cat() { Id = 1, Name= "test" };

        Console.WriteLine("Id del gato: " + myCat.Id);

        Console.WriteLine("Nombre del gato: " + myCat.Name);

        Console.WriteLine("Ingrese una descripcion para el gato");

        myCat.Description = Console.ReadLine();



    }
}