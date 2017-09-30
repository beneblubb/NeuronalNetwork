using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuronalNetwork_I_O1
{
    /// <summary>
    /// Ein Neuron, das eine Liste mit den eingehenden Connections hat und
    /// aus diesen sowohl seinen Netzinput (nicht über Funktion auslesbar) als auch 
    /// seinen Aktivierungslevel berechnet.
    /// </summary>
    public class WorkingNeuron : Neuron
    {
        private List<Connection> connections = new List<Connection>();
        private ActivationFunction activationFunction = new Sigmoid();
        private float value;

        public override float getValue()
        {
            value = 0;

            Console.WriteLine("WorkingNeuron.getValue() wurde aufgerufen");

            foreach (Connection c in connections)
            {
                Console.WriteLine("Aktivierungslevel: "+c.getNeuron().getValue()+" Gewicht: "+c.getWeight()+" Signalstärke: " + c.getValue());
                value += c.getValue();
            }
            Console.WriteLine();

            return activationFunction.Activation(value);
        }

        ///<summary>
        ///Ruft die Funktion connections.Add auf
        ///</summary>
        ///<param name="c">Die Verbindung, die hinzugefügt werden soll</param>
        public void addConnection(Connection c)
        {
            Console.WriteLine("WorkingNeuron.addConnection(ALvlNeuron: "+c.getNeuron().getValue()+" Gewicht: "+c.getWeight()+") wurde aufgerufen");
            Console.WriteLine();
            connections.Add(c);
        }
    }
}
