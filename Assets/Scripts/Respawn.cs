using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

	private CharacterController _characterController;
	public Vector3 respawnPosition;
	// Use this for initialization
	void Start () {
		respawnPosition=transform.position;
		_characterController = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
		//if (transform.position.y < -26) {
			//transform.localPosition = respawnPosition;
		//}
	}
  private void OnTriggerEnter(Collider other)
  {
		if (other.gameObject.tag=="RespawningMesh")
		{
				transform.position = respawnPosition;
		}
  }
}
