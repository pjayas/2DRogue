using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static PlayerStats playerStats;

    public GameObject player;
    public float health;
    public float maxHealth;

    void Start()
    {
        if(playerStats != null)
        {
            Destroy(playerStats);
        }
        else
        {
            playerStats = this;
        }
        DontDestroyOnLoad(this);
    }

    public void DealDamage(float damage)
    {
        health -= damage;

        checkDeath();
    }
    public void HealCharacter(float heal)
    {
        health += heal;
        checkOverheal();
    }
    private void checkOverheal()
    {
        if (health > maxHealth)
        {
            health = maxHealth;
        }
    }

    private void checkDeath()
    {
        if (health < 0)
        {
            Destroy(player);
        }

    }

    void Update()
    {

    }

}
