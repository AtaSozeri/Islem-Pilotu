using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class geriSayim : MonoBehaviour
{

    public float taninanSure = 5f;
    public static float guncelSure;
    [SerializeField] TextMeshProUGUI zaman;
    public aracSoru soruSuresi;


    void Awake()
    {
      guncelSure = 5f;
    }

    void Update()
    {
        zaman = GetComponent<TextMeshProUGUI>();
        guncelSure -= 1 * Time.deltaTime; //bu satır ile her saniye güncelsüre değerinden bir değer eksilmesini sağladım
        zaman.text = "Süre: " + guncelSure.ToString("F0");

        if(guncelSure <= 0)
        {
          guncelSure = 0;
        }
    }
}
