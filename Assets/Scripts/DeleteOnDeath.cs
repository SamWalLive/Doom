using UnityEngine;
using System.Collections;

public class DeleteOnDeath : MonoBehaviour {

    public AnimationClip deathAnimation;

    private Animator anim;

	void Start ()
    {
        anim = GetComponent<Animator>();
	}
	
	void Update ()
    {
	    if (anim.GetBool("IsDead"))
        {
            Destroy(this.gameObject, deathAnimation.length);
        }
	}
}
