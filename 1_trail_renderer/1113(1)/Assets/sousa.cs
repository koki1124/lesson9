﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sousa : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, 5, 0));
        }
    }
}
