using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_BrayanRodriguez.Models;

public class Dog : Animal
{
    public bool BreedingStatus { get; set; }
    public string? Temperament { get; set; }
    public string? MicrochipNumber { get; set; }
    public string? BarkVolume { get; set; }
    public string? CoatType { get; set; }

    public Dog(string name, int year, byte month, byte day, string breed, string color, double kg, string microchip, string bark) : base(name, year, month, day, breed, color, kg)
    {
        BreedingStatus = false;
        Temperament = "No Asignado Aún";
        MicrochipNumber = microchip;
        BarkVolume = bark;
        CoatType = "No Asignado Aún";
    }

    public void CastrateAnimal()
    {
        if (BreedingStatus == true)
        {
            Console.WriteLine($"{Name} ya está castrado");
        }
        else
        {
            BreedingStatus = true;
            Console.WriteLine($"{Name} ha sido castrado exitosamente");
        }
    }
    //------------------------------------------------------------------------------------------------------
    public void Hairdress()
    {
        if (CoatType == "Sin pelo")
        {
            Console.WriteLine("no se puede peluquear a un perro sin pelo");
        }
        else
        {
            int option = 0;
            while (option != 5)
            {
                Console.Clear();
                Console.WriteLine($"Ingrese el tipo de cabello del perro {Name}:");
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
                        CoatType = "Sin pelo";
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case 2:
                        Console.WriteLine($"el cabello de {Name} se ha registrado como Corto");
                        CoatType = "Pelo corto";
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case 3:
                        Console.WriteLine($"el cabello de {Name} se ha registrado como Mediano");
                        CoatType = "Pelo mediano";
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case 4:
                        Console.WriteLine($"el cabello de {Name} se ha registrado como Largo");
                        CoatType = "Pelo largo";
                        Console.ReadKey();
                        Console.Clear();

                        break;
                    case 5:
                        Console.WriteLine($"Saliendo...");
                        Console.ReadKey();
                        Console.Clear();

                        break;
                }

                if (option != 5)
                {
                    Console.WriteLine("Presione cualquier tecla para volver al menú...");
                    Console.ReadKey();
                }
            }

        }
    }
    //------------------------------------------------------------------------------------------------------
    public override void ShowInformation()
    {
        Console.WriteLine(@$"
        ID: {Id}
        Nombre: {Name}
        Fecha de nacimiento: {BirthDate.Day}/{BirthDate.Month}/{BirthDate.Year}
        Edad: {CalculateAgeInMonths()} meses
        Raza: {Breed}
        Color: {Color}
        Peso: {WeightInKg}.Kg
        Está castrado?: {BreedingStatus}
        Pelaje: {CoatType}
        Temperamento: {Temperament}
        Codigo Microchip: {MicrochipNumber}
        Nivel Ladrido: {BarkVolume}
        "
        );
    }

    public void LetBasicReview()
    {
        BasicReview();
    }
    //------------------------------------------------------------------------------------------------------

    public int HaveId()
    {
        return Id;
    }

    public string HaveName()
    {
        return Name ?? "No registrado";
    }
    //------------------------------------------------------------------------------------------------------

    public void EditName()
    {
        Console.WriteLine("Ingrese el nuevo nombre");
        Name = Console.ReadLine();
    }

    public void EditYear()
    {
        Console.WriteLine("Ingrese el nuevo Año de nacimiento");
        int year = Convert.ToInt16(Console.ReadLine());

        Console.WriteLine("Ingrese el nuevo Mes de nacimiento");
        byte month = Convert.ToByte(Console.ReadLine());

        Console.WriteLine("Ingrese el nuevo Dia de nacimiento");
        byte day = Convert.ToByte(Console.ReadLine());

        BirthDate = new DateOnly(year, month, day);

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

    public void EditTemperament()
    {
        Console.WriteLine($"Ingrese el temperamento actual de {Name}");
        string temp = Console.ReadLine() ?? "";
        if (temp.ToLower() != "timido" || temp.ToLower() != "normal" || temp.ToLower() != "agresivo")
        {
            Console.WriteLine("Las unicas opciones permitidas son 'timido', 'normal' y 'agresivo'");
        }
        else
        {
            Temperament = temp;
        }
    }

    public void EditMicrochipNumber()
    {
        Console.WriteLine($"Ingrese el numero del microchip de {Name}");
        MicrochipNumber = Console.ReadLine();
    }

    public void EditBark()
    {
        Console.WriteLine($"Ingrese el nivel de ladrido de {Name}");
        BarkVolume = Console.ReadLine();
    }

}
