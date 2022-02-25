//bu dosyadaki her şey aracSoru scriptine aktarılmıştır

// ﻿using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.UI;
// using TMPro;
//
// public class soruSpawn : MonoBehaviour
// {
//
//     public enum State {bir, iki, uc, dort, bes, alti, yedi};
//     public static State seviye=State.bir;
//
//     public static TextMeshProUGUI soru;
//
//     public static int solSayi;
//     public static int sagSayi;
//
//     public static int islem;
//
//     public static float soruSuresi;
//
//     public static int dogruCevap;
//     public static int yanlisCevap;
//
//
//     void Awake()
//     {
//       soru = GetComponent<TextMeshProUGUI>();
//       islem = Random.Range(0,4);
//       SoruYarat();
//     }
//
//     // Start is called before the first frame update
//     void Start()
//     {
//         // soru = GetComponent<TextMeshProUGUI>();
//         // islem = Random.Range(0,4);
//         // cevapPoz = Random.Range(0,2);
//         // SoruYarat();
//     }
//
//     public void SoruYarat()
//     {
//       switch (seviye)
//       {
//         case State.bir:
//         switch (islem)
//         {
//           case 0:
//           while(dogruCevap == yanlisCevap || yanlisCevap < 0)
//           {
//           solSayi = Random.Range(0, 10);
//           sagSayi = Random.Range(0,10);
//           dogruCevap = solSayi + sagSayi;
//           yanlisCevap = dogruCevap + Random.Range(-2,3);
//           soru.text = solSayi.ToString() + " + " + sagSayi.ToString();
//           soruSuresi = 5f;
//           }
//           break;
//
//           case 1:
//           while(solSayi < sagSayi || dogruCevap == yanlisCevap || yanlisCevap < 0)
//           {
//           solSayi = Random.Range(0, 10);
//           sagSayi = Random.Range(0,10);
//           dogruCevap = solSayi - sagSayi;
//           yanlisCevap = dogruCevap + Random.Range(-2,3);
//           soru.text = solSayi.ToString() + " - " + sagSayi.ToString();
//           soruSuresi = 5f;
//           }
//           break;
//
//           case 2:
//           while(dogruCevap == yanlisCevap || yanlisCevap < 0)
//           {
//           solSayi = Random.Range(0,5);
//           sagSayi = Random.Range(0,5);
//           dogruCevap = solSayi * sagSayi;
//           yanlisCevap = (solSayi + Random.Range(-2,2)) * sagSayi;
//           soru.text = solSayi.ToString() + " x " + sagSayi.ToString();
//           soruSuresi = 5f;
//           }
//           break;
//
//           case 3:
//           while(dogruCevap == yanlisCevap || yanlisCevap < 0)
//           {
//           solSayi = Random.Range(0,5);
//           sagSayi = Random.Range(0,10);
//           dogruCevap = solSayi * sagSayi;
//           yanlisCevap = (solSayi + Random.Range(-2,2)) * sagSayi;
//           soru.text = solSayi.ToString() + " x " + sagSayi.ToString();
//           soruSuresi = 7f;
//           }
//           break;
//         }
//         break;
//
//         case State.iki:
//         switch (islem)
//         {
//           case 0:
//           while(dogruCevap == yanlisCevap || yanlisCevap < 0)
//           {
//           solSayi = Random.Range(0,20);
//           sagSayi = Random.Range(0,20);
//           dogruCevap = solSayi + sagSayi;
//           yanlisCevap = dogruCevap + Random.Range(-4,6);
//           soru.text = solSayi.ToString() + " + " + sagSayi.ToString();
//           soruSuresi = 5f;
//           }
//           break;
//
//           case 1:
//           while(solSayi < sagSayi || dogruCevap == yanlisCevap || yanlisCevap < 0)
//           {
//           solSayi = Random.Range(0,20);
//           sagSayi = Random.Range(0,20);
//           dogruCevap = solSayi - sagSayi;
//           yanlisCevap = dogruCevap + Random.Range(-5,5);
//           soru.text = solSayi.ToString() + " - " + sagSayi.ToString();
//           soruSuresi = 5f;
//           }
//           break;
//
//           case 2:
//           while(dogruCevap == yanlisCevap || yanlisCevap < 0)
//           {
//           solSayi = Random.Range(0,10);
//           sagSayi = Random.Range(0,10);
//           dogruCevap = solSayi * sagSayi;
//           yanlisCevap = (solSayi + Random.Range(-2,2)) * sagSayi;
//           soru.text = solSayi.ToString() + " x " + sagSayi.ToString();
//           soruSuresi = 7f;
//           }
//           break;
//
//           case 3:
//           while(solSayi % sagSayi != 0 || solSayi < sagSayi || yanlisCevap < 0 || dogruCevap == yanlisCevap)
//           {
//           solSayi = Random.Range(1,20);
//           sagSayi = Random.Range(1,20);
//           dogruCevap = solSayi / sagSayi;
//           yanlisCevap = dogruCevap + Random.Range(-4, 5);
//           soru.text = solSayi.ToString() + " / " + sagSayi.ToString();
//           soruSuresi = 6f;
//           }
//           break;
//         }
//         break;
//
//         case State.uc:
//         switch (islem)
//         {
//           case 0:
//           while(dogruCevap == yanlisCevap || yanlisCevap < 0)
//           {
//           solSayi = Random.Range(10,30);
//           sagSayi = Random.Range(10,30);
//           dogruCevap = solSayi + sagSayi;
//           yanlisCevap = dogruCevap + Random.Range(-5,7);
//           soru.text = solSayi.ToString() + " + " + sagSayi.ToString();
//           soruSuresi = 5f;
//           }
//           break;
//
//           case 1:
//           while(solSayi < sagSayi || dogruCevap == yanlisCevap || yanlisCevap < 0)
//           {
//           solSayi = Random.Range(10,30);
//           sagSayi = Random.Range(10,30);
//           dogruCevap = solSayi - sagSayi;
//           yanlisCevap = dogruCevap + Random.Range(-5,6);
//           soru.text = solSayi.ToString() + " - " + sagSayi.ToString();
//           soruSuresi = 5f;
//           }
//           break;
//
//           case 2:
//           while(dogruCevap == yanlisCevap || yanlisCevap < 0)
//           {
//           solSayi = Random.Range(0,15);
//           sagSayi = Random.Range(0,10);
//           dogruCevap = solSayi * sagSayi;
//           yanlisCevap = (solSayi + Random.Range(-2,2)) * sagSayi;
//           soru.text = solSayi.ToString() + " x " + sagSayi.ToString();
//           soruSuresi = 6f;
//           }
//           break;
//
//           case 3:
//           while(solSayi % sagSayi != 0 || solSayi < sagSayi || yanlisCevap < 0 || dogruCevap == yanlisCevap)
//           {
//           solSayi = Random.Range(1,35);
//           sagSayi = Random.Range(1,30);
//           dogruCevap = solSayi / sagSayi;
//           yanlisCevap = dogruCevap + Random.Range(-4, 5);
//           soru.text = solSayi.ToString() + " / " + sagSayi.ToString();
//           soruSuresi = 6f;
//           }
//           break;
//         }
//         break;
//
//         case State.dort:
//         switch (islem)
//         {
//           case 0:
//           while(dogruCevap == yanlisCevap || yanlisCevap < 0)
//           {
//           solSayi = Random.Range(15,40);
//           sagSayi = Random.Range(15,40);
//           dogruCevap = solSayi + sagSayi;
//           yanlisCevap = dogruCevap + Random.Range(-5,7);
//           soru.text = solSayi.ToString() + " + " + sagSayi.ToString();
//           soruSuresi = 5f;
//           }
//           break;
//
//           case 1:
//           while(solSayi < sagSayi || dogruCevap == yanlisCevap || yanlisCevap < 0)
//           {
//           solSayi = Random.Range(15,40);
//           sagSayi = Random.Range(10,40);
//           dogruCevap = solSayi - sagSayi;
//           yanlisCevap = dogruCevap + Random.Range(-5,6);
//           soru.text = solSayi.ToString() + " - " + sagSayi.ToString();
//           soruSuresi = 5f;
//           }
//           break;
//
//           case 2:
//           while(dogruCevap == yanlisCevap || yanlisCevap < 0)
//           {
//           solSayi = Random.Range(0,19);
//           sagSayi = Random.Range(0,5);
//           dogruCevap = solSayi * sagSayi;
//           yanlisCevap = (solSayi + Random.Range(-2,2)) * sagSayi;
//           soru.text = solSayi.ToString() + " x " + sagSayi.ToString();
//           soruSuresi = 6f;
//           }
//           break;
//
//           case 3:
//           while(solSayi % sagSayi != 0 || solSayi < sagSayi || yanlisCevap < 0 || dogruCevap == yanlisCevap ||solSayi == sagSayi)
//           {
//           solSayi = Random.Range(1, 45);
//           sagSayi = Random.Range(1,30);
//           dogruCevap = solSayi / sagSayi;
//           yanlisCevap = dogruCevap + Random.Range(-4, 5);
//           soru.text = solSayi.ToString() + " / " + sagSayi.ToString();
//           soruSuresi = 6f;
//           }
//           break;
//         }
//         break;
//
//         case State.bes:
//         switch (islem)
//         {
//           case 0:
//           while(dogruCevap == yanlisCevap || yanlisCevap < 0)
//           {
//           solSayi = Random.Range(15,49);
//           sagSayi = Random.Range(15,49);
//           dogruCevap = solSayi + sagSayi;
//           yanlisCevap = dogruCevap + Random.Range(-7,9);
//           soru.text = solSayi.ToString() + " + " + sagSayi.ToString();
//           soruSuresi = 5f;
//           }
//           break;
//
//           case 1:
//           while(solSayi < sagSayi || dogruCevap == yanlisCevap || yanlisCevap < 0)
//           {
//           solSayi = Random.Range(15,49);
//           sagSayi = Random.Range(10,49);
//           dogruCevap = solSayi - sagSayi;
//           yanlisCevap = dogruCevap + Random.Range(-5,6);
//           soru.text = solSayi.ToString() + " - " + sagSayi.ToString();
//           soruSuresi = 5f;
//           }
//           break;
//
//           case 2:
//           while(dogruCevap == yanlisCevap || yanlisCevap < 0)
//           {
//           solSayi = Random.Range(0,19);
//           sagSayi = Random.Range(0,5);
//           dogruCevap = solSayi * sagSayi;
//           yanlisCevap = (solSayi + Random.Range(-2,2)) * sagSayi;
//           soru.text = solSayi.ToString() + " x " + sagSayi.ToString();
//           soruSuresi = 5f;
//           }
//           break;
//
//           case 3:
//           while(solSayi % sagSayi != 0 || solSayi < sagSayi || yanlisCevap < 0 || dogruCevap == yanlisCevap || solSayi == sagSayi)
//           {
//           solSayi = Random.Range(1,49);
//           sagSayi = Random.Range(1,49);
//           dogruCevap = solSayi / sagSayi;
//           yanlisCevap = dogruCevap + Random.Range(-4, 5);
//           soru.text = solSayi.ToString() + " / " + sagSayi.ToString();
//           soruSuresi = 5f;
//           }
//           break;
//         }
//         break;
//
//         case State.alti:
//         switch (islem)
//         {
//           case 0:
//           while(dogruCevap == yanlisCevap || yanlisCevap < 0)
//           {
//           solSayi = Random.Range(15,49);
//           sagSayi = Random.Range(15,49);
//           dogruCevap = solSayi + sagSayi;
//           yanlisCevap = dogruCevap + Random.Range(-7,9);
//           soru.text = solSayi.ToString() + " + " + sagSayi.ToString();
//           soruSuresi = 4f;
//           }
//           break;
//
//           case 1:
//           while(solSayi < sagSayi || dogruCevap == yanlisCevap || yanlisCevap < 0)
//           {
//           solSayi = Random.Range(15,49);
//           sagSayi = Random.Range(10,49);
//           dogruCevap = solSayi - sagSayi;
//           yanlisCevap = dogruCevap + Random.Range(-5,6);
//           soru.text = solSayi.ToString() + " - " + sagSayi.ToString();
//           soruSuresi = 4f;
//           }
//           break;
//
//           case 2:
//           while(dogruCevap == yanlisCevap || yanlisCevap < 0)
//           {
//           solSayi = Random.Range(0,19);
//           sagSayi = Random.Range(0,5);
//           dogruCevap = solSayi * sagSayi;
//           yanlisCevap = (solSayi + Random.Range(-2,2)) * sagSayi;
//           soru.text = solSayi.ToString() + " x " + sagSayi.ToString();
//           soruSuresi = 4f;
//           }
//           break;
//
//           case 3:
//           while(solSayi % sagSayi != 0 || solSayi < sagSayi || yanlisCevap < 0 || dogruCevap == yanlisCevap || solSayi == sagSayi)
//           {
//           solSayi = Random.Range(1,49);
//           sagSayi = Random.Range(1,49);
//           dogruCevap = solSayi / sagSayi;
//           yanlisCevap = dogruCevap + Random.Range(-4, 5);
//           soru.text = solSayi.ToString() + " / " + sagSayi.ToString();
//           soruSuresi = 4f;
//           }
//           break;
//         }
//         break;
//
//         case State.yedi:
//         switch (islem)
//         {
//           case 0:
//           while(dogruCevap == yanlisCevap || yanlisCevap < 0)
//           {
//           solSayi = Random.Range(15,49);
//           sagSayi = Random.Range(15,49);
//           dogruCevap = solSayi + sagSayi;
//           yanlisCevap = dogruCevap + Random.Range(-7,9);
//           soru.text = solSayi.ToString() + " + " + sagSayi.ToString();
//           soruSuresi = 3f;
//           }
//           break;
//
//           case 1:
//           while(solSayi < sagSayi || dogruCevap == yanlisCevap || yanlisCevap < 0)
//           {
//           solSayi = Random.Range(15,49);
//           sagSayi = Random.Range(10,49);
//           dogruCevap = solSayi - sagSayi;
//           yanlisCevap = dogruCevap + Random.Range(-5,6);
//           soru.text = solSayi.ToString() + " - " + sagSayi.ToString();
//           soruSuresi = 3f;
//           }
//           break;
//
//           case 2:
//           while(dogruCevap == yanlisCevap || yanlisCevap < 0)
//           {
//           solSayi = Random.Range(0,19);
//           sagSayi = Random.Range(0,5);
//           dogruCevap = solSayi * sagSayi;
//           yanlisCevap = (solSayi + Random.Range(-2,2)) * sagSayi;
//           soru.text = solSayi.ToString() + " x " + sagSayi.ToString();
//           soruSuresi = 3f;
//           }
//           break;
//
//           case 3:
//           while(solSayi % sagSayi != 0 || solSayi < sagSayi || yanlisCevap < 0 || dogruCevap == yanlisCevap || solSayi == sagSayi)
//           {
//           solSayi = Random.Range(1,49);
//           sagSayi = Random.Range(1,49);
//           dogruCevap = solSayi / sagSayi;
//           yanlisCevap = dogruCevap + Random.Range(-4, 5);
//           soru.text = solSayi.ToString() + " / " + sagSayi.ToString();
//           soruSuresi = 3f;
//           }
//           break;
//         }
//         break;
//
//       }
//     }
//     // Update is called once per frame
//     void Update()
//     {
//
//     }
//
//
// }
