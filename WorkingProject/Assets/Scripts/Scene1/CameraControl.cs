using UnityEngine;
using System.Collections;

public class CameraControl : MonoBehaviour {
	public GameObject player;
	void LateUpdate()
	{
		transform.position = player.transform.position + new Vector3 (0, 10, -20);
	}
}
