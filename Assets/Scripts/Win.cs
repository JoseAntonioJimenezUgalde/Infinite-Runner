using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Win : MonoBehaviour
{
    public TextMeshProUGUI TextMeshProUgui;
    
    // Start is called before the first frame update
    void Start()
    {
        TextMeshProUgui.text = "Puntos Obtenidos " + SumPoints.instance.puntos.ToString();
    }


}
