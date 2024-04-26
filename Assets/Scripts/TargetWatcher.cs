using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TargetWatcher : MonoBehaviour
{

    public TMP_Text text;
    // Start is called before the first frame update
    void OnTriggerEnter(Collider collider)
    {
        text.text = "Parabéns, Sinhô!";
        text.color = new Color32( 0 , 255, 0 , 255);;
        Time.timeScale = 0f;
    }
}
