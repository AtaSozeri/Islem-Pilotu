//bu dosyadaki her şey aracSoru scriptine aktarılmıştır

// ﻿using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
//
// public class dogruSayiSpawn : MonoBehaviour
// {
//
//   public static float dogruXDeger;
//   public Transform arac;
//
//   public MeshFilter sifir;
//   public MeshFilter bir;
//   public MeshFilter iki;
//   public MeshFilter uc;
//   public MeshFilter dort;
//   public MeshFilter bes;
//   public MeshFilter alti;
//   public MeshFilter yedi;
//   public MeshFilter sekiz;
//   public MeshFilter dokuz;
//   public MeshFilter on;
//   public MeshFilter onbir;
//   public MeshFilter oniki;
//   public MeshFilter onuc;
//   public MeshFilter ondort;
//   public MeshFilter onbes;
//   public MeshFilter onalti;
//   public MeshFilter onyedi;
//   public MeshFilter onsekiz;
//   public MeshFilter ondokuz;
//   public MeshFilter yirmi;
//   public MeshFilter yirmibir;
//   public MeshFilter yirmiiki;
//   public MeshFilter yirmiuc;
//   public MeshFilter yirmidort;
//   public MeshFilter yirmibes;
//   public MeshFilter yirmialti;
//   public MeshFilter yirmiyedi;
//   public MeshFilter yirmisekiz;
//   public MeshFilter yirmidokuz;
//   public MeshFilter otuz;
//   public MeshFilter otuzbir;
//   public MeshFilter otuziki;
//   public MeshFilter otuzuc;
//   public MeshFilter otuzdort;
//   public MeshFilter otuzbes;
//   public MeshFilter otuzalti;
//   public MeshFilter otuzyedi;
//   public MeshFilter otuzsekiz;
//   public MeshFilter otuzdokuz;
//   public MeshFilter kirk;
//   public MeshFilter kirkbir;
//   public MeshFilter kirkiki;
//   public MeshFilter kirkuc;
//   public MeshFilter kirkdort;
//   public MeshFilter kirkbes;
//   public MeshFilter kirkalti;
//   public MeshFilter kirkyedi;
//   public MeshFilter kirksekiz;
//   public MeshFilter kirkdokuz;
//   public MeshFilter elli;
//   public MeshFilter ellibir;
//   public MeshFilter elliiki;
//   public MeshFilter elliuc;
//   public MeshFilter ellidort;
//   public MeshFilter ellibes;
//   public MeshFilter ellialti;
//   public MeshFilter elliyedi;
//   public MeshFilter ellisekiz;
//   public MeshFilter ellidokuz;
//   public MeshFilter atmis;
//   public MeshFilter atmisbir;
//   public MeshFilter atmisiki;
//   public MeshFilter atmisuc;
//   public MeshFilter atmisdort;
//   public MeshFilter atmisbes;
//   public MeshFilter atmisalti;
//   public MeshFilter atmisyedi;
//   public MeshFilter atmissekiz;
//   public MeshFilter atmisdokuz;
//   public MeshFilter yetmis;
//   public MeshFilter yetmisbir;
//   public MeshFilter yetmisiki;
//   public MeshFilter yetmisuc;
//   public MeshFilter yetmisdort;
//   public MeshFilter yetmisbes;
//   public MeshFilter yetmisalti;
//   public MeshFilter yetmisyedi;
//   public MeshFilter yetmissekiz;
//   public MeshFilter yetmisdokuz;
//   public MeshFilter seksen;
//   public MeshFilter seksenbir;
//   public MeshFilter sekseniki;
//   public MeshFilter seksenuc;
//   public MeshFilter seksendort;
//   public MeshFilter seksenbes;
//   public MeshFilter seksenalti;
//   public MeshFilter seksenyedi;
//   public MeshFilter seksensekiz;
//   public MeshFilter seksendokuz;
//   public MeshFilter doksan;
//   public MeshFilter doksanbir;
//   public MeshFilter doksaniki;
//   public MeshFilter doksanuc;
//   public MeshFilter doksandort;
//   public MeshFilter doksanbes;
//   public MeshFilter doksanalti;
//   public MeshFilter doksanyedi;
//   public MeshFilter doksansekiz;
//   public MeshFilter doksandokuz;
//
//     void Start()
//     {
//       DogruSpawn();
//     }
//
//     // Start is called before the first frame update
//     public void DogruSpawn()
//     {
//       if(soruSpawn.dogruCevap == 0)
//       {
//         sifir.gameObject.tag = "dogruCevap";
//         Instantiate(sifir, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 1)
//       {
//         bir.gameObject.tag = "dogruCevap";
//         Instantiate(bir, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 2)
//       {
//         iki.gameObject.tag = "dogruCevap";
//         Instantiate(iki, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 3)
//       {
//         uc.gameObject.tag = "dogruCevap";
//         Instantiate(uc, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 4)
//       {
//         dort.gameObject.tag = "dogruCevap";
//         Instantiate(dort, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 5)
//       {
//         bes.gameObject.tag = "dogruCevap";
//         Instantiate(bes, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 6)
//       {
//         alti.gameObject.tag = "dogruCevap";
//         Instantiate(alti, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 7)
//       {
//         yedi.gameObject.tag = "dogruCevap";
//         Instantiate(yedi, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 8)
//       {
//         sekiz.gameObject.tag = "dogruCevap";
//         Instantiate(sekiz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 9)
//       {
//         dokuz.gameObject.tag = "dogruCevap";
//         Instantiate(dokuz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 10)
//       {
//         on.gameObject.tag = "dogruCevap";
//         Instantiate(on, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 11)
//       {
//         onbir.gameObject.tag = "dogruCevap";
//         Instantiate(onbir, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 12)
//       {
//         oniki.gameObject.tag = "dogruCevap";
//         Instantiate(oniki, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 13)
//       {
//         onuc.gameObject.tag = "dogruCevap";
//         Instantiate(onuc, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 14)
//       {
//         ondort.gameObject.tag = "dogruCevap";
//         Instantiate(ondort, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 15)
//       {
//         onbes.gameObject.tag = "dogruCevap";
//         Instantiate(onbes, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 16)
//       {
//         onalti.gameObject.tag = "dogruCevap";
//         Instantiate(onalti, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 17)
//       {
//         onyedi.gameObject.tag = "dogruCevap";
//         Instantiate(onyedi, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 18)
//       {
//         onsekiz.gameObject.tag = "dogruCevap";
//         Instantiate(onsekiz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 19)
//       {
//         ondokuz.gameObject.tag = "dogruCevap";
//         Instantiate(ondokuz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 20)
//       {
//         yirmi.gameObject.tag = "dogruCevap";
//         Instantiate(yirmi, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 21)
//       {
//         yirmibir.gameObject.tag = "dogruCevap";
//         Instantiate(yirmibir, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 22)
//       {
//         yirmiiki.gameObject.tag = "dogruCevap";
//         Instantiate(yirmiiki, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 23)
//       {
//         yirmiuc.gameObject.tag = "dogruCevap";
//         Instantiate(yirmiuc, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 24)
//       {
//         yirmidort.gameObject.tag = "dogruCevap";
//         Instantiate(yirmidort, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 25)
//       {
//         yirmibes.gameObject.tag = "dogruCevap";
//         Instantiate(yirmibes, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 26)
//       {
//         yirmialti.gameObject.tag = "dogruCevap";
//         Instantiate(yirmialti, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 27)
//       {
//         yirmiyedi.gameObject.tag = "dogruCevap";
//         Instantiate(yirmiyedi, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 28)
//       {
//         yirmisekiz.gameObject.tag = "dogruCevap";
//         Instantiate(yirmisekiz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 29)
//       {
//         yirmidokuz.gameObject.tag = "dogruCevap";
//         Instantiate(yirmidokuz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 30)
//       {
//         otuz.gameObject.tag = "dogruCevap";
//         Instantiate(otuz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 31)
//       {
//         otuzbir.gameObject.tag = "dogruCevap";
//         Instantiate(otuzbir, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 32)
//       {
//         otuziki.gameObject.tag = "dogruCevap";
//         Instantiate(otuziki, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 33)
//       {
//         otuzuc.gameObject.tag = "dogruCevap";
//         Instantiate(otuzuc, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 34)
//       {
//         otuzdort.gameObject.tag = "dogruCevap";
//         Instantiate(otuzdort, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 35)
//       {
//         otuzbes.gameObject.tag = "dogruCevap";
//         Instantiate(otuzbes, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 36)
//       {
//         otuzalti.gameObject.tag = "dogruCevap";
//         Instantiate(otuzalti, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 37)
//       {
//         otuzyedi.gameObject.tag = "dogruCevap";
//         Instantiate(otuzyedi, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 38)
//       {
//         otuzsekiz.gameObject.tag = "dogruCevap";
//         Instantiate(otuzsekiz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 39)
//       {
//         otuzdokuz.gameObject.tag = "dogruCevap";
//         Instantiate(otuzdokuz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 40)
//       {
//         kirk.gameObject.tag = "dogruCevap";
//         Instantiate(kirk, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 41)
//       {
//         kirkbir.gameObject.tag = "dogruCevap";
//         Instantiate(kirkbir, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 42)
//       {
//         kirkiki.gameObject.tag = "dogruCevap";
//         Instantiate(kirkiki, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 43)
//       {
//         kirkuc.gameObject.tag = "dogruCevap";
//         Instantiate(kirkuc, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 44)
//       {
//         kirkdort.gameObject.tag = "dogruCevap";
//         Instantiate(kirkdort, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 45)
//       {
//         kirkbes.gameObject.tag = "dogruCevap";
//         Instantiate(kirkbes, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 46)
//       {
//         kirkalti.gameObject.tag = "dogruCevap";
//         Instantiate(kirkalti, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 47)
//       {
//         kirkyedi.gameObject.tag = "dogruCevap";
//         Instantiate(kirkyedi, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 48)
//       {
//         kirksekiz.gameObject.tag = "dogruCevap";
//         Instantiate(kirksekiz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 49)
//       {
//         kirkdokuz.gameObject.tag = "dogruCevap";
//         Instantiate(kirkdokuz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 50)
//       {
//         elli.gameObject.tag = "dogruCevap";
//         Instantiate(elli, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 51)
//       {
//         ellibir.gameObject.tag = "dogruCevap";
//         Instantiate(ellibir, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 52)
//       {
//         elliiki.gameObject.tag = "dogruCevap";
//         Instantiate(elliiki, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 53)
//       {
//         elliuc.gameObject.tag = "dogruCevap";
//         Instantiate(elliuc, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 54)
//       {
//         ellidort.gameObject.tag = "dogruCevap";
//         Instantiate(ellidort, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 55)
//       {
//         ellibes.gameObject.tag = "dogruCevap";
//         Instantiate(ellibes, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 56)
//       {
//         ellialti.gameObject.tag = "dogruCevap";
//         Instantiate(ellialti, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 57)
//       {
//         elliyedi.gameObject.tag = "dogruCevap";
//         Instantiate(elliyedi, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 58)
//       {
//         ellisekiz.gameObject.tag = "dogruCevap";
//         Instantiate(ellisekiz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 59)
//       {
//         ellidokuz.gameObject.tag = "dogruCevap";
//         Instantiate(ellidokuz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 60)
//       {
//         atmis.gameObject.tag = "dogruCevap";
//         Instantiate(atmis, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 61)
//       {
//         atmisbir.gameObject.tag = "dogruCevap";
//         Instantiate(atmisbir, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 62)
//       {
//         atmisiki.gameObject.tag = "dogruCevap";
//         Instantiate(atmisiki, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 63)
//       {
//         atmisuc.gameObject.tag = "dogruCevap";
//         Instantiate(atmisuc, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 64)
//       {
//         atmisdort.gameObject.tag = "dogruCevap";
//         Instantiate(atmisdort, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 65)
//       {
//         atmisbes.gameObject.tag = "dogruCevap";
//         Instantiate(atmisbes, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 66)
//       {
//         atmisalti.gameObject.tag = "dogruCevap";
//         Instantiate(atmisalti, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 67)
//       {
//         atmisyedi.gameObject.tag = "dogruCevap";
//         Instantiate(atmisyedi, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 68)
//       {
//         atmissekiz.gameObject.tag = "dogruCevap";
//         Instantiate(atmissekiz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 69)
//       {
//         atmisdokuz.gameObject.tag = "dogruCevap";
//         Instantiate(atmisdokuz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 70)
//       {
//         yetmis.gameObject.tag = "dogruCevap";
//         Instantiate(yetmis, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 71)
//       {
//         yetmisbir.gameObject.tag = "dogruCevap";
//         Instantiate(yetmisbir, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 72)
//       {
//         yetmisiki.gameObject.tag = "dogruCevap";
//         Instantiate(yetmisiki, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 73)
//       {
//         yetmisuc.gameObject.tag = "dogruCevap";
//         Instantiate(yetmisuc, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 74)
//       {
//         yetmisdort.gameObject.tag = "dogruCevap";
//         Instantiate(yetmisdort, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 75)
//       {
//         yetmisbes.gameObject.tag = "dogruCevap";
//         Instantiate(yetmisbes, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 76)
//       {
//         yetmisalti.gameObject.tag = "dogruCevap";
//         Instantiate(yetmisalti, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 77)
//       {
//         yetmisyedi.gameObject.tag = "dogruCevap";
//         Instantiate(yetmisyedi, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 78)
//       {
//         yetmissekiz.gameObject.tag = "dogruCevap";
//         Instantiate(yetmissekiz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 79)
//       {
//         yetmisdokuz.gameObject.tag = "dogruCevap";
//         Instantiate(yetmisdokuz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 80)
//       {
//         seksen.gameObject.tag = "dogruCevap";
//         Instantiate(seksen, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 81)
//       {
//         seksenbir.gameObject.tag = "dogruCevap";
//         Instantiate(seksenbir, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 82)
//       {
//         sekseniki.gameObject.tag = "dogruCevap";
//         Instantiate(sekseniki, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 83)
//       {
//         seksenuc.gameObject.tag = "dogruCevap";
//         Instantiate(seksenuc, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 84)
//       {
//         seksendort.gameObject.tag = "dogruCevap";
//         Instantiate(seksendort, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 85)
//       {
//         seksenbes.gameObject.tag = "dogruCevap";
//         Instantiate(seksenbes, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 86)
//       {
//         seksenalti.gameObject.tag = "dogruCevap";
//         Instantiate(seksenalti, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 87)
//       {
//         seksenyedi.gameObject.tag = "dogruCevap";
//         Instantiate(seksenyedi, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 88)
//       {
//         seksensekiz.gameObject.tag = "dogruCevap";
//         Instantiate(seksensekiz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 89)
//       {
//         seksendokuz.gameObject.tag = "dogruCevap";
//         Instantiate(seksendokuz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 90)
//       {
//         doksan.gameObject.tag = "dogruCevap";
//         Instantiate(doksan, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 91)
//       {
//         doksanbir.gameObject.tag = "dogruCevap";
//         Instantiate(doksanbir, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 92)
//       {
//         doksaniki.gameObject.tag = "dogruCevap";
//         Instantiate(doksaniki, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 93)
//       {
//         doksanuc.gameObject.tag = "dogruCevap";
//         Instantiate(doksanuc, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 94)
//       {
//         doksandort.gameObject.tag = "dogruCevap";
//         Instantiate(doksandort, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 95)
//       {
//         doksanbes.gameObject.tag = "dogruCevap";
//         Instantiate(doksanbes, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 96)
//       {
//         doksanalti.gameObject.tag = "dogruCevap";
//         Instantiate(doksanalti, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 97)
//       {
//         doksanyedi.gameObject.tag = "dogruCevap";
//         Instantiate(doksanyedi, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 98)
//       {
//         doksansekiz.gameObject.tag = "dogruCevap";
//         Instantiate(doksansekiz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.dogruCevap == 99)
//       {
//         doksandokuz.gameObject.tag = "dogruCevap";
//         Instantiate(doksandokuz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
//       }
//
//
//
//
//
//     }
//
//     // Update is called once per frame
//     void Update()
//     {
//
//     }
// }
