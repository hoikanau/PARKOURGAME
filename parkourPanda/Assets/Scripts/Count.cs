using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Count : MonoBehaviour
{

   public float count = 0;
    void OnTriggerEnter(Collider other){
        count++;
        Debug.Log(count);
    }
}
