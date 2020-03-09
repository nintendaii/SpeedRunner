using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseOptions : MonoBehaviour {

	public GameObject PausePanel;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.Escape)) {
			Time.timeScale = 0;
			PausePanel.SetActive (true);
		}
	}
}
