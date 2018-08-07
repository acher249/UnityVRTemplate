#pragma strict

var movTex : MovieTexture;
var loop : boolean;

function Start() {

	GetComponent.<Renderer>().material.mainTexture = movTex;
	movTex.Play();
	movTex.loop = true;

}
