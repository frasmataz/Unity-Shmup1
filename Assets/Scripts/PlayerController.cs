using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour
{
	public float shipSpeed;
	public float upDownVeloctiy;
	
	private Vector2 previousShipVelocity;
	private Vector2 shipVelocity;
	// Use this for initialization
	void Start ()
	{
		shipVelocity = new Vector2 (0, 0);
	}
	
	// Update is called once per frame
	void Update ()
	{
		previousShipVelocity = shipVelocity;
		shipVelocity = new Vector2 ( 
		    Input.GetAxis("Horizontal") * shipSpeed,
			Input.GetAxis("Vertical") * shipSpeed );

		upDownVeloctiy = shipVelocity.y;

		if (shipVelocity.y > 0 && shipVelocity.y > previousShipVelocity.y) {
			GetComponent<Animator> ().SetBool ("Goingup", true);
			GetComponent<Animator> ().SetBool ("Goingdown", false);
		} else if (shipVelocity.y > 0 && shipVelocity.y < previousShipVelocity.y)
			GetComponent<Animator>().SetBool("Goingup",false);

		if (shipVelocity.y < 0 && shipVelocity.y < previousShipVelocity.y) {
			GetComponent<Animator> ().SetBool ("Goingdown", true);
			GetComponent<Animator> ().SetBool ("Goingup", false);
		} else if (shipVelocity.y < 0 && shipVelocity.y > previousShipVelocity.y)
			GetComponent<Animator>().SetBool("Goingdown",false);

		GetComponent<Rigidbody2D> ().velocity = shipVelocity;
	}
}

