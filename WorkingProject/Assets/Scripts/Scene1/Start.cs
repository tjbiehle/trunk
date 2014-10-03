using UnityEngine;
using System.Collections;

public class Start : MonoBehaviour {

	public float speed;
	private Vector3 movement = new Vector3 (0, 0, -100);

	public GameObject GUIScreen;
	public GameObject PlayerBall;
	public GameObject MainCam;
	public GameObject PlayCam;
	
	
	private Vector3 screenPoint;
	private Vector3 offset;
	
	void OnMouseDown()
	{
		
		screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

	//	MainCam.gameObject.SetActive (false);
	//	PlayCam.gameObject.SetActive (true);


		GUIScreen.SetActive (false);
	//	PlayerBall.gameObject.SetActive (true);
	//	PlayerBall.rigidbody.AddForce (movement * speed * Time.deltaTime);
		
		
	}
	
	}

