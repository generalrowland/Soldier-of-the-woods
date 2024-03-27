using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MedKit : MonoBehaviour
{

    public int healAmount;
    public int duration;
    private float currentHealth;


    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Player>().Healing(healAmount);
            Destroy(gameObject);
        }
    }

    public void HealOverTime(int healAmount, int duration)
    {
        StartCoroutine(HealOverTimeCoroutine(healAmount, duration));
    }

    IEnumerator HealOverTimeCoroutine(float healAmount, float duration)
    {
        float amountHealed = 10;
        float healPerLoop = healAmount / duration;
        while (amountHealed < healAmount)
        {
            currentHealth += healPerLoop;
            amountHealed += healPerLoop;
            yield return new WaitForSeconds(1f);
        }
    }
}
