using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lock : MonoBehaviour
{
    public GameObject Me;
    public bool UnLock = false;
    void Update()
    {
        if (UnLock == true)
        {
            transform.position = new Vector3(1.837f, 0.734f, 4.62f);
            print("UnLock");
            Rigidbody rigidbody = Me.AddComponent<Rigidbody>();
            rigidbody.mass = 0.3f;
        }
    }
}
