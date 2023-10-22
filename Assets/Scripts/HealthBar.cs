using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Slider _slider;

    private float _time = 0.25f;

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

    private void StartHealthBarChanging(float newHealth)
    {
        StartCoroutine(ChangeHealthBar(newHealth));
    }

    private IEnumerator ChangeHealthBar(float newHealth)
    {
        float currentValue = _slider.value;
        float currentTime = 0f;

        while (currentTime < _time)
        {
            currentTime += Time.deltaTime;
            float lerpValue = (currentTime / _time);
            _slider.value = Mathf.Lerp(currentValue, newHealth, lerpValue);
            yield return null;
        }
    }
}