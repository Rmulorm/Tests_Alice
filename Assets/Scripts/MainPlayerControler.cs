using UnityEngine;
using System.Collections;

public class MainPlayerControler : MonoBehaviour {

	public float f_speed;
	public int i_life;
	public int i_damage;

	private Rigidbody2D r2_body;


	// Use this for initialization
	void Start () {

		r2_body = GetComponent<Rigidbody2D> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void FixedUpdate () {

		float f_MoveHorizontal = Input.GetAxis ("Horizontal");

		float f_MoveVertical = Input.GetAxis ("Vertical");

		Vector2 v2_Move = new Vector2 (f_MoveHorizontal, f_MoveVertical);

		r2_body.AddForce (v2_Move * f_speed);
	}
}
