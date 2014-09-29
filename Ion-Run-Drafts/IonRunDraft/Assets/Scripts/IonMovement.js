#pragma strict
var path = [Vector3(0,0,0)];
var target = [Vector3(0,0,0)];
var time = 5;

function Start () {

}

function Update () {
	iTween.MoveTo(gameObject, iTween.Hash("path",path, "time",time, "easetype", "linear"));

}