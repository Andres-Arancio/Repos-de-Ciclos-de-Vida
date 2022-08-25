//--------------------------------------------------------------------------------
// <copyright file="Train.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;

namespace ClassLibrary
{
    /// <summary>
    /// Esta clase representa un tren muy básico.
    /// </summary>
    public class Train
    {
        /// <summary>
        /// Obtiene un valor que indica si las maquinas del tren han sido encendidas o no.
        /// </summary>
        /// <value><c>true</c> si las máquinas fueron encendidas, <c>false</c> en caso contrario.</value>
        public bool IsEngineStarted { get; private set; }

        /// <summary>
        /// Obtiene cantidad de instancias "Tren" creadas
        /// </summary>
        private static int count {get; set;}

        /// <summary>
        /// Obtiene un identificador para cada instancia de "Tren"
        /// </summary>
        private string name {get; set;}

        /// <summary>
        /// Enciende las máquinas del tren.
        /// </summary>
        /// <returns>
        /// <c>true</c> si las máquinas pueden ser encendidas, <c>false</c> en caso contrario.
        /// </returns>
        public bool StartEngines()
        {
            if (this.IsEngineStarted)
            {
                Console.Write("The engines are already running");
                return false;
            }

            this.IsEngineStarted = true;
            Console.Write("Engines on");
            return true;
        }

        /// <summary>
        /// Detiene las máquinas del tren.
        /// </summary>
        /// <returns>
        /// <c>true</c> si las máquinas pueden ser detenidas, <c>false</c> en caso contrario.
        /// </returns>
        public bool StopEngines()
        {
            if (this.IsEngineStarted)
            {
                this.IsEngineStarted = false;
                Console.Write("Engines off");
                return true;
            }

            Console.Write("The engines are already stopped");
            return this.IsEngineStarted;
        }

        /// <summary>
        /// Crea un nuevo tren
        /// </summary>
        /// <returns>
        /// Tren
        /// </returns>
        public Train(string constructname)
        {
            this.name = constructname;
            count++;
            Console.WriteLine($"Trains available: {count}");
        }

        /// <summary>
        /// Controla la destruccion de trenes
        /// </summary>
        /// <returns>
        /// void
        /// </returns>
        ~Train()
        {
            count--;
            Console.WriteLine("Train destroyed");
        }
    }
}