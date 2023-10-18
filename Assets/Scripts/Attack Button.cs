using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class AttackButton : MonoBehaviour
{
    [SerializeField] private float _damage = 10f;
    [SerializeField] private Image _healthBar;
    [SerializeField] private Player _player;

    private float _animationTime = 1f;

    public void OnButtonClick()
    {
        float newHealthBarValue = (_player.Health - _damage) / _player.MaxHealth;
        _healthBar.DOFillAmount(newHealthBarValue, _animationTime);
        _player.TakeDamage(_damage);
    }
}