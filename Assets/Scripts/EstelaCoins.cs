using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EstelaCoins : MonoBehaviour
{
    public float speed;

    public GameObject[] misCoins;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }


    void OnEnable()
    {
        for (int i = 0; i < misCoins.Length; i++)
        {
            misCoins[i].SetActive(true);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("KillZone"))
        {
            gameObject.SetActive(false);
        }
    }
}
