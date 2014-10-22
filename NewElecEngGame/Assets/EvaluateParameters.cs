using UnityEngine;
using System.Collections;

public class EvaluateParameters : MonoBehaviour {
	public GUIText level;
	public GUIText resist1;
	public GUIText resist2;
	public GUIText resist3;
	public GUIText totcurrent;
	public GUIText totcurrent1;
	public GUIText totcurrent2;
	public float voltage;

	public GameObject PlayButton;
	public GameObject NextStep;
	public GameObject Branch;
	
	// Update is called once per frame
	void Update () 
	{

		if (PlayButton.activeSelf == false) 
		{
			float R1, R2,R3, current, current1, current2;	
			R1 = R2 = R3 = current = current1 = current2 = 0;
			if(level.text == "Level 1")
			{
				R1 = stringtoint(resist1.text);
				R2 = stringtoint(resist2.text);

				current = voltage / (R1 + R2);
			}
			else if(level.text == "Level 2")
			{
				R1 = stringtoint(resist1.text);
				R2 = stringtoint(resist2.text);
				R3 = stringtoint(resist3.text);
				current = voltage / (R1 + ((R2*R3)/(R2+R3)));
				current1 = current * R3 / (R2+R3); 
				current2 = current * R2 / (R2+R3);
				totcurrent1.text = current1.ToString ();
				totcurrent2.text = current2.ToString ();

				Branch.name = (current1/(current1 + current2)).ToString ();
			}

			totcurrent.text = current.ToString ();



			gameObject.SetActive (false);
		}
	}


	/* Read from a string to an integer */
	int stringtoint(string a)
	{
		int value;
		value = int.Parse (a);
		return value;
	}

}
