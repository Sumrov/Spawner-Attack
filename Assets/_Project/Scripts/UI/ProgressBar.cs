using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressBar : Bar
{
    [SerializeField] private Spawner _spawber;

    private void OnEnable()
    {
        _spawber.EnemyCountChanged += OnValueChanged;
        Slider.value = 0;
    }

    private void OnDisable()
    {
        _spawber.EnemyCountChanged -= OnValueChanged;
    }
}
