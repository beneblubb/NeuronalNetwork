using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuronalNetwork_I_O1
{
    class Identity : ActivationFunction
    {
        public float Activation(float input)
        {
            return input;
        }
    }
}
