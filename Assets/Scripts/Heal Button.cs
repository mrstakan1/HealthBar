using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HealButton : MonoBehaviour
{
    [SerializeField] private float _healValue = 13f;
    [SerializeField] private Image _healthBar;
    [SerializeField] private Player _player;

    private float _animationTime = 1f;

    public void OnButtonClick()
    {
        float newHealthBarValue = (_player.Health + _healValue) / _player.MaxHealth;
        _healthBar.DOFillAmount(newHealthBarValue, _animationTime);
        _player.Heal(_healValue);
    }
}
