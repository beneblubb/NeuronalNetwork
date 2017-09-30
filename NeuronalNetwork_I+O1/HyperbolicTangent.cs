using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuronalNetwork_I_O1
{
    class HyperbolicTangent : ActivationFunction
    {
        public float Activation(float input)
        {
            float epx = (float)Math.Pow(Math.E, input);
            float enx = (float)Math.Pow(Math.E, -input);

            return (epx - enx) / (epx + enx);
        }
    }
}
