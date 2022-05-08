namespace QuantumComputing.Superposition {

    open Microsoft.Quantum.Canon;
    open Microsoft.Quantum.Intrinsic;
    
    operation Superposition() : Result {
        mutable state = Zero;
        using(qubit = new Qubit())
        {
            H(qubit);
            set state = M(qubit);

            Reset(qubit);
        }
				return state;
    }
}
