using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GestionCollisions : MonoBehaviour
{
    // Attributs
    private GestionJeu _gestionJeu;
    private bool _touche;
    private float _temps;

    // Méthodes privées
    private void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
        _touche= false;

    }
    private void OnCollisionEnter(Collision collision)
    {  
        if (collision.gameObject.tag == "Player")
        {
            if(!_touche)
            {
                gameObject.GetComponent<MeshRenderer>().material.color = Color.black;
                _gestionJeu.AugmenterPointage();
                _touche = true;
                _temps = Time.time + 4;
            }
        }  
    }

    void FixedUpdated()
    {
        if(_touche)
        {
            if(_temps == Time.time)
            {
                _touche = false;
                gameObject.GetComponent<MeshRenderer>().material.color = Color.grey;
            }
        }
    }
}
