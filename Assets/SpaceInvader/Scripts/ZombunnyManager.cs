using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombunnyManager : MonoBehaviour
{
    public GameObject enemy;
    public float delayTime = 1f;
    public float repeatRate = 3f;
    public Transform[] spawnPoints;
    GameManager gm;
    // private bool playerIsDead = false;

    // private void playerDeathAction()
    // {
    //    playerIsDead = true;
    // }

    public void Spawn()
    {
        int pointIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(enemy, spawnPoints[pointIndex].position, spawnPoints[pointIndex].rotation);

    }

    public void CreateEnemy2()
    {
        InvokeRepeating("Spawn", delayTime, repeatRate);
    }
    private void OnEnable()
    {
        
    }

    private void OnDisable()
    {
        
    }

    


    void Start()
    {
       // InvokeRepeating("Spawn",delayTime,repeatRate);
    }

   
}
