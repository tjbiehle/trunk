using UnityEngine;
using System.Collections;

public class GUIopen : MonoBehaviour 
{

	public GameObject CompMenu;
	public GameObject OtherMenu1;
	public GameObject OtherMenu2;


	private Vector3 screenPoint;
	private Vector3 offset;

	void OnMouseDown()
	{

		screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));

		CompMenu.gameObject.SetActive (true);
		OtherMenu1.gameObject.SetActive (false);
		OtherMenu2.gameObject.SetActive (false);


	}

}
