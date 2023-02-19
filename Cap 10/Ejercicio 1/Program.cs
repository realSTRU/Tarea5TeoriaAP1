using System;

namespace Program
{
    class Program
    {
        static void Main()
        {
           

           Console.WriteLine("Inventario de procductos");
           Console.WriteLine("*********************************************************");
           
           Producto Product1 = new Producto(1,"Pasta Dental", 23,235.00,475.35);
           Producto Product2 = new Producto(1,"Jabon Spirit", 10,20.10,75.90);
           Producto Product3 = new Producto(1,"Pancakes Aunt Jemania", 689,100.00,656.90);
           Producto Product4 = new Producto(1,"Huevos Criollos", 70,70.00,120.00);
           Producto Product5 = new Producto(1,"Pan Pizza", 100,80.00,139.00);
           Producto Product6 = new Producto(1,"Carne magra de alce", 11,200.00,450.00);
        }
    }
}