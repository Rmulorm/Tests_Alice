using UnityEngine;
using System.Collections;

public class ControlWeapon : MonoBehaviour {

	public bool is_WeaponQuick = false;
	public Object Bullet;
	public float BulletSpeed;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector2 ShootDirection = new Vector2 (Input.GetAxis ("Fire1"), Input.GetAxis("Fire2"));

/*		if (is_WeaponQuick) {
			
			is_Shooting = Input.GetAxis ("Fire1");
		} else {

			is_Shooting = Input.GetButtonDown ("Fire1");
		}
*/
		if (Input.GetButtonDown ("Fire'") || Input.GetButtonDown("Fire2"))
		if (ShootDirection != new Vector2 (0,0)) {

			ShootBullet (ShootDirection);
		}
	}

	void ShootBullet (Vector2 BulletDirection) {

		GameObject ShootedBullet;

		ShootedBullet = (GameObject)Instantiate(Bullet, transform.position, transform.rotation);
		ShootedBullet.SetActive (true);
		ShootedBullet.GetComponent<Rigidbody2D> ().AddForce(BulletSpeed * BulletDirection);
	}
}
