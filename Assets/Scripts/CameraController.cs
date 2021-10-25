using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	
    public float mouseSen;
    public Transform target;
    float xRotation,yRotation ;
 
    private RaycastHit hit;

    public void Start()
    {
	    Cursor.lockState = CursorLockMode.Locked;
	    Cursor.visible = false;
    }


    void Update () {
		
        float mouseX= Input.GetAxis("Mouse X");
        float mouseY=Input.GetAxis("Mouse Y");
      
        
        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -40f, 40f);
        Vector3 Xrotate = new Vector3(xRotation, 0, 0);
        transform.localRotation = Quaternion.Euler(Xrotate);


        yRotation += mouseX;
        Vector3 yrotate = new Vector3(0, yRotation, 0);
		target.transform.rotation = Quaternion.Euler(yrotate);


    }
}

