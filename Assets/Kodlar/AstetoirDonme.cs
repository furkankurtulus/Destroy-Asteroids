using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AstetoirDonme : MonoBehaviour
{
    Rigidbody fizik;
    public int hiz;
    void Start()
    {
        fizik = GetComponent<Rigidbody>();
        fizik.angularVelocity = Random.insideUnitSphere*hiz;
        
    }

    
    
}
