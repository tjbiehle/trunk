using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	public float speed;
	Vector3 movement = new Vector3 (-100, 0, 0);
	Vector3 translate = new Vector3(0,0,0);
	void Start()
	{
	//	float forward = 10;
		movement = new Vector3 (0, 0, -100);
		rigidbody.AddForce (movement * speed * Time.deltaTime);
	}
	void OnTriggerEnter(Collider other)
	{
		/****************************Components*************************/
		if (other.gameObject.tag == "Resistor") {
			movement = new Vector3 (600, 0, 0);
			rigidbody.AddForce (movement * speed * Time.deltaTime);

				}
		if (other.gameObject.tag == "Inductor") {
			movement = new Vector3 (-200, 0, 0);
			rigidbody.AddForce (movement * speed * Time.deltaTime);
		}
		if (other.gameObject.tag == "Capacitor(Front)") {
			translate = new Vector3(10,0,0);
			rigidbody.MovePosition (rigidbody.position + translate);
		}
		if (other.gameObject.tag == "Capacitor(Back)") {

			translate = new Vector3(-10,0,0);
			rigidbody.MovePosition (rigidbody.position + translate);
		}
		/******************Invisible Triggers*********************/
		if (other.gameObject.tag == "ReE")
		{
			movement = new Vector3 (00, 0, -200);
			rigidbody.AddForce (movement*speed * Time.deltaTime);
		}
		if (other.gameObject.tag == "ReW")
		{
			movement = new Vector3 (-100, 0, 100);
			rigidbody.AddForce (movement*speed * Time.deltaTime);
		}
		if (other.gameObject.tag == "ReS")
		{
			movement = new Vector3 (-100, 0, -100);
			rigidbody.AddForce (movement*speed * Time.deltaTime);
		}
		if (other.gameObject.tag == "ReN")
		{
			movement = new Vector3 (100, 0, 100);
			rigidbody.AddForce (movement*speed * Time.deltaTime);
		}
		if (other.gameObject.tag == "Stop")
		{
			movement = new Vector3 (100, 0, 0);
			rigidbody.AddForce (movement*speed * Time.deltaTime);
		}
	}


	void FixedUpdate()
	{
		/*
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 movement = new Vector3 (moveHorizontal, 0, moveVertical);

		rigidbody.AddForce (movement * speed * Time.deltaTime);
		*/
		}

}
