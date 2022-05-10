using ProjectDriver;

var proj = Environment.GetCommandLineArgs()[1];
switch (proj?.ToLowerInvariant())
{
	case "superposition":
		await SuperpositionDriver.Run();
		break;
	case "entanglement":
		await EntanglementDriver.Run();
		break;
	case "teleportation":
		await TeleportationDriver.Run();
		break;
	case "all":
		await SuperpositionDriver.Run();
		await EntanglementDriver.Run();
		await TeleportationDriver.Run();
		break;
	default:
		Console.WriteLine($"No driver found for '{proj}'");
		break;
}
