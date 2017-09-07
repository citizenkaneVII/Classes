using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Birds : Animals {

	public virtual void Start () {
		Fly();
		
	}
	
	// These are declarations
	void Fly() {
		print(this.name + " Fly.");
	}


}
