using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crabs : Animals {

public virtual void Start () {
		Pinch();
		
	}
	
	// These are declarations
	void Pinch() {
		print(this.name + " Pinch");
	}

	
}
