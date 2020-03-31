using UnityEngine;

public abstract class Weapon : MonoBehaviour {
	public int cost = 1;
	public Transform muzzle;

	public virtual void Fire() { }
}
