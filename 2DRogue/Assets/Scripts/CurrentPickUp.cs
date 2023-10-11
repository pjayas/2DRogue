using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CurrentPickUp : MonoBehaviour
{
    public enum Pickupobject  {COIN,GEM };
    public Pickupobject currentobject;
    public int pickupQuantity;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.name == "Player")
        {
            if (currentobject == Pickupobject.COIN)
            {
                PlayerStats.playerStats.coins += pickupQuantity;

            }
            else if (currentobject ==Pickupobject.GEM)
            {
                PlayerStats.playerStats.gems += pickupQuantity;

            }
            Destroy(gameObject);
        }
    }
}
