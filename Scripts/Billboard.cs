using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* Makes the health bars inside of the scene look at the camera */

public class Billboard : MonoBehaviour
{
    public Transform cam;
    
    void LateUpdate()
    {
        transform.LookAt(transform.position + cam.forward);
    }
}
