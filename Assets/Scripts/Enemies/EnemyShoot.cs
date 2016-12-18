using UnityEngine;
using System.Collections;

public class EnemyShoot : MonoBehaviour {

    public float reactionTime;
    public float reloadTime;
    public float range;
    public GameObject laser;
    public Transform shootTransform;

    private NavMeshAgent nav;
    private Animator anim;
    private float reactionTimer;
    private float reloadTimer;
    private EnemyAudio audioControl;

	void Start ()
    {
        GetComponent<SphereCollider>().radius = range;
        nav = transform.parent.GetComponent<NavMeshAgent>();
        anim = transform.parent.GetComponent<Animator>();
        audioControl = transform.parent.GetComponent<EnemyAudio>();
	}
	
    void OnTriggerStay(Collider other)
    {
        if (!anim.GetBool("IsDead"))
        {
            if (other.tag == "Player")
            {
                reactionTimer += Time.deltaTime;
                RaycastHit hit;
                
                if (Physics.Raycast(transform.position, other.transform.position - transform.position, out hit))
                {
                    if (hit.transform.tag == "Player")
                    {
                        nav.destination = other.transform.position;
                        if (reactionTimer >= reactionTime && reloadTimer >= reloadTime)
                        {
                            Debug.Log("Shoot");
                            reloadTimer = 0f;
                            anim.SetTrigger("Attack");
                            audioControl.Attack();
                            GameObject line = Instantiate(laser);
                            line.GetComponent<LineRenderer>().SetPositions(new Vector3[] { shootTransform.position, hit.point });
                            hit.transform.GetComponent<PlayerAudio>().Hurt();
                        }
                    }
                }
            }
            else
            {
                reactionTimer = 0f;
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (!anim.GetBool("IsDead"))
        {
            if (other.tag == "Player")
            {
                reactionTimer = 0f;
            }
        }
    }

	void Update ()
    {
        reloadTimer += Time.deltaTime;
	}
}
