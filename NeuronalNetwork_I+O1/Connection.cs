using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuronalNetwork_I_O1
{
    /// <summary>
    /// Eine Verbindung, die sowohl das linke Neuron als auch ein Gewicht besitzt. 
    /// </summary>
    public class Connection
    {
        private Neuron neuron;
        private float weight;

        /// <summary>
        /// Der Konstruktor
        /// </summary>
        /// <param name="neuron">Das Neuron, das sein Aktivierungslevel durch die Verbindung schicken soll</param>
        /// <param name="weight">Das Gewicht der Verbindung</param>
        public Connection(Neuron neuron, float weight)
        {
            Console.WriteLine("Connection.Connection(Neuron: "+neuron.getValue()+" Gewicht: "+weight+") wurde aufgerufen");
            Console.WriteLine();
            this.neuron = neuron;
            this.weight = weight;
        }

        public float getValue()
        {
            Console.WriteLine("Connection.getValue() wurde aufgerufen");
            Console.WriteLine();
            return neuron.getValue() * weight;
        }

        public Neuron getNeuron()
        {
            return neuron;
        }

        public float getWeight()
        {
            return weight;
        }
    }
}
