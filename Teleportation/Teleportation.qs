namespace Teleportation {
	open Microsoft.Quantum.Canon;
	open Microsoft.Quantum.Intrinsic;

	operation Teleportation (sentMessage : Bool) : Bool {
		mutable receivedMessage = false;
		use register = Qubit[3];
		let message = register[3];
		if(sentMessage)
			X(message)

		let sender = register[1];
		let receiver = register[2];

		H(sender);
		CNOT(sender, receiver);

		CNOT(message, sender);
		H(message);

		let messageState = M(message);
		let senderState = M(sender);

		if(messageState == One)
			Z(receiver);

		if(senderState == One)
			X(receiver);

		if(M(receiver) == One)
			set receivedMessage = true;

		ResetAll(register);

		return receivedMessage;
	}
}
