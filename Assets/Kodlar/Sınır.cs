﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sınır : MonoBehaviour
{
   
    void OnTriggerExit(Collider nesne)
    {
        Destroy(nesne.gameObject);
    }
}
