using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombunnyControler : MonoBehaviour
{

    enum State { MovingHorizontally, MovingVertically, Dead };

    // keep track of the current state
    State currState;

    // Game Manager
    GameManager gm;

    // Enemy Manager
    EnemyManager em;

    private void Start()
    {
        gm = GameObject.FindObjectOfType<GameManager>();
    }

    public void KillEnemy()
    {
    

        //[implement your own effect here]
        FindObjectOfType<AudioManager>().Play("EnemyDeath");

        Destroy(gameObject);
    }
    void OnTriggerEnter(Collider other)
    {

        if (currState == State.Dead) return;

        //check if the enemy hit the player
        if (other.CompareTag("Player Body"))
        {
            gm.GameOver();
        }

    }


}

