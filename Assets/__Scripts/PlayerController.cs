using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float MoveSpeed = 20f;
    public Vector3 MoveDirection;
    private Rigidbody CarRb;
	void Start () {
        CarRb = GetComponent<Rigidbody>();

    }
	

	void Update () {
        MoveDirection = new Vector3(Input.GetAxisRaw("Vertical"), 0, Input.GetAxisRaw("Horizontal")).normalized;
	}

    private void FixedUpdate()
    {
        CarRb.MovePosition(CarRb.position + transform.TransformDirection(MoveDirection) * MoveSpeed * Time.deltaTime);

    }
}
