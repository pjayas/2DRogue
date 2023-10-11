using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestProjectile : MonoBehaviour
{
    public float damage;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.name != "Player")
        {
            EnemyReciveDamage enemyRecive = collision.GetComponent<EnemyReciveDamage>(); //

            if (enemyRecive != null)
            {
                enemyRecive.DealDamage(damage);
            }
            Destroy(gameObject);
        }
    }
}
