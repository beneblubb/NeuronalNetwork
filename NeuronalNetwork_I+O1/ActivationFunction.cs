using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuronalNetwork_I_O1
{
    /// <summary>
    /// Die Vorlage für die verschiedenen Aktivierungsfunktionen. 
    /// </summary>
    public interface ActivationFunction
    {
        float Activation(float input);
    }
}
