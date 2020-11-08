﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtPlayer : MonoBehaviour
{
    [SerializeField] GameObject player;
    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.LookAt(player.transform.position);
    }
}