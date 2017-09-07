using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//  My reasoing for this is that Mermaids have mammory glands.
//  They also have hair.  I'll admit that I don't know if they give
//  live birth or lay eggs.  But they sill have mammory glands,
//  So their mammals!


public class Mermaids : Mammals {

public override void Start(){
    base.Start();
    Swim();
    }



void Swim (){
    print(this.name + " Swim");
}


}
