using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinNiveau : MonoBehaviour
{  
    private GestionJeu _gestionJeu; 
    
    private void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();  
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")  
        {
            gameObject.GetComponent<MeshRenderer>().material.color = Color.green;  
            int noScene = SceneManager.GetActiveScene().buildIndex; 
            if (noScene == (SceneManager.sceneCountInBuildSettings - 2))  
            {
                _gestionJeu.SetTempsFinal(Time.time);
                SceneManager.LoadScene(noScene + 1);
            }
            else
            {
                SceneManager.LoadScene(noScene + 1);            
            }
        }
    }
}
