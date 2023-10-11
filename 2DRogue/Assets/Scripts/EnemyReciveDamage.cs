using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyReciveDamage : MonoBehaviour
{
    public float health;
    public float maxHealth;

    public GameObject healthBar;
    public Slider helthBarSlider;

    public GameObject lootDrop;

    void Start()
    {
        health = maxHealth;
    }

    public void DealDamage(float damage)
    {
        healthBar.SetActive(true);
       
        health -= damage;

        checkDeath();
        helthBarSlider.value = CalculateHealthPercentage();
    }
    public void HealCharacter(float heal)
    {
        health += heal;
        checkOverheal();
        helthBarSlider.value = CalculateHealthPercentage();
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
            Instantiate(lootDrop, transform.position, Quaternion.identity);
        }

    }

    private float CalculateHealthPercentage()
    {
        return (health / maxHealth);
    }    
}
