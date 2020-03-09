using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour {
	private void OnTriggerEnter(Collider other){
		//transform.localPosition = new Vector3 (-0.321f,2.24f,11.223f);
		Application.LoadLevel("Menu");
	}
}
