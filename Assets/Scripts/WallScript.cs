using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WallScript : MonoBehaviour
{
    public TMP_Text text;
    void OnCollisionEnter(Collision collision)
    {
        text.text = "Perdeu, Mané!";
        text.color = new Color32( 201 , 42, 42 , 255);
        Time.timeScale = 0f;

    }
}
