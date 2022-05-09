using System;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using QuantumComputing.Superposition;

namespace QuantumComputing.ProjectDriver
{
	internal class SuperpositionDriver
	{
		public static async Task Run()
		{
			int ones = 0;
			using (var qsim = new QuantumSimulator())
			{
				for (int i = 0; i < 1000; i++)
				{
					var result = await Superposition.Run(qsim);
					if (result == Result.One)
						ones++;
				}
			}
			Console.WriteLine($"  One: {ones}");
			Console.WriteLine($" Zero: {1000 - ones}");
		}
	}
}