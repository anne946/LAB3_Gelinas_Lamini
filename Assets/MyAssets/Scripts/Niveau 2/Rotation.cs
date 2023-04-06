using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public void FixedUpdate()
    {
        transform.Rotate(0f, 0.5f, 0f);
    }

}
