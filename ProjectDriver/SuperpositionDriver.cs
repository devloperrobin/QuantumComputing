using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using Superposition;

namespace ProjectDriver
{
	internal class SuperpositionDriver
	{
		public static async Task Run()
		{
			var ones = 0;
			using (var qsim = new QuantumSimulator())
			{
				for (var i = 0; i < 1000; i++)
				{
					var result = await SuperpositionOperation.Run(qsim);
					if (result == Result.One)
						ones++;
				}
			}
			Console.WriteLine($"  One: {ones}");
			Console.WriteLine($" Zero: {1000 - ones}");
		}
	}
}