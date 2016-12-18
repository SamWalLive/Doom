using UnityEngine;
using System.Collections;

public class PlayerRotation : MonoBehaviour {

    public float sensitivity;

    void Update()
    {
            transform.Rotate(0, Input.GetAxis("Mouse X") * sensitivity, 0);
    }
}
