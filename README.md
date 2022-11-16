Learning about quantum computing by following the Pluralsight course
"Quantum Computing: Getting Started with Q#"

ProjectDriver is a .NET 7 project that runs the quantum projects. 
All quantum projects are Q# class libraries.

There is also an option to make runnable Q# projects without .NET driver project, but for now I tried this way first.

Use 
```
dotnet run -- <quantumProjectName> 
```
in the ProjectDriver directory to run a specific quantum project

Use
```
dotnet run -- all
```
in the ProjectDriver directory to run all available projects

Currently available experiments:
- Superposition
- Entanglement
- Teleportation