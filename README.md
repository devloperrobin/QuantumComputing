Learning about quantum computing by following the Pluralsight course
"Quantum Computing: Getting Started with Q#"

ProjectDriver is the project that runs the quantum projects. This needs to be a separate project in .NET 6.
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

NOTE: Code may be broken as QDK is not working on apple silicon on which I am writing the code. I'll test it later on windows and fix it again.