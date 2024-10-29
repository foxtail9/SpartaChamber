using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jumper : MonoBehaviour
{
    [SerializeField] private float launchForce = 10f;

    private void OnCollisionEnter(Collision collision)
    {
        Rigidbody otherRigidbody = collision.collider.GetComponent<Rigidbody>();

        if (otherRigidbody != null)
        {
            Vector3 upwardForce = Vector3.up * launchForce;
            otherRigidbody.AddForce(upwardForce, ForceMode.Impulse);
        }
    }
}
