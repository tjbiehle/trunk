using UnityEngine;
using System.Collections;

public class Enabler : MonoBehaviour {
	private Vector3 screenPoint;
	private Vector3 offset;
	//public GameObject resist;
	//public GameObject induct;
	//public GameObject capac;
	
	void OnMouseDown()
	{
		/*
		if(Input.mousePosition == transform.position )
		{
		//	if(Input.mousePosition.z > 5 && Input.mousePosition.z < 50)
			{
				resist.SetActive (false);
			}
		}
		if(Input.mousePosition == transform.position)
		{
		//	if(Input.mousePosition.z > 50 && Input.mousePosition.z < 100)
			{
				induct.SetActive (false);
			}
		}

		if(Input.mousePosition == transform.position)
		{
		//	if(Input.mousePosition.z > 100 && Input.mousePosition.z < 150)
			{
				capac.SetActive(false);
			}
		}*/
		screenPoint = Camera.main.WorldToScreenPoint(gameObject.transform.position);
		offset = gameObject.transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z));
	}
	void OnMouseDrag() 
	{  
		Vector3 curScreenPoint = new Vector3(Input.mousePosition.x, Input.mousePosition.y, screenPoint.z);
		
		Vector3 curPosition   = Camera.main.ScreenToWorldPoint(curScreenPoint) + offset;
		transform.position = curPosition;
	}
}
