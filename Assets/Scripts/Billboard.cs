using UnityEngine;
using System.Collections;

public class Billboard : MonoBehaviour {

    public GameObject player;
	
    void Start()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
    }

	void Update ()
    {
        var targetPosition = player.transform.position;
        targetPosition.y = transform.position.y;
        transform.LookAt(targetPosition);
    }
}