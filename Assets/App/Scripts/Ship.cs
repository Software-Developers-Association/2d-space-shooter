using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour {
	public float speed = 1.0F; // moves 'speed' units per second... (speed)
	public float rotation = 90.0F; // rotates 'rotation' amount of degrees per second.

	private void Update() {
		float xAxis = Input.GetAxis("Horizontal");
		float yAxis = Input.GetAxis("Vertical");

		// rotate logic...
		Quaternion zRotation = Quaternion.Euler(0.0F, 0.0F, this.rotation * -xAxis * Time.deltaTime);

		this.transform.rotation *= zRotation;

		// move logic....
		Vector3 position = this.transform.position;

		Vector3 forwardDelta = Vector3.up * yAxis * Time.deltaTime * this.speed;

		position += this.transform.rotation * forwardDelta;

		this.transform.position = position;
	}
}
