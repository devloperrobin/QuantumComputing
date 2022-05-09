using System;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using QuantumComputing.Superposition;

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
Console.WriteLine(" One: " + ones);
Console.WriteLine("Zero: " + (1000 - ones));
