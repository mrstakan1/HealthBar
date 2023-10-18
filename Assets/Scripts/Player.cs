using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float _minHealth = 0;

    public float MaxHealth { get; private set; } = 100f;
    public float Health { get; private set; }

    private void Awake()
    {
        Health = MaxHealth;
    }

    public void TakeDamage(float damage)
    {
        Health -= damage;

        if (Health < 0)
            Health = _minHealth;
    }

    public void Heal(float newHealth)
    {
        Health += newHealth;

        if(Health > MaxHealth)
        {
            Health = MaxHealth;
        }
    }
}
