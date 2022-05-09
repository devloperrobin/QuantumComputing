using Entanglement;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace ProjectDriver
{
	internal class EntanglementDriver
	{
		public static async Task Run()
		{
			var ones = 0;
			var equal = 0;
			using (var qsim = new QuantumSimulator())
			{
				for (var i = 0; i < 1000; i++)
				{
					var (qubitOne, qubitTwo) = await EntanglementOperation.Run(qsim);
					
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