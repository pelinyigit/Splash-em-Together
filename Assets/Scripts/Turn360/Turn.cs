﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Turn : MonoBehaviour
{
  

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(50f, 0f, 0f)*Time.deltaTime);
    }
}
