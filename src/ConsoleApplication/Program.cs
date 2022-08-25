//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            var train = new Train("Test Default");
            train.StartEngines();
            
            int aux = 0;

            /// <summary>
            /// Construct 100 instances of Train
            /// </summary>
            while(aux < 100)
            {
                var newTrain = new Train("Test");
                aux++;
            }
            /// <Observation>
            /// Despues de alrededor de 16000 iteraciones, el metodo destructor libera espacios de memoria,
            /// lo que permite al metodo constructor continuar el proceso
            /// </Observation>

            /// <summary>
            /// Crear t1, t2, t3 y compararlos
            /// </summary>
            var t1 = new Train("Last Train to London");
            var t2 = new Train("Last Train to London");
            var t3 = new Train("Runaway Train");

            if (t1 == t2)
            {
                Console.WriteLine("T1 is T2");
            }
            else
            {
                Console.WriteLine("T1 is not T2");
            }

            if (t2 == t3)
            {
                Console.WriteLine("T2 is T3");
            }
            else
            {
                Console.WriteLine("T2 is not T3");
            }
            /// <Observation>
            /// T1 y T2 tienen atributos de igual valor, pero tienen sus identidades unicas
            /// No hay motivo para creer que T3 es igual que el resto
            /// </Observation>
        }
    }
}