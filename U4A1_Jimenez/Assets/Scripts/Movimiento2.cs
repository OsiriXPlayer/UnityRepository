using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento2 : MonoBehaviour
{
    public Transform platform;
    public Transform target;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Sphere"))
        {
            platform.position = Vector3.Lerp(platform.position, target.position, Time.deltaTime);
        }
    }
}
