using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerTeleport_copy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < 0)
        {
            gameObject.transform.position = new Vector3(6.487917f, 4f,-4.951911f);
        }
    }
}
