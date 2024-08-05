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
    public List<Dog>? Dogs { get; set; }
    public List<Cat>? Cats { get; set; }

    public VeterinaryClinic(string name, string address)
    {
        Name=name;
        Address=address;
        Dogs=[];
        Cats=[];
    }

    public void SaveDog(Dog newDog){}
    public void SaveCat(Cat newCat){}
    public void UpdateDog(Dog dog){}
    public void UpdateCat(Cat cat){}
    public void DeleteDog(int id){}
    public void DeleteCat(int id){}
    public void ShowAllPatients(){}
    public void ShowAnimals(string type){}
    public void ShowPatient(int idPatient){}

}
