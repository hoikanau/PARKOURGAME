using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lights : MonoBehaviour
{
    public GameObject Player;
    public Light beamOn;
    
    // Start is called before the first frame update
    void Start()
    {
        beamOn = GetComponent<Light>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "goodGrass")
        {
            beamOn.intensity = 1f;
        }
    }

    void OnTriggerExit(Collider other)
    {
        beamOn.intensity = 0f;
        
    }

    public void lightsOn(bool other)
    {
        if (other == true)
        {
            beamOn.intensity = 2f;
        }
        else if (other == false)
        {
            beamOn.intensity = 0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
