using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour {
	public Transform playerTransform;

  public Vector3 respawnPosition;
  void Start()
  {
    respawnPosition = playerTransform.position;
  }

	private void OnTriggerEnter(Collider other){
		if (other.gameObject.tag=="Player")
		{
            playerTransform.position = respawnPosition;
		}

	}
}
