﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainShipScript : BaseShip {

    Boss1 ScriptdoBoss;
    void Start ()
    {
		base.Initialization(10,15,50,gameObject.GetComponent<Animator>(), gameObject.GetComponent<Rigidbody2D>());
        
	}

   
    

}