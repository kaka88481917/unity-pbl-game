using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public float playerspeed = 10f;
    public CharacterController controller;
    public float grav = -10f;
    Vector3 velo;

    void Start()
    {
        
    }   

    // Update is called once per frame
    void Update()
    {
        float xpos = Input.GetAxis("Horizontal");
        float zpos = Input.GetAxis("Vertical");

        Vector3 move = transform.right * xpos + transform.forward * zpos;
        
        

        controller.Move(move * playerspeed * Time.deltaTime);
        
        velo.y += grav * Time.deltaTime;

        controller.Move(velo * Time.deltaTime);


    }
}
