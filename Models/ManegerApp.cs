using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_BrayanRodriguez.Models;

public class ManegerApp
{
    public static Dog CreateDog()
    {
        Console.Write(@$"
        AGREGANDO NUEVO PERRO A LA BASE DE DATOS
        Ingrese Nombre del Perro: ");
        string name = Console.ReadLine() ?? "No Asignado Aún";

        Console.Write(@$"
        Ingrese el año de nacimiento del {name}: ");
        int year = Convert.ToInt16(Console.ReadLine());

        Console.Write(@$"
        Ingrese el mes de nacimiento {name}");
        byte month = Convert.ToByte(Console.ReadLine());

        Console.Write(@$"
        Ingrese el dia de nacimiento {name}");
        byte day = Convert.ToByte(Console.ReadLine());

        Console.Write(@$"
        Ingrese la raza de {name}");
        string breed = Console.ReadLine() ?? "No Asignado";

        Console.Write(@$"
        Ingrese el color de {name}");
        string color = Console.ReadLine() ?? "No Asignado";

        Console.Write(@$"
        Ingrese el peso en kilogramos de {name}");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write(@$"
        Ingrese el numero del microchip de {name}");
        string microchip= Console.ReadLine() ?? "No Asignado";

        Console.Write(@$"
        ¿que tan alto lagra {name}?");
        string bark = Console.ReadLine()??"No Asignado";

        return new Dog(name,year,month,day,breed,color,weight,microchip,bark)


    }
    public static Cat CreateCat() { 
        Console.Write(@$"
        AGREGANDO NUEVO GATO A LA BASE DE DATOS
        Ingrese Nombre del Gato: ");
        string name = Console.ReadLine() ?? "No Asignado Aún";

        Console.Write(@$"
        Ingrese el año de nacimiento del {name}: ");
        int year = Convert.ToInt16(Console.ReadLine());

        Console.Write(@$"
        Ingrese el mes de nacimiento {name}");
        byte month = Convert.ToByte(Console.ReadLine());

        Console.Write(@$"
        Ingrese el dia de nacimiento {name}");
        byte day = Convert.ToByte(Console.ReadLine());

        Console.Write(@$"
        Ingrese la raza de {name}");
        string breed = Console.ReadLine() ?? "No Asignado";

        Console.Write(@$"
        Ingrese el color de {name}");
        string color = Console.ReadLine() ?? "No Asignado";

        Console.Write(@$"
        Ingrese el peso en kilogramos de {name}");
        double weight = Convert.ToDouble(Console.ReadLine());

        return new Cat(name,year,month,day,breed,color,weight);
    }
    
    public void ShowHeader() {
        Console.Clear();
        Console.WriteLine("#######·· VETERINARY CENTER ··#######");
     }
    public void ShowFooter() {
        Console.WriteLine("#######········· RIWI ·········#######");
     }
    public void ShowSeparator() { 
        Console.WriteLine("-----------------------------------");
    }

}
