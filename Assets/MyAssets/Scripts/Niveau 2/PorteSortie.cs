using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PorteSortie : MonoBehaviour
{
    private bool _estActive = false;
    [SerializeField] private List<GameObject> _listePiegesPorte = new List<GameObject>();

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !_estActive)
        {
            foreach(var piege in _listePiegesPorte)
            {
               piege.SetActive(false);
            }

            _estActive = true;
        }
        
    }

    
}
