using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winActivate : MonoBehaviour
{
    public GameObject WinScreen;
    
    void OnTriggerEnter(Collider other){
        WinScreen.SetActive(true);
    }
}
    