using System;
using Microsoft.Quantum.Simulation.Simulators;

namespace Quantum.Superposition
{
	class Driver
	{
		static void Main(string[] args)
		{
			int ones = 0;
			using (var qsim = new QuantumSimulator())
			{
				for (int i = 0; i < 1000; i++)
				{
					var result = Superposition.Run(qsim).Result;
					if (result == Result.One)
						ones++;
				}
			}
			Console.WriteLine(" One: " + ones);
			Console.WriteLine("Zero: " + (1000 - ones));
			Console.ReadKey();
		}
	}
}