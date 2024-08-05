using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_BrayanRodriguez.Models;

    public abstract class Animal
    {
        private static int IdCounter=0;
        protected int Id { get; set; }
        protected string? Name { get; set; }
        protected DateOnly BirthDate { get; set; }
        protected string? Breed { get; set; }
        protected string? Color { get; set; }
        protected double WeightInKg { get; set; }

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
            Console.WriteLine(@$"{Id}
            Nombre: {Name}
            Raza: {Breed}
            Edad: {CalculateAgeInMonths()} meses
            Peso: {WeightInKg}.Kg
            ");
        }
        protected int CalculateAgeInMonths(){
            return (BirthDate.Year*12)+BirthDate.Month;
        }
        
    }
