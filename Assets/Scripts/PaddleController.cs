using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour {

    public float speed;
    public float direction;
    public float adjustSpeed;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + (speed * Time.deltaTime),transform.position.z);
            direction = 1;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - (speed * Time.deltaTime), transform.position.z);
            direction = -1;
        }
        else
        {
            direction = 0;
        }
    }
    //Hướng đi của Ball sau khi va chạm. Vì mặt định mỗi lần va chạm điều đi theo một hướng và một tọa độ nên dễ dàng biết hướng đi
    private void OnCollisionExit2D(Collision2D collision)
    {
        collision.rigidbody.velocity = new Vector2(collision.rigidbody.velocity.x*1.1f, collision.rigidbody.velocity.y + (direction* adjustSpeed));
        Debug.Log(collision.rigidbody.velocity);
    }
}
