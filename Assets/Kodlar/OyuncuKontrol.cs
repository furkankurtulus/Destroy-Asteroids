using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class OyuncuKontrol : MonoBehaviour
{
    Rigidbody fizik;
    float horizontal = 0;
    float vertical = 0;
    public float hiz;
    Vector3 hareket;


    float maxX = 6.0f;
    float minX = -6.0f;

    float maxZ = 12.0f;
    float minZ = -6.0f;

    public float egim;

    float atesZamani=0;
    public float sonrakiatesicinsure=0;

    public GameObject lazer;
    public Transform lazerCikisYeri;


    void Start()
    {
        fizik = GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        if (Input.GetButton("Fire1") && Time.time>atesZamani )
        {
            atesZamani = Time.time + sonrakiatesicinsure;

            Instantiate(lazer, lazerCikisYeri.position, Quaternion.identity);


        }
    }

    
    void FixedUpdate()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
        hareket = new Vector3(horizontal, 0, vertical);
        fizik.velocity = hareket*hiz;

        fizik.position = new Vector3(

            Mathf.Clamp(fizik.position.x, minX, maxX),
            0.0f,
            Mathf.Clamp(fizik.position.z,minZ,maxZ)
            );
        fizik.rotation = Quaternion.Euler(0, 0, fizik.velocity.x * -egim);
        ;
    } 
}
