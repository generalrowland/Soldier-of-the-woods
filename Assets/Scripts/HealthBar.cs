using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{

    public Slider slider;
    public Gradient gradient;
    public Image fill;
    public float healthAmount = 100;
    public Image healthBar;
    public GameObject deathMenu;
    public GameObject player;

    public void SetMaxHealth(int health)
    {
        slider.maxValue = health;
        slider.value = health;

        fill.color = gradient.Evaluate(1f);
    }

    public void SetHealth(int health)
    {
        slider.value = health;

        fill.color = gradient.Evaluate(slider.normalizedValue);
    }

    public void TakeDamage(float Damage)
    {
        healthAmount -= Damage;
        healthBar.fillAmount = healthAmount / 100;
    }

    public void Healing(float medKit)
    {
        healthAmount += medKit;
        healthAmount = Mathf.Clamp(healthAmount, 0, 100);

        healthBar.fillAmount = healthAmount / 100;
    }

    private void Update()
    {
        healthAmount = slider.value;
        if(healthAmount <= 0)
        {
            deathMenu.SetActive(true);
            Destroy(player);
        }
    }
}
