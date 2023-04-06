using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoneEtagere : MonoBehaviour
{
   private bool _estActive = false;
    [SerializeField] private List<GameObject> _listePieges = new List<GameObject>();
    private List<Rigidbody> _listeRb = new List<Rigidbody>();

    private void Start()
    {
        foreach(var piege in _listePieges)
        {
            _listeRb.Add(piege.GetComponent<Rigidbody>());
        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !_estActive)
        {
            foreach(var rb in _listeRb)
            {
                rb.useGravity = true;
            }
            _estActive = true;
        }
        
    }
}
