using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthShower : MonoBehaviour
{
    [SerializeField] private TMP_Text _healthText;
    [SerializeField] private Player _player;

    private void Update()
    {
        _healthText.text = "HP: " + _player.Health.ToString();
    }
}
