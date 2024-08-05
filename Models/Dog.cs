using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_BrayanRodriguez.Models;

public class Dog
{
    public bool BreedingStatus { get; set; }
    public string? Temperament { get; set; }
    public string? MicrochipNumber { get; set; }
    public string? BarkVolume { get; set; }
    public string? CoatType { get; set; }

    public Dog(bool breed, string temp, string microchip, string bark, string coat)
    {
        BreedingStatus=breed;
        Temperament=temp;
        MicrochipNumber=microchip;
        BarkVolume=bark;
        CoatType=coat;
    }

    public void CastrateAnimal(){}
    public void Hairdress(){}

}
