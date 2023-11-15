using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class raycam : MonoBehaviour
{
    public float rayrange;
    public Camera cam;
    [SerializeField] private LayerMask target;

    void Update()
    {
        Ray ray = new Ray(cam.transform.position, cam.transform.forward);
        Debug.DrawLine(ray.origin, ray.direction * rayrange);
        RaycastHit info;
        if (Physics.Raycast(ray, out info, rayrange, target))
        {

        }

    }
}
