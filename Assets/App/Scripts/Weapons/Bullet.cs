using UnityEngine;

public class Bullet : MonoBehaviour {
	public float speed = 10.0F; // this bullet moves at 10 units per second...

	protected virtual void Update() {
		var position = this.transform.position;

		position += this.transform.up * this.speed * Time.deltaTime;

		this.transform.position = position;
	}
}
