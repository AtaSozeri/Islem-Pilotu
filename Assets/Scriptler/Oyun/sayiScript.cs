//bu dosyadaki her şey aracSoru scriptine aktarılmıştır

// ﻿using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
//
// public class sayiScript : MonoBehaviour
// {
//
//     public GameObject sifir;
//     public GameObject bir;
//     public GameObject iki;
//     public GameObject uc;
//     public GameObject dort;
//     public GameObject bes;
//     public GameObject alti;
//     public GameObject yedi;
//     public GameObject sekiz;
//     public GameObject dokuz;
//     public GameObject on;
//     public GameObject onbir;
//     public GameObject oniki;
//     public GameObject onuc;
//     public GameObject ondort;
//     public GameObject onbes;
//     public GameObject onalti;
//     public GameObject onyedi;
//     public GameObject onsekiz;
//     public GameObject ondokuz;
//     public GameObject yirmi;
//     public GameObject yirmibir;
//     public GameObject yirmiiki;
//     public GameObject yirmiuc;
//     public GameObject yirmidort;
//     public GameObject yirmibes;
//     public GameObject yirmialti;
//     public GameObject yirmiyedi;
//     public GameObject yirmisekiz;
//     public GameObject yirmidokuz;
//     public GameObject otuz;
//     public GameObject otuzbir;
//     public GameObject otuziki;
//     public GameObject otuzuc;
//     public GameObject otuzdort;
//     public GameObject otuzbes;
//     public GameObject otuzalti;
//     public GameObject otuzyedi;
//     public GameObject otuzsekiz;
//     public GameObject otuzdokuz;
//     public GameObject kirk;
//     public GameObject kirkbir;
//     public GameObject kirkiki;
//     public GameObject kirkuc;
//     public GameObject kirkdort;
//     public GameObject kirkbes;
//     public GameObject kirkalti;
//     public GameObject kirkyedi;
//     public GameObject kirksekiz;
//     public GameObject kirkdokuz;
//     public GameObject elli;
//     public GameObject ellibir;
//     public GameObject elliiki;
//     public GameObject elliuc;
//     public GameObject ellidort;
//     public GameObject ellibes;
//     public GameObject ellialti;
//     public GameObject elliyedi;
//     public GameObject ellisekiz;
//     public GameObject ellidokuz;
//     public GameObject atmis;
//     public GameObject atmisbir;
//     public GameObject atmisiki;
//     public GameObject atmisuc;
//     public GameObject atmisdort;
//     public GameObject atmisbes;
//     public GameObject atmisalti;
//     public GameObject atmisyedi;
//     public GameObject atmissekiz;
//     public GameObject atmisdokuz;
//     public GameObject yetmis;
//     public GameObject yetmisbir;
//     public GameObject yetmisiki;
//     public GameObject yetmisuc;
//     public GameObject yetmisdort;
//     public GameObject yetmisbes;
//     public GameObject yetmisalti;
//     public GameObject yetmisyedi;
//     public GameObject yetmissekiz;
//     public GameObject yetmisdokuz;
//     public GameObject seksen;
//     public GameObject seksenbir;
//     public GameObject sekseniki;
//     public GameObject seksenuc;
//     public GameObject seksendort;
//     public GameObject seksenbes;
//     public GameObject seksenalti;
//     public GameObject seksenyedi;
//     public GameObject seksensekiz;
//     public GameObject seksendokuz;
//     public GameObject doksan;
//     public GameObject doksanbir;
//     public GameObject doksaniki;
//     public GameObject doksanuc;
//     public GameObject doksandort;
//     public GameObject doksanbes;
//     public GameObject doksanalti;
//     public GameObject doksanyedi;
//     public GameObject doksansekiz;
//     public GameObject doksandokuz;
//
//     soruSpawn dogruCevap;
//     soruSpawn yanlisCevap;
//     private int dCevap;
//     private int yCevap;
//
//     private int cevapPozisyon;
//     private float xDeger;
//     [SerializeField] float yFark;
//     [SerializeField] float zFark;
//
//     // Start is called before the first frame update
//     void Start()
//     {
//       cevapPozisyon = Random.Range(0,2);
//       dCevap = soruSpawn.dogruCevap;
//       yCevap = soruSpawn.yanlisCevap;
//       switch(cevapPozisyon)
//       {
//         case 0:
//         xDeger = 4.6f;
//         break;
//
//         case 1:
//         xDeger = -4.6f;
//         break;
//       }
//       switch(dCevap)
//       {
//         case 0:
//         Instantiate(sifir, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 1:
//         Instantiate(bir, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 2:
//         Instantiate(iki, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 3:
//         Instantiate(uc, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 4:
//         Instantiate(dort, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 5:
//         Instantiate(bes, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 6:
//         Instantiate(alti, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 7:
//         Instantiate(yedi, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 8:
//         Instantiate(sekiz, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 9:
//         Instantiate(dokuz, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 10:
//         Instantiate(on, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 11:
//         Instantiate(onbir, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 12:
//         Instantiate(oniki, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 13:
//         Instantiate(onuc, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 14:
//         Instantiate(ondort, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 15:
//         Instantiate(onbes, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 16:
//         Instantiate(onalti, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 17:
//         Instantiate(onyedi, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 18:
//         Instantiate(onsekiz, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 19:
//         Instantiate(ondokuz, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 20:
//         Instantiate(yirmi, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 21:
//         Instantiate(yirmibir, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 22:
//         Instantiate(yirmiiki, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 23:
//         Instantiate(yirmiuc, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 24:
//         Instantiate(yirmidort, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 25:
//         Instantiate(yirmibes, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 26:
//         Instantiate(yirmialti, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 27:
//         Instantiate(yirmiyedi, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 28:
//         Instantiate(yirmisekiz, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 29:
//         Instantiate(yirmidokuz, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 30:
//         Instantiate(otuz, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 31:
//         Instantiate(otuzbir, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 32:
//         Instantiate(otuziki, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 33:
//         Instantiate(otuzuc, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 34:
//         Instantiate(otuzdort, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 35:
//         Instantiate(otuzbes, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 36:
//         Instantiate(otuzalti, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 37:
//         Instantiate(otuzyedi, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 38:
//         Instantiate(otuzsekiz, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 39:
//         Instantiate(otuzdokuz, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 40:
//         Instantiate(kirk, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 41:
//         Instantiate(kirkbir, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 42:
//         Instantiate(kirkiki, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 43:
//         Instantiate(kirkuc, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 44:
//         Instantiate(kirkdort, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 45:
//         Instantiate(kirkbes, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 46:
//         Instantiate(kirkalti, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 47:
//         Instantiate(kirkyedi, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 48:
//         Instantiate(kirksekiz, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 49:
//         Instantiate(kirkdokuz, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 50:
//         Instantiate(elli, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 51:
//         Instantiate(ellibir, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 52:
//         Instantiate(elliiki, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 53:
//         Instantiate(elliuc, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 54:
//         Instantiate(ellidort, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 55:
//         Instantiate(ellibes, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 56:
//         Instantiate(ellialti, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 57:
//         Instantiate(elliyedi, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 58:
//         Instantiate(ellisekiz, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 59:
//         Instantiate(ellidokuz, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 60:
//         Instantiate(atmis, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 61:
//         Instantiate(atmisbir, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 62:
//         Instantiate(atmisiki, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 63:
//         Instantiate(atmisuc, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 64:
//         Instantiate(atmisdort, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 65:
//         Instantiate(atmisbes, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 66:
//         Instantiate(atmisalti, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 67:
//         Instantiate(atmisyedi, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 68:
//         Instantiate(atmissekiz, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 69:
//         Instantiate(atmisdokuz, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 70:
//         Instantiate(yetmis, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 71:
//         Instantiate(yetmisbir, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 72:
//         Instantiate(yetmisiki, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 73:
//         Instantiate(yetmisuc, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 74:
//         Instantiate(yetmisdort, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 75:
//         Instantiate(yetmisbes, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 76:
//         Instantiate(yetmisalti, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 77:
//         Instantiate(yetmisyedi, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 78:
//         Instantiate(yetmissekiz, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 79:
//         Instantiate(yetmisdokuz, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 80:
//         Instantiate(seksen, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 81:
//         Instantiate(seksenbir, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 82:
//         Instantiate(sekseniki, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 83:
//         Instantiate(seksenuc, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 84:
//         Instantiate(seksendort, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 85:
//         Instantiate(seksenbes, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 86:
//         Instantiate(seksenalti, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 87:
//         Instantiate(seksenyedi, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 88:
//         Instantiate(seksensekiz, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 89:
//         Instantiate(seksendokuz, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 90:
//         Instantiate(doksan, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 91:
//         Instantiate(doksanbir, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 92:
//         Instantiate(doksaniki, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 93:
//         Instantiate(doksanuc, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 94:
//         Instantiate(doksandort, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 95:
//         Instantiate(doksanbes, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 96:
//         Instantiate(doksanalti, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 97:
//         Instantiate(doksanyedi, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 98:
//         Instantiate(doksansekiz, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 99:
//         Instantiate(doksandokuz, new Vector3(xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//       }
//       switch(yCevap)
//       {
//         case 0:
//         Instantiate(sifir, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 1:
//         Instantiate(bir, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 2:
//         Instantiate(iki, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 3:
//         Instantiate(uc, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 4:
//         Instantiate(dort, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 5:
//         Instantiate(bes, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 6:
//         Instantiate(alti, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 7:
//         Instantiate(yedi, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 8:
//         Instantiate(sekiz, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 9:
//         Instantiate(dokuz, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 10:
//         Instantiate(on, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 11:
//         Instantiate(onbir, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 12:
//         Instantiate(oniki, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 13:
//         Instantiate(onuc, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 14:
//         Instantiate(ondort, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 15:
//         Instantiate(onbes, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 16:
//         Instantiate(onalti, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 17:
//         Instantiate(onyedi, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 18:
//         Instantiate(onsekiz, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 19:
//         Instantiate(ondokuz, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 20:
//         Instantiate(yirmi, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 21:
//         Instantiate(yirmibir, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 22:
//         Instantiate(yirmiiki, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 23:
//         Instantiate(yirmiuc, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 24:
//         Instantiate(yirmidort, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 25:
//         Instantiate(yirmibes, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 26:
//         Instantiate(yirmialti, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 27:
//         Instantiate(yirmiyedi, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 28:
//         Instantiate(yirmisekiz, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 29:
//         Instantiate(yirmidokuz, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 30:
//         Instantiate(otuz, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 31:
//         Instantiate(otuzbir, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 32:
//         Instantiate(otuziki, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 33:
//         Instantiate(otuzuc, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 34:
//         Instantiate(otuzdort, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 35:
//         Instantiate(otuzbes, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 36:
//         Instantiate(otuzalti, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 37:
//         Instantiate(otuzyedi, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 38:
//         Instantiate(otuzsekiz, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 39:
//         Instantiate(otuzdokuz, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 40:
//         Instantiate(kirk, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 41:
//         Instantiate(kirkbir, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 42:
//         Instantiate(kirkiki, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 43:
//         Instantiate(kirkuc, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 44:
//         Instantiate(kirkdort, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 45:
//         Instantiate(kirkbes, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 46:
//         Instantiate(kirkalti, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 47:
//         Instantiate(kirkyedi, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 48:
//         Instantiate(kirksekiz, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 49:
//         Instantiate(kirkdokuz, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 50:
//         Instantiate(elli, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 51:
//         Instantiate(ellibir, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 52:
//         Instantiate(elliiki, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 53:
//         Instantiate(elliuc, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 54:
//         Instantiate(ellidort, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 55:
//         Instantiate(ellibes, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 56:
//         Instantiate(ellialti, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 57:
//         Instantiate(elliyedi, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 58:
//         Instantiate(ellisekiz, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 59:
//         Instantiate(ellidokuz, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 60:
//         Instantiate(atmis, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 61:
//         Instantiate(atmisbir, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 62:
//         Instantiate(atmisiki, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 63:
//         Instantiate(atmisuc, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 64:
//         Instantiate(atmisdort, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 65:
//         Instantiate(atmisbes, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 66:
//         Instantiate(atmisalti, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 67:
//         Instantiate(atmisyedi, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 68:
//         Instantiate(atmissekiz, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 69:
//         Instantiate(atmisdokuz, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 70:
//         Instantiate(yetmis, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 71:
//         Instantiate(yetmisbir, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 72:
//         Instantiate(yetmisiki, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 73:
//         Instantiate(yetmisuc, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 74:
//         Instantiate(yetmisdort, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 75:
//         Instantiate(yetmisbes, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 76:
//         Instantiate(yetmisalti, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 77:
//         Instantiate(yetmisyedi, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 78:
//         Instantiate(yetmissekiz, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 79:
//         Instantiate(yetmisdokuz, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 80:
//         Instantiate(seksen, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 81:
//         Instantiate(seksenbir, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 82:
//         Instantiate(sekseniki, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 83:
//         Instantiate(seksenuc, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 84:
//         Instantiate(seksendort, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 85:
//         Instantiate(seksenbes, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 86:
//         Instantiate(seksenalti, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 87:
//         Instantiate(seksenyedi, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 88:
//         Instantiate(seksensekiz, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 89:
//         Instantiate(seksendokuz, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 90:
//         Instantiate(doksan, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 91:
//         Instantiate(doksanbir, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 92:
//         Instantiate(doksaniki, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 93:
//         Instantiate(doksanuc, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 94:
//         Instantiate(doksandort, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 95:
//         Instantiate(doksanbes, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 96:
//         Instantiate(doksanalti, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 97:
//         Instantiate(doksanyedi, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 98:
//         Instantiate(doksansekiz, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//
//         case 99:
//         Instantiate(doksandokuz, new Vector3(-xDeger, transform.localPosition.y + yFark, transform.localPosition.z + zFark), Quaternion.Euler(-90,180,0));
//         break;
//       }
//     }
//
//     // Update is called once per frame
//     void Update()
//     {
//
//     }
// }
