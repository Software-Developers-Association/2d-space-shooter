using UnityEngine;

public abstract class AmmoWeapon : Weapon {
	public int maxAmmo = 100; // this weapon has 100 rounds
	public Bullet bullet; // this is the base class for our projectiles

	private int currentAmmo = 0; // this keeps track of the current amount of ammo.

	private void Awake() {
		this.currentAmmo = this.maxAmmo;
	}

	/// <summary>
	/// Replenishes the amount of ammo based on the amount
	/// specified.
	/// </summary>
	/// <param name="amount"></param>
	public virtual void Replenish(int amount) {
		this.currentAmmo += amount;

		this.currentAmmo = this.currentAmmo > this.maxAmmo ? this.maxAmmo : this.currentAmmo;
	}

	public override void Fire() {
		if(this.currentAmmo - this.cost >= 0) {
			this.currentAmmo -= this.cost;

			// we have a successful fire!
			var clone = GameObject.Instantiate(this.bullet.gameObject, this.muzzle.position, this.muzzle.rotation);

			clone.SetActive(true);
		}
	}
}
