using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private float _duractionTime;
    [SerializeField] private Player _player;

    private Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<Slider>();
        _slider.value = _player.MaxHealth;
    }

    public void ChangeSliderValue(float value) => _slider.DOValue(_slider.value + value, _duractionTime, false);
}
