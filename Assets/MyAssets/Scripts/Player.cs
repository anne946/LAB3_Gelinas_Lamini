using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Attributs
    [SerializeField] private float _vitesse = 20; 
    private Rigidbody _rb;
    private float rotationSpeed = 50f;
    private float tempsDepart;
    private float temps;

    
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
        //if (Input.GetAxis("Horizontal") || Input.GetAxis("Vertical"))
        //{
           //tempsDepart = Time.time;
           //temps = Time.time - tempsDepart;
           //Debug.Log("Temps: " + temps);
        //}

        KeyCode r = KeyCode.RightArrow;
        KeyCode l = KeyCode.LeftArrow;
        KeyCode up = KeyCode.UpArrow;
        KeyCode d = KeyCode.DownArrow;

        if (Input.GetKeyDown(r)||Input.GetKeyDown(l)||Input.GetKeyDown(up)||Input.GetKeyDown(d))
        {
             Debug.Log("Down Arrow key was pressed.");
        }
        

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
