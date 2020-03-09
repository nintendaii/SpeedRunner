using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public float lookRadius = 10f; 
    public Transform target;
    NavMeshAgent agent;
    private Animator ch_animator;
    private bool isRunning;
     private Vector3 startPosition;

     private Transform eTransform;
  void Start()
  {
    agent=GetComponent<NavMeshAgent>();
    ch_animator=GetComponent<Animator>();
    eTransform=GetComponent<Transform>();
    startPosition=eTransform.position;
  }
  void Update()
  {
    isRunning=false;
    float distance=Vector3.Distance(target.position,transform.position);
    if (distance<=lookRadius)
    {
      agent.SetDestination(target.position);
      isRunning=true;
    }
    if (isRunning)
    {
      ch_animator.SetBool("run", true);
    }
    else
    {
      //ch_animator.SetBool ("run",false);
    }
  }

    void OnDrawGizmosSelected(){
        Gizmos.color=Color.red;
        Gizmos.DrawWireSphere(transform.position,lookRadius);
    }

}
