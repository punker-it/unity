using System;
using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float rotationSpeed=90.0f;
    void Start() {
        
    }

    // Update is called once per frame
    void Update()  {
        transform.Rotate(0,Time.deltaTime*rotationSpeed,0);
    }
}

