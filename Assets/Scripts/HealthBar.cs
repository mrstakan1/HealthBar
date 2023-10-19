using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using DG.Tweening;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image _image;
    [SerializeField] private Player _player;
    [SerializeField] private Slider _slider;

    private float _time = 0.1f;
    private float _sliderStartValue = 100f;

    private void Start()
    {
        _slider.value = _sliderStartValue;
    }

    public void StartHealthDecreasing(float newHealth)
    {
        StartCoroutine(DecreaseHealth(newHealth));
    }

    public void StartHealthIncreasing(float newHealth)
    {
        StartCoroutine(IncreaseHealth(newHealth));
    }
 

    private IEnumerator DecreaseHealth(float newHealth)
    {
        float currentValue = _slider.value;
        float currentTime = 0f;

        while(currentTime < _time)
        {
            currentTime += Time.deltaTime;
            float lerpValue = currentTime / _time;
            _slider.value = Mathf.Lerp(currentValue, newHealth, lerpValue);
            yield return null;
        }
    }

    private IEnumerator IncreaseHealth(float newHealth)
    {
        float currentValue = _slider.value;
        float currentTime = 0f;

        while (currentTime < _time)
        {
            currentTime += Time.deltaTime;
            float lerpValue = currentTime / _time;
            _slider.value = Mathf.Lerp(currentValue, newHealth, lerpValue);
            yield return null;
        }
    }
}