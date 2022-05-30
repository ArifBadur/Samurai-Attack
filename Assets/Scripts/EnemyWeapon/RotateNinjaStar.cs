using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateNinjaStar : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.Rotate(Vector3.forward, 5f);
    }
}
