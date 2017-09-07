using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//  Mammalls is a subclass of animals, like Crabs and Birds.  Unlike those two, this will
//  break down into further subclasses, all of which will be a mammal.  In addition to the
//  methods we made in Animals, we can also add extra methods that will only applie to the
//  rest of the subclasses that belong in the mammal class.

public class Mammals : Animals {


public override void  Start(){
    base.Start();
    liveBirth();

}

void liveBirth () {
    print(this.name + " Live births");
}



}
