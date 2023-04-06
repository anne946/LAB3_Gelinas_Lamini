using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationPilier : MonoBehaviour
{
   [SerializeField] private float _vitesseRotation = 0.5f;

    private void FixedUpdate()
    {
        transform.Rotate(0f, _vitesseRotation, 0f); 
    }
}
