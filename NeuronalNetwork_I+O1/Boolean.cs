using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuronalNetwork_I_O1
{
    class Boolean : ActivationFunction
    {
        public float Activation(float input)
        {
            if (input < 0) return 0;
            else return 1;
        }
    }
}
