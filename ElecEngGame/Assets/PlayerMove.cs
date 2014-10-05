using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {
	public float speed;
	Vector3 movement = new Vector3 (0, 0, 100);
	Vector3 translate = new Vector3(0,0,0);
	void Start()
	{
		//	float forward = 10;
//		movement = new Vector3 (00, 0, 100);
//		rigidbody.AddForce (movement * speed * Time.deltaTime);
	}
	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject.tag == "RN_ETrig") {
			movement = new Vector3 (0, 0, 50);
			rigidbody.AddForce (movement * speed * Time.deltaTime);
		}
		if (other.gameObject.tag == "RN_WTrig") {
			movement = new Vector3 (50, 0, 0);
			rigidbody.AddForce (movement * speed * Time.deltaTime);
		}
		if (other.gameObject.tag == "RW_NTrig") {
			movement = new Vector3 (-50, 0, 0);
			rigidbody.AddForce (movement * speed * Time.deltaTime);
		}
		if (other.gameObject.tag == "RE_NTrig") {
			movement = new Vector3 (0, 0, -50);
			transform.position = transform.position + translate;
		}

		if (other.gameObject.tag == "CN_ETrig") {
			translate = new Vector3 (0, 0, 6);
			transform.position = transform.position + translate;
		}
		if (other.gameObject.tag == "CN_WTrig") {
			translate = new Vector3 (5, 0, 0);
			transform.position = transform.position + translate;
		}
		if (other.gameObject.tag == "CW_NTrig") {
			translate = new Vector3 (-5, 0, 0);
			transform.position = transform.position + translate;
		}
		if (other.gameObject.tag == "CE_NTrig") {
			translate = new Vector3 (0, 0, -6);
			transform.position = transform.position + translate;
		}

		if (other.gameObject.tag == "IN_ETrig") {
			movement = new Vector3 (0, 0, 50);
			rigidbody.AddForce (movement * speed * Time.deltaTime);
		}
		if (other.gameObject.tag == "IN_WTrig") {
			movement = new Vector3 (50, 0, 0);
			rigidbody.AddForce (movement * speed * Time.deltaTime);
		}
		if (other.gameObject.tag == "IW_NTrig") {
			movement = new Vector3 (-50, 0, 0);
			rigidbody.AddForce (movement * speed * Time.deltaTime);
		}
		if (other.gameObject.tag == "IE_NTrig") {
			movement = new Vector3 (0, 0, -50);
			rigidbody.AddForce (movement * speed * Time.deltaTime);
		}



		if(other.gameObject.tag == "STOP")
		{
			movement = new Vector3 (-100, 0, 0);
			rigidbody.AddForce (movement * speed * Time.deltaTime);
		}
		if(other.gameObject.tag == "S_E")
		{
			movement = new Vector3 (-100, 0, -100);
			rigidbody.AddForce (movement * speed * Time.deltaTime);
		}
		if(other.gameObject.tag == "E_N")
		{
			movement = new Vector3 (100, 0, -100);
			rigidbody.AddForce (movement * speed * Time.deltaTime);
		}
		if(other.gameObject.tag == "N_W")
		{
			movement = new Vector3 (100, 0, 100);
			rigidbody.AddForce (movement * speed * Time.deltaTime);
		}
		if(other.gameObject.tag == "W_S")
		{
			movement = new Vector3 (-100, 0, 100);
			rigidbody.AddForce (movement * speed * Time.deltaTime);

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