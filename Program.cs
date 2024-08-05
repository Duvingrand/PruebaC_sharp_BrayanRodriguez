
using PruebaC_sharp_BrayanRodriguez.Models;

var veterinaria1=new VeterinaryClinic("Veterinaria Riwi","Calle #4");

veterinaria1.SaveDog(new Dog("Cucho",2020,1,14,"chiguagua","cafe",1,"Cd-25774","bajo"));
veterinaria1.SaveDog(new Dog("Chucho",2018,10,24,"chiguagua","cafe",2,"Cd-33274","bajo"));
veterinaria1.SaveDog(new Dog("Rex",2021,11,30,"pitbull","blanco",20,"Cd-25543","alto"));
veterinaria1.SaveDog(new Dog("Firulais",2015,5,4,"criollo","blanco",22,"Cd-25876","medio"));
veterinaria1.SaveDog(new Dog("Zeus",2022,4,9,"doberman","negro",45,"Cd-25228","alto"));

veterinaria1.SaveCat(new Cat("mechas",2014,8,9,"persa","blanco",4));
veterinaria1.SaveCat(new Cat("chimi",2020,11,30,"criollo","blanco",6));
veterinaria1.SaveCat(new Cat("mimo",2014,8,9,"esfinge","gris",3));
veterinaria1.SaveCat(new Cat("chanda",2014,8,9,"siames","negro y blanco",5));
veterinaria1.SaveCat(new Cat("nino",2014,8,9,"ragdoll","negro y blanco",3));

Menú.ShowMenu(veterinaria1);