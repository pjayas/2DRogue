using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerStats : MonoBehaviour
{
    public static PlayerStats playerStats;

    public GameObject player;
    public Text healthText;
    public Slider healthSlider;

    public float health;
    public float maxHealth;

    void Awake()
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

     void Start()
    {
        health = maxHealth;
        SetHealthUI();
    }

    public void DealDamage(float damage)
    {
        health -= damage;

        checkDeath();
        SetHealthUI();

    }

    public void HealCharacter(float heal)
    {
        health += heal;
        checkOverheal();
        SetHealthUI();

    }

    private void SetHealthUI()
    {
        healthSlider.value = CalculateHealthPercentage();
        healthText.text = Mathf.Ceil(health).ToString() + " / " + Mathf.Ceil(maxHealth).ToString();

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
        if (health <= 0)
        {
            health = 0; 
            Destroy(player);
        }
    }

    float CalculateHealthPercentage()
    {
        return health / maxHealth;
    }
}
