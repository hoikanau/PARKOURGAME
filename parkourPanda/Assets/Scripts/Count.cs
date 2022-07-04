using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Count : MonoBehaviour
{

   public float count = 0;
    void OnTriggerEnter(Collider other){
        
        if(other.tag == "ground"){
            if (count >= 1)
            {
               FindObjectOfType<soundManager>().Play("miss"); 
            }
            count = 0;
            Debug.Log(count);
        }
        else{
            count++;
            Debug.Log(count);
        }
        
    }
}
