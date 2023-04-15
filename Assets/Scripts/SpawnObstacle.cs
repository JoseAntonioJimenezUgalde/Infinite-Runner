using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    public float timeStar;
    public float timeRepeat;

    void Start()
    {
        
        InvokeRepeating("InstanciarObstacle", timeStar,timeRepeat);
    }

    void InstanciarObstacle()
    {
     GameObject Obstacle =   Pooling.instance.ReturnObstacle();
     Obstacle.transform.position = transform.position;
    }



}
