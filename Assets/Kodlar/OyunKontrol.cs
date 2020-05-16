using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OyunKontrol : MonoBehaviour
{
    public GameObject Asteroid;
    public Vector3 randomPosition;

    public Text text;
    public Text oyunBittiText;

    bool oyunBittiKontrol = false;
    bool yenidenBaslaKontrol = false;

    int skor;
    void Start()
    {
        skor = 0;
        text.text = "Skor = " + skor;
        
        StartCoroutine (olustur());
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R) && yenidenBaslaKontrol)
        {
            SceneManager.LoadScene("sahne1");
        }
    }

    IEnumerator olustur()
    {
        yield return new WaitForSeconds(2);
        while (true)
        {
            for (int i = 0; i < 10; i++)
            {
                Vector3 vec = new Vector3(Random.Range(-6, 6), 0, 12);
                Instantiate(Asteroid, vec, Quaternion.identity);
                yield return new WaitForSeconds(0.7f);
            }
            yield return new WaitForSeconds(2);

            if (oyunBittiKontrol)
            {
                yenidenBaslaKontrol = true;
                break;
            }
        }
        
       
        
    }
    public void SkorArttir(int gelenskor)
    {
        skor += gelenskor;
        text.text = "Skor = " + skor;
    }

    public void oyunBitti()
    {
        oyunBittiText.text = "OYUN BİTTİ";
        oyunBittiKontrol = true;
    }
}
