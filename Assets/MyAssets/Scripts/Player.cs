using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Attributs
    [SerializeField] private float _vitesse = 20; 
    private Rigidbody _rb;
    private float rotationSpeed = 50f;
    
    // Méthode privées
    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        MouvementsJoueur();
    }

   
    private void MouvementsJoueur()
    {
        float positionX = Input.GetAxis("Horizontal");
        float positionZ = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(positionX, 0f, positionZ);
        direction.Normalize();
        //transform.Translate(direction * Time.deltaTime * _vitesse);
        _rb.velocity = direction * Time.fixedDeltaTime * _vitesse;
        if (direction != Vector3.zero){
            Quaternion rotationD = Quaternion.LookRotation(direction.normalized, Vector3.up);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, rotationD, rotationSpeed * Time.fixedDeltaTime);
        }
        
    }


    public void FinPartieJoueur()
    {
        gameObject.SetActive(false);
        _vitesse = 0;
    }

}
