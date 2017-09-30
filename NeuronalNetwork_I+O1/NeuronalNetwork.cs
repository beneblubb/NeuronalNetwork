using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuronalNetwork_I_O1
{
    /// <summary>
    /// Das neuronale Netzwerk an sich. Es verfügt über je eine Liste mit Neuronen
    /// für jede Schicht des Netzwerks
    /// </summary>
    public class NeuronalNetwork
    {
        private List<InputNeuron> inputNeurons = new List<InputNeuron>();       //Liste aus InputNeuronen
        private List<WorkingNeuron> outputNeurons = new List<WorkingNeuron>();  //Liste aus WorkingNeuronen
        private List<WorkingNeuron> hiddenNeurons = new List<WorkingNeuron>();  //Ebenfalls WorkingNeuronen

        public InputNeuron createNewInput()
        {
            Console.WriteLine("Neuronal Network.createNewInput() wurde aufgerufen");
            InputNeuron iN = new InputNeuron();
            inputNeurons.Add(iN);
            return iN;
        }

        public WorkingNeuron createNewOutput()
        {
            Console.WriteLine("NeuronalNetwork.createNewOutput() wurde aufgerufen");
            WorkingNeuron oN = new WorkingNeuron();
            outputNeurons.Add(oN);
            return oN;
        }

        public WorkingNeuron createNewHidden()
        {
            Console.WriteLine("Neuronal Network.createNewHidden() wurde aufgerufen");
            WorkingNeuron hN = new WorkingNeuron();
            hiddenNeurons.Add(hN);
            return hN;
        }

        /// <summary>
        /// Vollvermascht die erste mit der zweiten und die zweite mit der dritten Ebene. 
        /// Als Parameter werden zwei Listen mit den Gewichten der Verbindungen übergeben. 
        /// Von oben nach unten VOM "RECHTEN" NEURON AUS GESEHEN
        /// </summary>
        /// <param name="weightsHI">Gewichte Hidden/Inputschicht</param>
        /// <param name="weightsOH">Gewichte Output/Hiddenschicht</param>
        public void createFullMesh(float[] weightsHI, float[] weightsOH )
        {
            Console.WriteLine("NeuronalNetwork.createFullMesh(Gewichte HI: "+weightsHI+"; Gewichte OH: "+weightsOH+") wurde aufgerufen");
            Console.WriteLine();
            int index = 0;

            foreach (WorkingNeuron hN in hiddenNeurons) 
            {
                foreach (InputNeuron iN in inputNeurons)
                {
                    hN.addConnection(new Connection(iN, weightsHI[index++]));
                }
            }

            index = 0;

            foreach (WorkingNeuron oN in outputNeurons)
            {
                foreach (WorkingNeuron hN in hiddenNeurons)
                {
                    oN.addConnection(new Connection(hN, weightsOH[index++]));
                }
            }
        }
    }
}
