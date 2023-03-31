using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Random = System.Random;

public class IndiceDisplay : MonoBehaviour
{
    public TextMeshProUGUI idTxt;
    private Random _rd = new Random();
    private string[] _indice = {"¡Be Better!", "Use your neurons" , "¡O mejor!", "Try tapping the screen"
        , "Maybe click the right one","Try with your nose","Convince yourself that you are having fun"
        ,"The second one is probably the one, but the first one also", "Behind you" , "Help button may help you"
        ,"Mexican music is loud", "Good luck",
    };
    
    public void button()
    {
        idTxt.text = _indice[_rd.Next(_indice.Length)];
        idTxt.alpha = 1;
        Invoke("setalpha",2);
    }

    private void setalpha()
    {
        idTxt.alpha = 0;
    }
}
