using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private Player _player;

    private float _animationTime = 1f;

    private void FixedUpdate()
    {
        _player.HealthChanged = OnHealthChanging;
    }

    private void OnHealthChanging()
    {
        float newHealth = _player.Health / _player.MaxHealth;
        _image.DOFillAmount(newHealth, _animationTime);
    }
}