using System;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using QuantumComputing.Entanglement;

namespace QuantumComputing.ProjectDriver
{
	internal class EntanglementDriver
	{
		public static async Task Run()
		{
			int ones = 0;
			int equal = 0;
			using (var qsim = new QuantumSimulator())
			{
				for (int i = 0; i < 1000; i++)
				{
					var (qubitOne, qubitTwo) = await Entanglement.Run(qsim);
					
					if (qubitOne == Result.One)
						ones++;

					if(qubitOne == qubitTwo)
						equal++;
				}
			}
			Console.WriteLine($"  One: {ones}");
			Console.WriteLine($" Zero: {1000 - ones}");
			Console.WriteLine($"Equal: {equal/1000*100}%");
		}
	}
}