using UnityEngine;
using System.Collections;

public class RocketCollision : MonoBehaviour {

    public GameObject explosion;
    public float animationLength;

    void Start()
    {
        transform.Rotate(80, 0, -270);
    }

    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.layer == 8)
        {
            Explode(collision);
            if (collision.gameObject.tag == "Enemy")
            {
                Destroy(collision.gameObject);
            }
            Destroy(this.gameObject);
        }
    }

    void Explode(Collider collision)
    {
        GameObject explosionInstance = (GameObject)Instantiate(explosion, collision.ClosestPointOnBounds(transform.position), transform.rotation);
        explosionInstance.GetComponent<KillTime>().timer = animationLength;
    }

}
