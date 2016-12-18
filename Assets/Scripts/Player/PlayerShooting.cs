using UnityEngine;
using System.Collections;

public class PlayerShooting : MonoBehaviour {

    public Transform spawnPos;
    public GameObject rocket;
    public float rocketStrength;

    private GameObject rocketInstance;

	void Update () {
        if (Input.GetButtonDown("Fire"))
        {
            rocketInstance = (GameObject)Instantiate(rocket, spawnPos.position, spawnPos.rotation);
            rocketInstance.GetComponent<Rigidbody>().velocity = spawnPos.forward * rocketStrength;
        }
	}

    

}
