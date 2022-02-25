using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class yuksekPuan : MonoBehaviour
{
    public TextMeshProUGUI yuksekSkor;

    void Start()
    {
      yuksekSkor.text = "En Yüksek Puan: " + PlayerPrefs.GetFloat("YuksekSkor", 0);
    }

    void Update() //yüksek puanı kaydetme kodları
    {
      if(aracSoru.puan > PlayerPrefs.GetFloat("YuksekSkor", 0))
      {
        PlayerPrefs.SetFloat("YuksekSkor", aracSoru.puan);
        yuksekSkor.text = "En Yüksek Puan: " + aracSoru.puan.ToString();
      }
    }
}
