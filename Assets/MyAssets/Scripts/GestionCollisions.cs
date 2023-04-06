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
                MeshRenderer[] objet = gameObject.GetComponentsInChildren<MeshRenderer>();
                foreach (MeshRenderer corps in objet) 
                {
                    corps.material.color = Color.red;
                }
                _gestionJeu.AugmenterPointage();  
                _touche = true;
                _temps = Time.time + 4;
                Debug.Log("TESS");
            }
        }  
    }

    private void FixedUpdated()
    {
        
        if(_touche)
        {
            if(_temps == Time.time)
            {
                _touche = false;
                MeshRenderer[] objet = gameObject.GetComponentsInChildren<MeshRenderer>();
                foreach (MeshRenderer corps in objet)
                {
                    corps.material.color = Color.black;         
                }
            }
        }
    }
}
