using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour {

    public float startForce;
    //Component này được add vào từ GetComponent bên trong giao diện
    private Rigidbody2D rigidbody2D;

	// Use this for initialization
	void Start () {
        rigidbody2D = GetComponent<Rigidbody2D>();
        rigidbody2D.velocity = new Vector2(startForce, startForce);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
