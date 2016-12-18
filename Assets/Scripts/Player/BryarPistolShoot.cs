using UnityEngine;
using System.Collections;

public class BryarPistolShoot : MonoBehaviour {

    public float pelletDamage;
    public float waitTime;
    public GameObject laser;
    public Transform shootTransform;
    public GameObject gunParticles;
    public Animator weaponAnimator;

    private float wait;

	void Update ()
    {
        wait += Time.deltaTime;
        if (Input.GetButton("Fire") && wait >= waitTime)
        {
            Fire();
            wait = 0f;
        }
	}
	
	void Fire()
    {
        weaponAnimator.SetTrigger("BryarPistolShoot");
        GetComponent<PlayerAudio>().BryarPistolShoot();
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out hit, Mathf.Infinity))
        {
            GameObject line = Instantiate(laser);
            Instantiate(gunParticles, hit.point, Quaternion.Inverse(Camera.main.transform.rotation));
            line.GetComponent<LineRenderer>().SetPositions(new Vector3[] {shootTransform.position, hit.point});
            if(hit.collider.gameObject.layer == 8)
            {
                if(hit.collider.gameObject.tag == "Enemy")
                {
                    EnemyHealth hp = hit.collider.gameObject.GetComponent<EnemyHealth>();
                    hp.TakeDamage((int)pelletDamage, gameObject.tag);
                    hit.collider.gameObject.GetComponent<EnemyAudio>().TakeDamage();
                }
            }
        }
	}
}
