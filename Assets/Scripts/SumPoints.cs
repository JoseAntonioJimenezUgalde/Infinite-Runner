using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UIElements;

public class SumPoints : MonoBehaviour
{
    public TextMeshProUGUI TextMeshProUgui;
    public int puntos;
    public int pointsForWin;
    public GameObject PanelWin;

    public static SumPoints instance;

    void Awake()
    {
        instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        TextMeshProUgui.text = puntos.ToString() + " de 30";

    }
    
    

    public void SumPoint()
    {
        puntos++;
        TextMeshProUgui.text = puntos.ToString() + " de 30";
        VerificarWin();
    }

    public void VerificarWin()
    {
        if (pointsForWin == puntos)
        {
            Time.timeScale = 0;
            PanelWin.SetActive(true);
        }
    }
}
