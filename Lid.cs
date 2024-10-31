using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lid : MonoBehaviour
{
    public bool Open = false;
    public float rotateSpeed = 0f;
    void Update()
    {
        if (Open == true)
        {
            rotateSpeed = -0.9f;
        }
        else
        {
            rotateSpeed = 0f;
        }
        transform.Rotate(Vector3.forward * Time.deltaTime * rotateSpeed);
    }
}
