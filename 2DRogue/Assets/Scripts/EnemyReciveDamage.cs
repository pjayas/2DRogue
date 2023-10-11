using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyReciveDamage : MonoBehaviour
{
    public float health;
    public float maxHealth;

    void Start()
    {
        health = maxHealth;
    }

    public void DealDamage(float damage)
    {
        health -= damage;

        checkDeath();
    }

    private void checkOverheal()
    {
        if(health>maxHealth)
        {
            health = maxHealth;
        }
    }

    private void checkDeath()
    {
        if (health<0)
        {
            Destroy(gameObject);
        }

    }

    void Update()
    {
        
    }
}
