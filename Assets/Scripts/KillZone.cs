using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillZone : MonoBehaviour
{

    
    void OnCollisionEnter2D (Collision2D collision) {

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            collision.gameObject.SetActive(false);
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            collision.gameObject.SetActive(false);
        }

    }
}
