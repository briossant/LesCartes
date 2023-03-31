using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NiveauDisplay : MonoBehaviour
{
    private int _niv;
    public TextMeshProUGUI nivTxt;

    private void Start()
    {
        Resetcount();
    }

    private void Update()
    {
        nivTxt.text = $"Niveau : {_niv}";
    }

    public void Resetcount()
    {
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
