using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//  My reasoing for this is that Mermaids have mammory glands.


public class Mermaids : Mammals {

public override void Start(){
    base.Start();
    Swim();
    }



void Swim (){
    print(this.name + " Swim");
}


}
