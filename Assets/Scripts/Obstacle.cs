using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float force;

    public float speed;


 
    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
    }


    
    
        
    void OnCollisionEnter2D (Collision2D collision) {
        if (collision.gameObject.CompareTag("Player")) 
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.left * force, ForceMode2D.Impulse);
            gameObject.SetActive(false);
        }
    }
}
