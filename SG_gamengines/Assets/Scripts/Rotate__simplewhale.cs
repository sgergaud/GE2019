﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate__simplewhale : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.down * 50 * Time.deltaTime, Space.World);
    }
}
