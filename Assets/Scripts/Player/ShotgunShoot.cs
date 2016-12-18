/*
using UnityEngine;
using System.Collections;

public class ShotgunShoot : MonoBehaviour
{

    public float maxDistance;
    public int pellets;

    void ShootReg()
    {
        Transform trf = transform; // a little optimization
        RaycastHit hit;
        Quaternion hitRotation = Quaternion.FromToRotation(Vector3.up, hit.normal);
        Transform cam = Camera.main.transform;
        Ray ray = new Ray(cam.position, cam.forward);

        ray.direction.x += Random.Range(-CurrentSpreadF, CurrentSpreadF);
        ray.direction.y += Random.Range(-CurrentSpreadF, CurrentSpreadF);
        ray.direction.z += Random.Range(-CurrentSpreadF, CurrentSpreadF);

        if (Physics.Raycast(ray, out hit, Distance))
        {
            hit.
        }
    }
}
*/