using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class healthBar : MonoBehaviour
{

    public Slider slider; // Public so it is callable from other scripts slider variable
    public Gradient gradient;
    public Image fill;
    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;

        fill.color = gradient.Evaluate(1f);

    }

    public void SetHealth(int health)
    {
        slider.value = health; // the sliders value equals the health

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
   
}
