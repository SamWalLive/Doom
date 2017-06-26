using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

    public float maxHealth;

    private float currentHealth;
    private Animator anim;

    void Start()
    {
        currentHealth = maxHealth;
        anim = GetComponent<Animator>();
    }

    public void TakeDamage(int damage, string source)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Die(source);
        }
    }

    void Die(string source)
    {
        if (source == "Player")
        {
            anim.SetTrigger("ShotDeath");
        }
        if (source == "Enemy")
        {
            anim.SetTrigger("ShotDeath");
        }
        anim.SetBool("IsDead", true);
        GetComponent<UnityEngine.AI.NavMeshAgent>().enabled = false;
        Destroy(GetComponent<CapsuleCollider>());
    }

    public float ViewHealth()
    {
        return currentHealth;
    }

}
