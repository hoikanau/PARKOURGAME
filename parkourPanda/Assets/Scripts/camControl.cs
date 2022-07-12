using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camControl : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Target, Player;
    public float RotationSpeed;
    float mouseX, mouseY;
    public float YLock1, YLock2;
    public GameObject WinScreen;

    void Update()
    {
        if(WinScreen.activeSelf == true){
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else{
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            CamControl();
        }
    }

    void CamControl(){
        mouseX += Input.GetAxis("Mouse X") * RotationSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * RotationSpeed;
        mouseY = Mathf.Clamp(mouseY, YLock1, YLock2);

        transform.LookAt(Target);
        Target.rotation = Quaternion.Euler(mouseY, mouseX, 0);
        Player.rotation = Quaternion.Euler(0, mouseX, 0);

    }
}
