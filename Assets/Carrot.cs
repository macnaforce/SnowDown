﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrot : MonoBehaviour
{
    public double Damage = 1;
    [SerializeField] Rigidbody rb;
    [SerializeField] float CarrotVelocity= 30;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = -transform.forward * CarrotVelocity;
    }

    void OnCollisionEnter(Collision other)
    {
        other.gameObject.SendMessage("TakeDamage",Damage);
        other.gameObject.SendMessage("DmgWall",Damage);
        Destroy(gameObject);
    }
}
