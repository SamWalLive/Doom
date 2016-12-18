using UnityEngine;
using System.Collections;

public class KillTime : MonoBehaviour {

    public float timer;

    private float time;
	
	void Update ()
    {
        time += Time.deltaTime;
        if (time >= timer)
        {
            Kill();
        }
	}

    void Kill()
    {
        Destroy(this.gameObject);
    }
}
