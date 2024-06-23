using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHealth : MonoBehaviour
{
    public int health;
    public int maxHealth = 100;
    public Pause_script ps;
    public Slider healthBar;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        healthBar.maxValue = maxHealth;
        healthBar.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            ps.Restart();
            healthBar.value = 0;
        }
        healthBar.value = health;
    }
}
