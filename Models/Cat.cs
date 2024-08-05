using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_BrayanRodriguez.Models;

public class Cat : Animal
{
    public bool BreedingStatus { get; set; }
    public string? FurLength { get; set; }

    public Cat(string name, int year, byte month, byte day, string breed, string color, double kg) : base(name, year, month, day, breed, color, kg)
    {
        BreedingStatus = false;
        FurLength = "No Asignado Aún";
    }

    public void CastrateAnimal()
    {
        if (BreedingStatus == true)
        {
            Console.WriteLine($"{Name} ya está castrado");
             Console.ReadKey();
        }
        else
        {
            BreedingStatus = true;
            Console.WriteLine($"{Name} ha sido castrado exitosamente");
            Console.ReadKey();
        }
    }
    public void Hairdress()
    {
        int option = 0;
        while (option != 1)
        {
            Console.WriteLine($"Ingrese el tipo de cabello del gato {Name}:");
            Console.WriteLine($"1. Sin pelo");
            Console.WriteLine($"2. Pelo corto");
            Console.WriteLine($"3. Pelo mediano");
            Console.WriteLine($"4. Pelo largo");
            Console.WriteLine($"5. cancelar");

            string input = Console.ReadLine() ?? "";
            bool isNumeric = int.TryParse(input, out option);

            if (!isNumeric || option < 1 || option > 5)
            {
                Console.WriteLine("Opción no válida. Por favor, elija una opción entre 1 y 4.");
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
                continue;
            }

            switch (option)
            {
                case 1:
                    Console.WriteLine($"el cabello de {Name} se ha registrado como Lampiño");
                    FurLength = "Sin pelo";

                    break;
                case 2:
                    Console.WriteLine($"el cabello de {Name} se ha registrado como Corto");
                    FurLength = "Pelo corto";

                    break;
                case 3:
                    Console.WriteLine($"el cabello de {Name} se ha registrado como Mediano");
                    FurLength = "Pelo mediano";

                    break;
                case 4:
                    Console.WriteLine($"el cabello de {Name} se ha registrado como Largo");
                    FurLength = "Pelo largo";

                    break;
                case 5:
                    Console.WriteLine($"Saliendo...");

                    break;
            }

            if (option != 5)
            {
                Console.WriteLine("Presione cualquier tecla para volver al menú...");
                Console.ReadKey();
            }


        }
    }

    public override void ShowInformation()
    {
        Console.WriteLine(@$"
        ID: {Id}
        Nombre: {Name}
        Fecha de nacimiento: {BirthDate.Day}/{BirthDate.Month}/{BirthDate.Year}
        Raza: {Breed}
        Color: {Color}
        Peso: {WeightInKg}.Kg
        Está castrado?: {BreedingStatus}
        Pelaje: {FurLength}
        "
        );
    }

    public void LetBasicReview()
    {
        BasicReview();
    }

    public int LetCalculateAge()
    {
        return CalculateAgeInMonths();
    }

    public int HaveId(){
        return Id;
    }

    public string HaveName(){
        return Name??"No registrado";
    }

     public void EditName()
    {
        Console.WriteLine("Ingrese el nuevo nombre");
        Name = Console.ReadLine();
    }

    public void EditYear()
    {
        Console.WriteLine("Ingrese el nuevo Año de nacimiento");
        int year=Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Ingrese el nuevo Mes de nacimiento");
        byte month=Convert.ToByte(Console.ReadLine());

        Console.WriteLine("Ingrese el nuevo Dia de nacimiento");
        byte day=Convert.ToByte(Console.ReadLine());

        BirthDate=new DateOnly(year,month,day);

    }

    public void EditBreed()
    {
        Console.WriteLine("Ingrese la nueva raza");
        Breed = Console.ReadLine();
    }

    public void EditColor()
    {
        Console.WriteLine("Ingrese el nuevo color");
        Color = Console.ReadLine();
    }

    public void EditWeight()
    {
        Console.WriteLine("Ingrese el nuevo peso en Kg");
        WeightInKg = Convert.ToDouble(Console.ReadLine());
    }
}
