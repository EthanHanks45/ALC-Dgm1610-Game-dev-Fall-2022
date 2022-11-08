using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 3;
    public int currentHealth;
    public float deathDeley;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        currentHealth = maxHealth;
    }

    public void TakeDamage(int dmgAmount)
    {
        currentHealth -= dmgAmount;

        if(currentHealth <= 0)
        {
            Debug.Log("Game Over");
            Time.timeScale = 0;
        }
    }
    public void AddHealth(int healAmount)
    {
        currentHealth += healAmount;
        
        if(currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
}
