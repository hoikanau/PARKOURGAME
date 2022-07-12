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
    void Update()
    {
        if(transform.position.y < -1)
        {
            gameObject.transform.position = new Vector3(8.508388f,2.48f,-0.6940349f);
        }
    }
}
