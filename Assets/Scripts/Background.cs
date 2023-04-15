using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class Background : MonoBehaviour
{
    public float speed;

    public Vector3 miPosicion;
    // Start is called before the first frame update
    void Start()
    {
        miPosicion = transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if (transform.position.x <= -0.41)
        {
            transform.position = miPosicion;
        }
        
    }
}
