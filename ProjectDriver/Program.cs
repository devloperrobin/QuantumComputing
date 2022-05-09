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
	default:
		Console.WriteLine($"No driver found for '{proj}'");
		break;
}
