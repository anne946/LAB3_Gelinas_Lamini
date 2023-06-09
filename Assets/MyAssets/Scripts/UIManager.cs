using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _txtAccrochages = default;
    [SerializeField] private TMP_Text _txtTemps = default;
    [SerializeField] private GameObject _menuPause = default;
    private bool _enPause;
    private GestionJeu _gestionJeu;


    void Start()
    {
        _gestionJeu = FindObjectOfType<GestionJeu>();
        _txtAccrochages.text = "Accrochages : " + _gestionJeu.GetPointage();
        _enPause = false;  
        Time.timeScale = 1;
    }

    private void Update()
    {
        KeyCode r = KeyCode.RightArrow;
        KeyCode l = KeyCode.LeftArrow;
        KeyCode up = KeyCode.UpArrow;
        KeyCode d = KeyCode.DownArrow;

        for(int i = 0; i<1;)
        {
            if (Input.GetKeyDown(r)||Input.GetKeyDown(l)||Input.GetKeyDown(up)||Input.GetKeyDown(d))
            {
                float temps = Time.time - _gestionJeu.GetTempsDepart();
                _txtTemps.text = "Temps : " + temps.ToString("f2");
            }
        }
       
 
        GestionPause();
    }

    private void GestionPause()
    {
        if (Input.GetKeyDown(KeyCode.Escape) && !_enPause)
        {
            _menuPause.SetActive(true);
            Time.timeScale = 0;
            _enPause = true;
        }
        else if (Input.GetKeyDown(KeyCode.Escape) && _enPause)
        {
            EnleverPause();
        }
    }

    public void ChangerPointage(int p_pointage)
    {
        _txtAccrochages.text = "Accrochages : " + p_pointage.ToString();
    }

    public void EnleverPause()
    {
        _menuPause.SetActive(false);
        Time.timeScale = 1;
        _enPause = false;
    }
}
