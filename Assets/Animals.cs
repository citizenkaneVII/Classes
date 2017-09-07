using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//  The Animals class comes from MonoBehavior whichis what Unity runs on.  From here, we create other sub
//  classes that will run off of this Animals script.  That means they will perform the methods we've
//  created in the public virtual void.
public class Animals : MonoBehaviour {

	// These are used to call
	public virtual void Start () {
		Die();
		Eat();
		Sleep();
	}
	
	// These are declarations
	void Die() {
		print(this.name + "Dies");
	}

	void Eat() {
		print(this.name + " Eats");
	}
	void Sleep() {
		print(this.name + " Sleep");
	}
}

