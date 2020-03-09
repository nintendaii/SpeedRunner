using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MEGA_Inst : MonoBehaviour
{
    public GameObject prefab;
    void Awake()
    {
        Instantiate(prefab,new Vector3(0, 0, 0), Quaternion.identity);
    }

}
