using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Changementmenu : MonoBehaviour
{
    public void Onclick()
    {
        Debug.Log("click");
        SceneManager.LoadScene("Menu en jeu");
    }
}
