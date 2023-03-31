using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = System.Random;

public class NiveauDisplay : MonoBehaviour
{
    private int _niv;
    public int _hs;
    public TextMeshProUGUI nivTxt;
    
    private void Start()
    {
        Resetcount();
        _hs = -1;
    }

    
    
    private void Update()
    {
        nivTxt.text = $"Score : {_niv}\nHigh Score : {_hs}";
    }

    public void Resetcount()
    {
        if (_niv > _hs)
        {
            _hs = _niv;
        }
        _niv = 1;
    }

    public void Addone()
    {
        _niv++;
    }

    public void Minusone()
    {
        _niv--;
    }
}
