using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationPoteau : MonoBehaviour
{
     void FixedUpdate()
    {
        transform.Rotate(0f, 1f, 0f);
    }
}
