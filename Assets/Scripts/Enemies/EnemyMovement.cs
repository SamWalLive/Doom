using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour {

    public GameObject player;
    public Vector3 target;

    private NavMeshAgent navMesh;
    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
        navMesh = GetComponent<NavMeshAgent>();
        navMesh.destination = target;
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
        anim.SetFloat("LookRotation", Random.Range(0f, 1f));
    }

    void FixedUpdate()
    {
        if (navMesh.velocity == Vector3.zero)
        {
            anim.SetBool("IsWalking", false);
            SetAngleIdle();
        }
        else
        {
            anim.SetBool("IsWalking", true);
            SetAngle();
        }
    }

    void SetAngle()
    {
        float ang = Vector2.Angle(new Vector2(navMesh.destination.x, navMesh.destination.z) - new Vector2(transform.position.x, transform.position.z), new Vector2(player.transform.position.x, player.transform.position.z) - new Vector2(transform.position.x, transform.position.z));

        Vector3 cross = Vector3.Cross(new Vector2(navMesh.destination.x, navMesh.destination.z) - new Vector2(transform.position.x, transform.position.z), new Vector2(player.transform.position.x, player.transform.position.z) - new Vector2(transform.position.x, transform.position.z));

        if (cross.z > 0)
        {
            ang = 360 - ang;
        }
        anim.SetFloat("LookRotation", ang);
        if (gameObject.name == "Stormtrooper")
        {
            Debug.Log(gameObject.name + " " + ang.ToString());
        }
        
    }

    void SetAngleIdle()
    {
        float ang = Vector2.Angle(new Vector2(transform.position.x, transform.position.z), new Vector2(player.transform.position.x, player.transform.position.z) - new Vector2(transform.position.x, transform.position.z));
        Vector3 cross = Vector3.Cross(new Vector2(transform.position.x, transform.position.z), new Vector2(player.transform.position.x, player.transform.position.z) - new Vector2(transform.position.x, transform.position.z));
        if (cross.z > 0)
        {
            ang = 360 - ang;
        }
        anim.SetFloat("LookRotation", ang);
        if (gameObject.name == "Stormtrooper")
        {
            Debug.Log(gameObject.name + " " + ang.ToString());
        }
    }
}
