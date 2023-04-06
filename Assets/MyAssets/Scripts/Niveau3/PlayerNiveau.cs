using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerNiveau : MonoBehaviour
{
    // Attributs
    [SerializeField] private float _vitesse = 50; 
    private Rigidbody _rb;
    
    // Méthode privées
    private void Start()
    {
        // Position initiale du joueur
        //transform.position = new Vector3(-44f, 2f, 34f);
        //transform.position = new Vector3( -0.27f,1f,-45.27f);

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
        transform.Translate(direction * Time.deltaTime * _vitesse);
        //_rb.velocity = direction * Time.fixedDeltaTime * _vitesse;
        
    }

    public void finPartieJoueur()
    {
       this.gameObject.SetActive(false); 
    }
    /*public void FinPartieJoueur()
    {
        gameObject.SetActive(false);
        _vitesse = 0;
    }*/
}
