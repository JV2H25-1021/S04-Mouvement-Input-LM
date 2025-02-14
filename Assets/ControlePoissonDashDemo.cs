using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlePoissonDashDemo : MonoBehaviour
{
    private Rigidbody _rb;

    void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    void OnDash()
    {
        Debug.Log("Dash");
        _rb.AddRelativeForce(0, 0, 2f, ForceMode.VelocityChange);
    }
}
