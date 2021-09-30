using UnityEngine;
using System.Collections;

public class MovingPlatform : MonoBehaviour {

	public bool movingright = true;
	public float width = 100f;
	private float xmax;
	private float xmin;
	public float speed = 5;

	// Use this for initialization
	void Start () {
		float distance = transform.position.z - Camera.main.transform.position.z;
		Vector3 leftmost = Camera.main.ViewportToWorldPoint(new Vector3(0,0,distance));
		Vector3 rightmost = Camera.main.ViewportToWorldPoint(new Vector3(1,0,distance));
		xmin = leftmost.x;
		xmax = rightmost.x;
		
	}
	
	// Update is called once per frame
	void Update () {
		if(movingright){
			transform.position += Vector3.right * speed * Time.deltaTime;
		}else{
			transform.position += Vector3.left * speed * Time.deltaTime;
		}
		
		float rightMax = transform.position.x + (0.5f * width);
		float leftMax = transform.position.x - (0.5f * width);
		if (leftMax <= xmin || rightMax >= xmax){
			movingright = !movingright;
		}
	}
}
