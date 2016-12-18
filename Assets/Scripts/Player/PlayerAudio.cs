using UnityEngine;
using System.Collections;

public class PlayerAudio : MonoBehaviour {

    public AudioClip death;
    public AudioClip bryarPistolShot;
    public AudioClip hurt;

    private AudioSource audioSrc;

	void Start () {
        audioSrc = GetComponent<AudioSource>();
	}

    public void Hurt()
    {
        audioSrc.PlayOneShot(hurt, 1f);
    }

   public void BryarPistolShoot()
    {
        audioSrc.PlayOneShot(bryarPistolShot, 1f);
    }

}