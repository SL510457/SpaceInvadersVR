using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombunnyHealth : MonoBehaviour
{
    public int startHealth = 100;
    private int currentHealth;
    private Animator anim;
    private bool isDead;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        currentHealth = startHealth;

    }

    private void Death()
    {
        isDead = true;
        anim.SetTrigger("IsDead");
    }

    public void TakeDamage(int amount)
    {
        if (isDead) return;
        currentHealth -= amount;
        if(currentHealth <= 0)
        {
            Death();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

