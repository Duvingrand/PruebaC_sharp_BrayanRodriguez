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
    public void Hairdress()
    {

        int option = 0;
        while (option != 1)
        {
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

                    break;
                case 2:
                    Console.WriteLine($"el cabello de {Name} se ha registrado como Corto");
                    CoatType = "Pelo corto";

                    break;
                case 3:
                    Console.WriteLine($"el cabello de {Name} se ha registrado como Mediano");
                    CoatType = "Pelo mediano";

                    break;
                case 4:
                    Console.WriteLine($"el cabello de {Name} se ha registrado como Largo");
                    CoatType = "Pelo largo";

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
        Pelaje: {CoatType}"
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
}
