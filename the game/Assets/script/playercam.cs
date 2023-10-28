using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class playercam : MonoBehaviour
{
    public float mousesens = 100f;
    public Transform playerbody;
    float xrotation = 0f;

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mousesens * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mousesens * Time.deltaTime;

        playerbody.Rotate(Vector3.up * mouseX);

    }
}
