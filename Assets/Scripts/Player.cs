using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Player : MonoBehaviour
{
    [Header("Player Stats")]
    [SerializeField] private float _maxHealth;

    private float _currentHealth;

    public float MaxHealth => _maxHealth;

    private void Awake()
    {
        _currentHealth = _maxHealth;
    }

    public void TakeDamage(float damage)
    {
        if (_currentHealth <= 0)
            return;

        _currentHealth -= damage;
    }

    public void CurePlayer(float value)
    {
        if (_currentHealth >= _maxHealth)
            return;

        _currentHealth += value;
    }
}
