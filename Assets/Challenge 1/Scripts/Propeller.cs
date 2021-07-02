//Author: Nicolas Chicunque 
//https://www.linkedin.com/in/nicolaschicunque
//https://nicolaschicunque.wixsite.com/portafolio

using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Propeller : MonoBehaviour
{
    public float rotationSpeed;

    void FixedUpdate()
    {
        transform.Rotate(Vector3.forward * rotationSpeed * Time.deltaTime);
    }
}
