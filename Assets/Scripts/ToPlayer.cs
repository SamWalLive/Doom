using UnityEngine;
using System.Collections;

public class ToPlayer : MonoBehaviour {

    public Transform target;

    private NavMeshAgent agent;

	void Start () {
        agent = GetComponent<NavMeshAgent>();
	}
	
	void Update () {
        agent.SetDestination(target.position);
	}
}
