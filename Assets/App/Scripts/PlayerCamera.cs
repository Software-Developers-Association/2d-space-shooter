using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Camera))]
public class PlayerCamera : MonoBehaviour {
	public Transform target;
	public float speed = 10.0F; // 10 units per second.
	public Vector3 offset = Vector3.zero; // offset realtive to the target's position.

	private void Update() {
		Vector3 position = target.position;

		position.x += offset.x;
		position.y += offset.y;
		position.z += offset.z;

		this.transform.position = Vector3.Lerp(this.transform.position, position, speed * Time.deltaTime);
	}
}
