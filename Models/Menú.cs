using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PruebaC_sharp_BrayanRodriguez.Models;

public class Menú
{
    public static void ShowMenu(VeterinaryClinic veterinary)
    {
        int option = 0;

        while (option != 10)
        {
            ManegerApp.ShowHeader();
            Console.WriteLine("Ingrese una de las siguientes opciones");
            Console.WriteLine("1. Agregar Gato");
            Console.WriteLine("2. Agregar Perro");
            Console.WriteLine("3. Eliminar Gato");
            Console.WriteLine("4. Eliminar Perro");
            Console.WriteLine("5. Actualizar Gato");
            Console.WriteLine("6. Actualizar Perro");
            Console.WriteLine("7. Mostrar TODOS los Gatos y Perros");
            Console.WriteLine("8. Mostrar Pacientes");
            Console.WriteLine("9. Buscar un Paciente");
            Console.WriteLine("10. Salir");

            // Leer la opción del usuario
            string input = Console.ReadLine() ?? "";
            bool isNumeric = int.TryParse(input, out option);

            // Verificar si la opción es válida
            if (!isNumeric || option < 1 || option > 10)
            {
                Console.WriteLine("Opción no válida. Por favor, elija una opción entre 1 y 10.");
                Console.WriteLine("Presione cualquier tecla para continuar...");
                Console.ReadKey();
                continue;
            }

            switch (option)
            {

                case 1:
                    ManegerApp.ShowHeader();
                    veterinary.SaveCat(ManegerApp.CreateCat());

                    ManegerApp.ShowFooter();
                    break;

                case 2:
                    ManegerApp.ShowHeader();
                    veterinary.SaveDog(ManegerApp.CreateDog());

                    ManegerApp.ShowFooter();
                    break;

                case 3:
                    ManegerApp.ShowHeader();
                    Console.WriteLine("Ingrese el Id del gato a eliminar");
                    int CatId = Convert.ToInt16(Console.ReadLine());
                    veterinary.DeleteCat(CatId);
                    ManegerApp.ShowFooter();
                    break;

                case 4:
                    ManegerApp.ShowHeader();
                    Console.WriteLine("Ingrese el Id del perro a eliminar");
                    int DogId = Convert.ToInt16(Console.ReadLine());
                    veterinary.DeleteDog(DogId);
                    ManegerApp.ShowFooter();
                    break;

                case 5:
                    ManegerApp.ShowHeader();
                    UpdateCatMenuSelection(veterinary);
                    ManegerApp.ShowFooter();
                    break;
                case 6:
                    ManegerApp.ShowHeader();
                    UpdateDogMenuSelection(veterinary);
                    ManegerApp.ShowFooter();
                    break;

                case 7:
                    ManegerApp.ShowHeader();
                    veterinary.ShowAllPatients();
                    ManegerApp.ShowFooter();
                    break;

                case 8:
                    ManegerApp.ShowHeader();
                    Console.WriteLine("desea ver la lista de 'perros' o 'gatos'?");
                    string type = Console.ReadLine() ?? "";
                    if (type != "perro" && type != "gato")
                    {
                        Console.WriteLine("Eleccion incorrecta, ingrese 'perro' o 'gato'");
                        break;
                    }
                    veterinary.ShowAnimals(type);

                    break;

                case 9:
                    ManegerApp.ShowHeader();
                    Console.WriteLine("Ingrese el Id del paciente a buscar");
                    int idPatient = Convert.ToInt16(Console.ReadLine());
                    veterinary.ShowPatient(idPatient);

                    break;

                case 10:
                    ManegerApp.ShowHeader();
                    Console.WriteLine("Saliendo...");
                    ManegerApp.ShowFooter();
                    break;

            }
            if (option != 10)
            {
                Console.WriteLine("Presione cualquier tecla para volver al menú...");
                Console.ReadKey();
            }

        }
    }
//------------------------------------------------------------------------------------------------------
    private static void UpdateCatMenuSelection(VeterinaryClinic veterinary)
    {
        Console.Write("Ingrese el numero de identificacion del Gato: ");

        int idPatient = Convert.ToInt16(Console.ReadLine());

        var founded = veterinary.Cats.Find(d => d.HaveId() == idPatient);

        if (founded != null)
        {
            bool editar = true;
            while (editar)
            {
                ManegerApp.ShowHeader();
                Console.WriteLine($"Seleccione la propiedad a editar de {founded.HaveName().ToUpper()}");
                Console.WriteLine($"1. Nombre");
                Console.WriteLine($"2. Año de nacimiento");
                Console.WriteLine($"3. Raza");
                Console.WriteLine($"4. Color");
                Console.WriteLine($"5. Peso en Kg");
                Console.WriteLine($"6. Estado de castramiento");
                Console.WriteLine($"7. Largo de pelo");
                Console.WriteLine($"8. Salir...");

                switch (Console.ReadLine())
                {
                    case "1":
                        founded.EditName();
                        break;

                    case "2":
                        founded.EditYear();
                        break;

                    case "3":
                        founded.EditBreed();
                        break;

                    case "4":
                        founded.EditColor();
                        break;

                    case "5":
                        founded.EditWeight();
                        break;

                    case "6":
                        founded.CastrateAnimal();
                        break;

                    case "7":
                        founded.Hairdress();
                        break;

                    case "8":
                        editar = false;
                        break;
                }
            }
        }
        else
        {
            Console.WriteLine($"no se encontró ningun paciente con ID de {idPatient}");
        };
    }


    public static void UpdateDogMenuSelection(VeterinaryClinic veterinary)
    {
        Console.Write("Ingrese el numero de identificacion del Perro: ");

        int idPatient = Convert.ToInt16(Console.ReadLine());

        var founded = veterinary.Dogs.Find(d => d.HaveId() == idPatient);

        if (founded != null)
        {
            bool editar = true;
            while (editar)
            {
                ManegerApp.ShowHeader();
                Console.WriteLine($"Seleccione la propiedad a editar de {founded.HaveName().ToUpper()}");
                Console.WriteLine($"1. Nombre");
                Console.WriteLine($"2. Fecha de nacimiento");
                Console.WriteLine($"3. Raza");
                Console.WriteLine($"4. Color");
                Console.WriteLine($"5. Peso en Kg");
                Console.WriteLine($"6. Estado de castramiento");
                Console.WriteLine($"7. Largo de pelo");
                Console.WriteLine($"8. Codigo Microchip");
                Console.WriteLine($"9. Nivel de ladrido");
                Console.WriteLine($"10. Temperamento");
                Console.WriteLine($"11. Salir...");

                switch (Console.ReadLine())
                {
                    case "1":
                        founded.EditName();
                        break;

                    case "2":
                        founded.EditYear();
                        break;

                    case "3":
                        founded.EditBreed();
                        break;

                    case "4":
                        founded.EditColor();
                        break;

                    case "5":
                        founded.EditWeight();
                        break;

                    case "6":
                        founded.CastrateAnimal();
                        break;

                    case "7":
                        founded.Hairdress();
                        break;

                    case "8":
                        founded.EditMicrochipNumber();
                        break;

                    case "9":
                        founded.EditBark();
                        break;

                    case "10":
                        founded.EditTemperament();
                        break;

                    case "11":
                        editar = false;
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Inténtelo de nuevo.");
                        break;

                }
            }

        }
        else
        {
            Console.WriteLine($"no se encontró ningun paciente con ID de {idPatient}");
        };
    }

    //-----------------------------------------------------------------------------------------------------------------------------


}
