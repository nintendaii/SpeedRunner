using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Acceleration : MonoBehaviour
{
  private CharacterMechanics cm;
  private void OnTriggerEnter(Collider other)
  {
    const float V = 20f;
    cm.GetComponent<CharacterMechanics>().moveSpeed = V;
  }
}
