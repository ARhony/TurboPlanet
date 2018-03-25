using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityBody : MonoBehaviour {

    private Transform CarPlayer;
    public GravityAttractor Attractor;


    void Start () {

        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;
        GetComponent<Rigidbody>().useGravity = false;

        CarPlayer = transform;
        
	}

	void Update () {
        Attractor.Attract(CarPlayer);
	}
}
