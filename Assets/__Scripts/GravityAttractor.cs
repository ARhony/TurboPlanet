using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityAttractor : MonoBehaviour {

    public float Gravity = -10;


    public void Attract (Transform Car)
    {
        Vector3 GravityUp = (Car.position - transform.position).normalized;
        Vector3 CarUp = Car.up;

        Car.GetComponent<Rigidbody>().AddForce(CarUp * Gravity);

        Quaternion TargetRotation = Quaternion.FromToRotation(CarUp, GravityUp)* Car.rotation;
        Car.rotation = Quaternion.Slerp(Car.rotation, TargetRotation, 50 * Time.deltaTime);

    }
}
