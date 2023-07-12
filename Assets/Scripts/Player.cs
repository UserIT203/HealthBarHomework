using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Player : MonoBehaviour
{
    [Header("Player Stats")]
    [SerializeField] private float _maxHealth;
    [Header("Slider Components")]
    [SerializeField] private HealthBar _hpSlider;

    private float _currentHealth;

    private void Awake()
    {
        _currentHealth = _maxHealth;
    }

    public void ChangeHP(float valueChanging) 
    {
        float tempHealth = _currentHealth + valueChanging;

        if (tempHealth < 0)
            return;
        else if(tempHealth > _maxHealth)
            return;
                
        _currentHealth = tempHealth;
        _hpSlider.ChangeSliderValue(_currentHealth);
    }
}
