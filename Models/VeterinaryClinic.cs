using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace PruebaC_sharp_BrayanRodriguez.Models;

public class VeterinaryClinic
{
    public string? Name { get; set; }
    public string? Address { get; set; }
    public List<Dog> Dogs { get; set; }
    public List<Cat> Cats { get; set; }

    public VeterinaryClinic(string name, string address)
    {
        Name = name;
        Address = address;
        Dogs = new List<Dog>();
        Cats = new List<Cat>();
    }
    //--------------------------------------------------------------------------------------------------------

    public void SaveDog(Dog newDog)
    {
        Dogs.Add(newDog);
    }
    public void SaveCat(Cat newCat)
    {
        Cats.Add(newCat);
    }
    //--------------------------------------------------------------------------------------------------------
    public void UpdateDog(Dog dog) { }
    public void UpdateCat(Cat cat) { }
    //--------------------------------------------------------------------------------------------------------
    public void DeleteDog(int id)
    {
        ManegerApp.ShowHeader();
        var deleteableDog = Dogs.Find(d => d.Id == id);

        if (deleteableDog != null)
        {
            Dogs.Remove(deleteableDog);
            Console.WriteLine("se ha eliminado correctamente");

        }
        else
        {
            Console.WriteLine($"no se encontró ningun perro con ID de {id}");
        }
        ManegerApp.ShowFooter();
    }
    public void DeleteCat(int id)
    {
        ManegerApp.ShowHeader();
        var deleteableCat = Cats.Find(d => d.Id == id);

        if (deleteableCat != null)
        {
            Cats.Remove(deleteableCat);
            Console.WriteLine("se ha eliminado correctamente");

        }
        else
        {
            Console.WriteLine($"no se encontró ningun gato con ID de {id}");
        }
        ManegerApp.ShowFooter();
    }
    //--------------------------------------------------------------------------------------------------------
    public void ShowAllPatients()
    {
        ManegerApp.ShowHeader();
        Console.WriteLine("·····    GATOS   ·····");
        foreach (var i in Cats)
        {
            ManegerApp.ShowSeparator();
            i.ShowInformation();
            ManegerApp.ShowSeparator();
        }

        Console.WriteLine("·····    PERROS   ·····");
        foreach (var i in Dogs)
        {
            ManegerApp.ShowSeparator();
            i.ShowInformation();
            ManegerApp.ShowSeparator();
        }
        ManegerApp.ShowFooter();

    }
    public void ShowAnimals(string type)
    {

        if (type == "perro")
        {
            ManegerApp.ShowHeader();
            foreach (var i in Dogs)
            {
                ManegerApp.ShowSeparator();
                i.ShowInformation();
                ManegerApp.ShowSeparator();
            }
            ManegerApp.ShowFooter();

        }
        else if (type == "gato")
        {

            ManegerApp.ShowHeader();
            foreach (var i in Cats)
            {
                ManegerApp.ShowSeparator();
                i.ShowInformation();
                ManegerApp.ShowSeparator();
            }
            ManegerApp.ShowFooter();

        }
    }


    public void ShowPatient(int idPatient)
    {

        Console.WriteLine($"Desea buscar al gato o al perro de ID {idPatient}?");
        string option = Console.ReadLine() ?? "";

        if (option == "perro")
        {
            var founded = Dogs.Find(d => d.Id == idPatient);
            if (founded != null)
            {
                founded.ShowInformation();
            }
            else
            {
                Console.WriteLine($"no se encontró ningun perro con ID de {idPatient}");
            };

        }
        else if (option == "gato")
        {
            var founded = Cats.Find(d => d.Id == idPatient);
            if (founded != null)
            {
                founded.ShowInformation();
            }
            else
            {
                Console.WriteLine($"no se encontró ningun gato con ID de {idPatient}");
            };

        }
        else
        {
            Console.WriteLine("Opción invalida, ingrese perro o gato");
        }
    }
    //--------------------------------------------------------------------------------------------------------

}
