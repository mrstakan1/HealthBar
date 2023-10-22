using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    private float _minHealth = 0;
    private float _heal = 12.5f;
    private float _damage = 10f;

    public UnityAction<float> HealthChanged;
    public float MaxHealth { get; private set; } = 100f;
    public float Health { get; private set; }

    private void Awake()
    {
        Health = MaxHealth;
    }

    public void TakeDamage()
    {
        ChangeHealth(- _damage);
    }

    public void Heal()
    {
        ChangeHealth(_heal);
    }

    private void ChangeHealth(float changingValue)
    {
        Health += changingValue;
        Health = Mathf.Clamp(Health, _minHealth, MaxHealth);
        HealthChanged?.Invoke(Health);
    }
}