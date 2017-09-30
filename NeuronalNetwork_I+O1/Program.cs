using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuronalNetwork_I_O1
{
    class Program
    {
        static void Main(string[] args)

        {
            NeuronalNetwork nn = new NeuronalNetwork();

            InputNeuron i1 = nn.createNewInput();
            InputNeuron i2 = nn.createNewInput();

            i1.setValue(1);
            i2.setValue(0.5f);

            WorkingNeuron h1 = nn.createNewHidden();
            WorkingNeuron h2 = nn.createNewHidden();

            WorkingNeuron o1 = nn.createNewOutput();
            WorkingNeuron o2 = nn.createNewOutput();

            nn.createFullMesh(new float[] { 0.6f, 0.8f, 0.7f, 0.9f}, new float[] { 1.5f, -3f, 1.7f, 2f});


            Console.WriteLine("Output 1: "+o1.getValue() + " Output 2: " + o2.getValue());
            Console.ReadLine();
        }
    }
}
