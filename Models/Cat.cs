using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_BrayanRodriguez.Models;

public class Cat
{
    public bool BreedingStatus { get; set; }
    public string? FurLength { get; set; }

    public Cat(bool breed, string fur)
    {
        BreedingStatus=breed;
        FurLength=fur;
    }

    public void CastrateAnimal(){}
    public void Hairdress(){}



}
