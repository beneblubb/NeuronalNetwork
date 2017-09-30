using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuronalNetwork_I_O1
{
    /// <summary>
    /// Ein Neuron, das nur einen Wert (Aktivierungslevel) speichern und unverändert wieder zurückgeben kann.
    /// </summary>
    public class InputNeuron : Neuron
    {
        private float value = 0;    

        public override float getValue()
        {
            return value;
        }

        public void setValue(float value)
        {
            this.value = value;
        }
    }
}
