/*
 * (Austin Buck)
 * (Assignment 5B)
 * (Makes the enemies take damage)
 */
using UnityEngine;

public class Target : MonoBehaviour
{
    public float health = 50f;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if(health <=0)
        {
            Die();
        }
    }
    void Die()
    {
        Destroy(gameObject);
    }
}
