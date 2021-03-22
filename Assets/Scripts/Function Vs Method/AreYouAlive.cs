using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreYouAlive : MonoBehaviour
{
    // Create a program that checks if the player is dead or not. When you hit the space key, you should damage
    // the player by a random amount. If the player is dead (health less than 1), print out "The Player has died!"
    //
    // Bonus: prevent the damage function from being called once player is dead and no negative health values.

    [SerializeField] private int maxHealth = 100;
    [SerializeField] private int currentHealth;

    private bool m_isDead;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            TakeDamage(Random.Range(10, 99));
    }

    public void TakeDamage(int amount)
    {
        if (m_isDead) return;

        currentHealth = Mathf.Clamp(currentHealth - amount, 0, maxHealth);

        if (currentHealth >= 1) return;

        m_isDead = true;
        Debug.Log("The Player has died!");
    }
}
