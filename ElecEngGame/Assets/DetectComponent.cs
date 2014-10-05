using UnityEngine;
using System.Collections;

public class DetectComponent : MonoBehaviour {
	bool occupied = false;
	public GameObject PostPlayButton;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	void OnTriggerEnter(Collider other)
	{
		if(PostPlayButton.gameObject.activeSelf == false)
		{
			if(!occupied)
			{
						//If there is a component on it
				if( (other.gameObject.tag == "Capacitor") || (other.gameObject.tag == "Resistor") || (other.gameObject.tag == "Inductor") )
				{
					other.gameObject.rigidbody.AddForce (0, 200, 0);
					occupied = true;
				}
			}

		}

	}
}
