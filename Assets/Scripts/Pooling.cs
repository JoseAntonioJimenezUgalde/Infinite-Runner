using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pooling : MonoBehaviour
{
    public static Pooling instance;
    [SerializeField] private GameObject[] food;
    [SerializeField] private int numberOfObstacles= 5;
    [SerializeField] private List<GameObject> obstacleList;

    void Awake()
    {
        instance = this;
        AddObstacleToList(numberOfObstacles);
    }
    private void AddObstacleToList(int obstacle)
    {
        for (int i = 0; i < obstacle; i++)
        {
            GameObject obstacleInstantiate = Instantiate(food[i]);
            obstacleInstantiate.SetActive(false);
            obstacleList.Add(obstacleInstantiate);
            obstacleInstantiate.transform.parent = transform;
        }
    }
    public GameObject ReturnObstacle()
    {
        int RandomFood = Random.Range(0, obstacleList.Count);
        
        if (!obstacleList[RandomFood].activeSelf)
        {
            obstacleList[RandomFood].SetActive(true);
            return obstacleList[RandomFood].gameObject;
        }
        else
        {
            for (int i = 0; i < obstacleList.Count; i++)
            {
                if (!obstacleList[i].activeSelf)
                {
                    obstacleList[i].SetActive(true);
                    return obstacleList[i].gameObject;
                }
            }
        }
        
        return null;
    }
    
}
