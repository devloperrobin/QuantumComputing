using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using Teleportation;

namespace ProjectDriver
{
	internal class TeleportationDriver
	{
		public static async Task Run()
		{
			var trues = 0;
			var equal = 0;
			var random = new Random();
			using (var qsim = new QuantumSimulator())
			{
				for (var i = 0; i < 1000; i++)
				{
					var sentMessage = random.Next(2) == 0;
					var receivedMessage = await Teleportation.Run(qsim);
					if (receivedMessage)
						trues++;
					if (receivedMessage == sentMessage)
						equal++;
				}
			}
			Console.WriteLine("Teleportation result:");
			Console.WriteLine($" True: {trues}");
			Console.WriteLine($"False: {1000-trues}");
			Console.WriteLine($"Equal: {equal}");
		}
	}
}