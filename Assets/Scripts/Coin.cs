using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{


    
   /* void OnCollisionEnter2D (Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            gameObject.SetActive(false);
        }
    }*/
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            gameObject.SetActive(false);
            SumPoints.instance.SumPoint();
        }
    }
}
