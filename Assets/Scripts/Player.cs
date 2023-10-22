using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    private float _minHealth = 0;
    private float _heal = 12.5f;
    private float _damage = 10f;

    public UnityAction HealthChanged;
    public float MaxHealth { get; private set; } = 100f;
    public float Health { get; private set; }

    private void Awake()
    {
        Health = MaxHealth;
    }

    public void TakeDamage()
    {
        Health -= _damage;

        if (Health < 0)
            Health = _minHealth;

        HealthChanged?.Invoke();
    }

    public void Heal()
    {
        Health += _heal;

        if(Health > MaxHealth)
            Health = MaxHealth;
        
        HealthChanged?.Invoke();
    }
}