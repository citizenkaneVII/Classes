using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Humans : Mammals {

public virtual void Start () {
		Facebook();
		
	}
	
	// These are declarations
	void Facebook() {
		print(this.name + " Facebook.");
	}


}
