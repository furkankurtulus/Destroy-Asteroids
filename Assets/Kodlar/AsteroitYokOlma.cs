using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AsteroitYokOlma : MonoBehaviour
{
    public GameObject patlama;
    public GameObject PlayerPatlama;


     GameObject OyunKontrol;
     OyunKontrol kontrol;


    
    void Start()
    {
        OyunKontrol = GameObject.FindGameObjectWithTag("oyunkontrol");
        kontrol = OyunKontrol.GetComponent<OyunKontrol>();
        
    }

    void OnTriggerEnter(Collider nesne)
    {

        if (nesne.tag != "sınır")
        {
            Destroy(nesne.gameObject);
            Destroy(gameObject);
            Instantiate(patlama, transform.position, transform.rotation);
            kontrol.SkorArttir(10);

        }
        if(nesne.tag == "Player")
        {
            Instantiate(PlayerPatlama, nesne.transform.position,nesne.transform.rotation );
            kontrol.oyunBitti();
        }
       
        

    }
}
