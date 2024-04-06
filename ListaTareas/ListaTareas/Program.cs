using System;
using System.Collections.Generic;

namespace ListaTareas
{
    class Program
    {
        static List<string> tareas = new List<string>();

        static void Main(string[] args)
        {
            bool salir = false;

            do
            {
                Console.WriteLine("----- MENÚ -----");
                Console.WriteLine("1. Mostrar tareas");
                Console.WriteLine("2. Agregar tarea nueva");
                Console.WriteLine("3. Eliminar tarea");
                Console.WriteLine("4. Salir");
                Console.Write("Por favor seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        MostrarTareas();
                        break;
                    case "2":
                        AgregarTarea();
                        break;
                    case "3":
                        EliminarTarea();
                        break;
                    case "4":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Por favor, seleccione una opción válida.");
                        break;
                }

            } while (!salir);
        }

        static void MostrarTareas()
        {
            Console.WriteLine("----- Tareas -----");
            if (tareas.Count == 0)
            {
                Console.WriteLine("No hay tareas.");
            }
            else
            {
                for (int i = 0; i < tareas.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {tareas[i]}");
                }
            }
        }

        static void AgregarTarea()
        {
            Console.Write("Ingrese la nueva tarea: ");
            string nuevaTarea = Console.ReadLine();
            tareas.Add(nuevaTarea);
            Console.WriteLine("Tarea agregada exitosamente.");
        }

        static void EliminarTarea()
        {
            MostrarTareas();
            if (tareas.Count > 0)
            {
                Console.Write("Ingrese el número de la tarea a eliminar: ");
                int indice;
                if (int.TryParse(Console.ReadLine(), out indice))
                {
                    if (indice > 0 && indice <= tareas.Count)
                    {
                        tareas.RemoveAt(indice - 1);
                        Console.WriteLine("Tarea eliminada exitosamente.");
                    }
                    else
                    {
                        Console.WriteLine("Número de tarea no válido.");
                    }
                }
                else
                {
                    Console.WriteLine("Por favor, ingrese un número válido.");
                }
            }
        }
    }
}
