using UnityEngine;
using System.Collections;

public class CapBack : MonoBehaviour {
	public GameObject OtherSide;
	private Vector3 offset = new Vector3 (8,0,0);

	// Use this for initialization
	void Update () 
	{
		transform.position = offset + OtherSide.transform.position;
	}
	

}
