using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTeleport : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "sender")
        {
            gameObject.transform.position = new Vector3(6.487917f, 3.5f,-4.951911f);
        }
    }
}
