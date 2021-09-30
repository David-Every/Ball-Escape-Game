using UnityEngine;
using System.Collections;

public class Char : MonoBehaviour {
	public float speed = 0.5f;
	public float JumpSpeed = 1.5f;
	private bool grounded = true;
	private bool hasJumped = false;

	float xmin;
	float xmax;

	void Start () {
	
		float distance = transform.position.z - Camera.main.transform.position.z;
		Vector3 leftmost = Camera.main.ViewportToWorldPoint(new Vector3(0,0,distance));
		Vector3 rightmost = Camera.main.ViewportToWorldPoint(new Vector3(1,0,distance));
		xmin = leftmost.x;
		xmax = rightmost.x;
		
	}
	
	void Update () {
	
	if (Input.GetKey(KeyCode.A)){
		transform.position += Vector3.left * speed * Time.deltaTime;
	}else if (Input.GetKey(KeyCode.D)){
		transform.position += Vector3.right * speed * Time.deltaTime;
		
		}if (!grounded && rigidbody2D.velocity.y == 0){
			grounded = true;
		}
		
		if (Input.GetKeyDown(KeyCode.Space) && grounded == true) {
			hasJumped = true;
		}
	
	float newX = Mathf.Clamp(transform.position.x, xmin, xmax);
	transform.position = new Vector3 (newX, transform.position.y, transform.position.z);
	
		}
	void FixedUpdate (){
		if (hasJumped){
			rigidbody2D.AddForce(Vector3.up * JumpSpeed * Time.deltaTime);
			grounded = false;
			hasJumped = false;
			}
		}
		
	}
