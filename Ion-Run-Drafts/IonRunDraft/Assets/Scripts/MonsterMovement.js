#pragma strict

var path = [Vector3(0,0,0)];//, new Vector3(-3,0.5,4), new Vector3(3,0.5,4), new Vector3(3,0.5,-4)];//, new Vector3(-3,0.5, -4)];
var target = [Vector3(0,0,0)];
//var startPosition = ameObject.transform.position;
var time = 5;

function Start () {

	
}

function Update () {
	iTween.MoveTo(gameObject, iTween.Hash("path",path, "time",time, "easetype", "linear"));
	//iTween.PutOnPath(this.gameObject, new Vector3[]{new Vector3(-3,0.5,4), new Vector3(-3,0.5,4)}, percent);
	

}