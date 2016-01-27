using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public float shipSpeed;
	public float upDownVeloctiy;

	private Vector2 shipVelocity;
	// Use this for initialization
	void Start ()
	{
		shipVelocity = new Vector2 (0, 0);
	}
	
	// Update is called once per frame
	void Update ()
	{
		shipVelocity = new Vector2 ( 
		    Input.GetAxis("Horizontal") * shipSpeed,
			Input.GetAxis("Vertical") * shipSpeed );

		upDownVeloctiy = shipVelocity.y;

		GetComponent<Rigidbody2D> ().velocity = shipVelocity;
	}
}

