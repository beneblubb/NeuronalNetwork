using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuronalNetwork_I_O1
{
    /// <summary>
    /// Schickt einen Wert durch die Sigmoidfunktion. Momentan enthält er eine Reihe von Ausgaben,
    /// die noch darauf warten nachvollzogen zu werden 
    /// ---DANI DEINE AUFGABE---
    /// </summary>
    class Sigmoid : ActivationFunction
    {
        public float Activation(float input)
        {
            Console.WriteLine("Sigmoid.Activation(Input: "+input+") wurde aufgerufen");
            Console.WriteLine("Netzinput: " + input);
            Console.WriteLine("Aktivierungslevel: " + 1f / (1f + Math.Pow(Math.E, -input)));
            Console.WriteLine();
            return (float)(1f / (1f + Math.Pow(Math.E, -input)));
        }
    }
}
