using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_BrayanRodriguez.Models;

    public abstract class Animal
    {
        private static int IdCounter=0;
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateOnly BirthDate { get; set; }
        public string? Breed { get; set; }
        public string? Color { get; set; }
        public double WeightInKg { get; set; }

        public Animal(string name, int year, byte month, byte day, string breed, string color, double kg)
        {
            IdCounter++;
            Id=IdCounter;
            Name=name;
            BirthDate = new DateOnly(year, month, day);
            Breed=breed;
            Color=color;
            WeightInKg=kg;
        }

        public abstract void ShowInformation();

        protected void BasicReview(){
            
        }
        protected int CalculateAgeInMonths(){
            return (BirthDate.Year*12)+BirthDate.Month;
        }
        
    }
