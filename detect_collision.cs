using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class detect_collision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        print("Landed on the " + collision.gameObject.name);
    }

    private void OnCollisionStay(Collision collision)
    {
        print("Moving on the " + collision.gameObject.name);
    }

    private void OnCollisionExit(Collision collision)
    {
        print("Fell off the " + collision.gameObject.name);
    }
}
