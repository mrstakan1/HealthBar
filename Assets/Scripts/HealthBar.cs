using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Slider _slider;

    private float _time = 0.1f;

    private void Start()
    {
        _slider.value = _slider.maxValue;
    }

    private void OnEnable()
    {
        _player.HealthChanged += StartHealthBarChanging;
    }

    private void OnDisable()
    {
        _player.HealthChanged -= StartHealthBarChanging;
    }

    private void StartHealthBarChanging()
    {
        StartCoroutine(ChangeHealthBar());
    }

    private IEnumerator ChangeHealthBar()
    {
        float currentValue = _slider.value;
        float newHealth = _player.Health;
        float currentTime = 0f;

        while (currentTime < _time)
        {
            currentTime += Time.deltaTime;
            float lerpValue = (currentTime / _time);
            _slider.value = Mathf.Lerp(currentValue, newHealth, lerpValue); // как получить newHealth
            yield return null;
        }
    }
}