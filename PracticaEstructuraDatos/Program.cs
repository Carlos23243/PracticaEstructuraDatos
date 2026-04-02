using System;
using System.IO;
using System.Diagnostics;

namespace PracticaEstructuraDatos
{
    // Clase Nodo para el Árbol Binario
    class Nodo
    {
        public int Valor;
        // El signo '?' permite que estas variables sean nulas legalmente
        public Nodo? Izquierdo;
        public Nodo? Derecho;

        public Nodo(int item)
        {
            Valor = item;
            Izquierdo = null;
            Derecho = null;
        }
    }

    class ArbolBinario
    {
        // Raiz también puede ser nula al inicio
        public Nodo? Raiz;

        public void Insertar(int valor)
        {
            Raiz = InsertarRec(Raiz, valor);
        }

        private Nodo InsertarRec(Nodo? raiz, int valor)
        {
            if (raiz == null) return new Nodo(valor);

            if (valor < raiz.Valor)
                raiz.Izquierdo = InsertarRec(raiz.Izquierdo, valor);
            else if (valor > raiz.Valor)
                raiz.Derecho = InsertarRec(raiz.Derecho, valor);

            return raiz;
        }

        // Reportería: Visualización por consola
        public void MostrarInorden(Nodo? nodo)
        {
            if (nodo != null)
            {
                MostrarInorden(nodo.Izquierdo);
                Console.Write($"{nodo.Valor} ");
                MostrarInorden(nodo.Derecho);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ArbolBinario arbol = new ArbolBinario();
            string rutaArchivo = "datos_arbol.txt";

            try
            {
                // Crear archivo de ejemplo si no existe
                if (!File.Exists(rutaArchivo))
                {
                    File.WriteAllText(rutaArchivo, "50, 30, 70, 20, 40, 60, 80");
                }

                string contenido = File.ReadAllText(rutaArchivo);
                string[] valores = contenido.Split(',');

                Stopwatch sw = new Stopwatch();
                sw.Start();

                foreach (var v in valores)
                {
                    if (int.TryParse(v.Trim(), out int numero))
                    {
                        arbol.Insertar(numero);
                    }
                }

                sw.Stop();

                Console.WriteLine("=== REPORTE DE ESTRUCTURA DE DATOS ===");
                Console.WriteLine("Elementos en el Árbol (Inorden):");
                arbol.MostrarInorden(arbol.Raiz);
                
                Console.WriteLine("\n\n=== ANÁLISIS TÉCNICO ===");
                Console.WriteLine($"Tiempo de ejecución: {sw.Elapsed.TotalMilliseconds} ms");
                Console.WriteLine("Estructura utilizada: Árbol Binario de Búsqueda (BST)");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error detectado: {ex.Message}");
            }

            Console.WriteLine("\nPresione cualquier tecla para finalizar...");
            Console.ReadKey();
        }
    }
}