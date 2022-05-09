namespace Entanglement
{
	open Microsoft.Quantum.Canon;
	open Microsoft.Quantum.Intrinsic;
	
	operation EntanglementOperation() : (Result, Result) {
		mutable qubitOneState = Zero;
		mutable qubitTwoState = Zero;
		
		use (qubitOne, qubitTwo) = (Qubit(), Qubit());
		
		H(qubitOne);
		CNOT(qubitOne, qubitTwo);

		set qubitOneState = M(qubitOne);
		set qubitTwoState = M(qubitTwo);

		Reset(qubitOne);
		Reset(qubitTwo);

		return (qubitOneState, qubitTwoState);
	}
}
