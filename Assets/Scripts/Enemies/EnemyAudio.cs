using UnityEngine;
using System.Collections;

public class EnemyAudio : MonoBehaviour {

    public AudioClip death;
    public AudioClip hurt;
    public AudioClip attack;

    private AudioSource audioSrc;

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
    }

    public void TakeDamage()
    {

        if (GetComponent<EnemyHealth>().ViewHealth() <= 0)
        {
            audioSrc.PlayOneShot(death, 1f);
        }
        else
        {
            audioSrc.PlayOneShot(hurt, 1f);
        }
    }

    public void Attack()
    {
        audioSrc.PlayOneShot(attack, 1f);
    }
}
