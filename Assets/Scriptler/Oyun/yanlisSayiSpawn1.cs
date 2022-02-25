//bu dosyadaki her şey aracSoru scriptine aktarılmıştır

// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
//
// public class yanlisSayiSpawn1 : MonoBehaviour
// {
//
//   //public float yanlisXDeger = -dogruSayiSpawn.dogruXDeger;
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
//
//     void Start()
//     {
//       YanlisSpawn();
//     }
//
//     // Start is called before the first frame update
//     public void YanlisSpawn()
//     {
//       if(soruSpawn.yanlisCevap == 0)
//       {
//         sifir.gameObject.tag = "yanlisCevap";
//         Instantiate(sifir, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 1)
//       {
//         bir.gameObject.tag = "yanlisCevap";
//         Instantiate(bir, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 2)
//       {
//         iki.gameObject.tag = "yanlisCevap";
//         Instantiate(iki, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 3)
//       {
//         uc.gameObject.tag = "yanlisCevap";
//         Instantiate(uc, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 4)
//       {
//         dort.gameObject.tag = "yanlisCevap";
//         Instantiate(dort, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 5)
//       {
//         bes.gameObject.tag = "yanlisCevap";
//         Instantiate(bes, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 6)
//       {
//         alti.gameObject.tag = "yanlisCevap";
//         Instantiate(alti, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 7)
//       {
//         yedi.gameObject.tag = "yanlisCevap";
//         Instantiate(yedi, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 8)
//       {
//         sekiz.gameObject.tag = "yanlisCevap";
//         Instantiate(sekiz, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 9)
//       {
//         dokuz.gameObject.tag = "yanlisCevap";
//         Instantiate(dokuz, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 10)
//       {
//         on.gameObject.tag = "yanlisCevap";
//         Instantiate(on, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 11)
//       {
//         onbir.gameObject.tag = "yanlisCevap";
//         Instantiate(onbir, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 12)
//       {
//         oniki.gameObject.tag = "yanlisCevap";
//         Instantiate(oniki, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 13)
//       {
//         onuc.gameObject.tag = "yanlisCevap";
//         Instantiate(onuc, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 14)
//       {
//         ondort.gameObject.tag = "yanlisCevap";
//         Instantiate(ondort, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 15)
//       {
//         onbes.gameObject.tag = "yanlisCevap";
//         Instantiate(onbes, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 16)
//       {
//         onalti.gameObject.tag = "yanlisCevap";
//         Instantiate(onalti, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 17)
//       {
//         onyedi.gameObject.tag = "yanlisCevap";
//         Instantiate(onyedi, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 18)
//       {
//         onsekiz.gameObject.tag = "yanlisCevap";
//         Instantiate(onsekiz, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 19)
//       {
//         ondokuz.gameObject.tag = "yanlisCevap";
//         Instantiate(ondokuz, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 20)
//       {
//         yirmi.gameObject.tag = "yanlisCevap";
//         Instantiate(yirmi, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 21)
//       {
//         yirmibir.gameObject.tag = "yanlisCevap";
//         Instantiate(yirmibir, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 22)
//       {
//         yirmiiki.gameObject.tag = "yanlisCevap";
//         Instantiate(yirmiiki, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 23)
//       {
//         yirmiuc.gameObject.tag = "yanlisCevap";
//         Instantiate(yirmiuc, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 24)
//       {
//         yirmidort.gameObject.tag = "yanlisCevap";
//         Instantiate(yirmidort, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 25)
//       {
//         yirmibes.gameObject.tag = "yanlisCevap";
//         Instantiate(yirmibes, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 26)
//       {
//         yirmialti.gameObject.tag = "yanlisCevap";
//         Instantiate(yirmialti, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 27)
//       {
//         yirmiyedi.gameObject.tag = "yanlisCevap";
//         Instantiate(yirmiyedi, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 28)
//       {
//         yirmisekiz.gameObject.tag = "yanlisCevap";
//         Instantiate(yirmisekiz, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 29)
//       {
//         yirmidokuz.gameObject.tag = "yanlisCevap";
//         Instantiate(yirmidokuz, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 30)
//       {
//         otuz.gameObject.tag = "yanlisCevap";
//         Instantiate(otuz, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 31)
//       {
//         otuzbir.gameObject.tag = "yanlisCevap";
//         Instantiate(otuzbir, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 32)
//       {
//         otuziki.gameObject.tag = "yanlisCevap";
//         Instantiate(otuziki, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 33)
//       {
//         otuzuc.gameObject.tag = "yanlisCevap";
//         Instantiate(otuzuc, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 34)
//       {
//         otuzdort.gameObject.tag = "yanlisCevap";
//         Instantiate(otuzdort, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 35)
//       {
//         otuzbes.gameObject.tag = "yanlisCevap";
//         Instantiate(otuzbes, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 36)
//       {
//         otuzalti.gameObject.tag = "yanlisCevap";
//         Instantiate(otuzalti, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 37)
//       {
//         otuzyedi.gameObject.tag = "yanlisCevap";
//         Instantiate(otuzyedi, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 38)
//       {
//         otuzsekiz.gameObject.tag = "yanlisCevap";
//         Instantiate(otuzsekiz, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 39)
//       {
//         otuzdokuz.gameObject.tag = "yanlisCevap";
//         Instantiate(otuzdokuz, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 40)
//       {
//         kirk.gameObject.tag = "yanlisCevap";
//         Instantiate(kirk, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 41)
//       {
//         kirkbir.gameObject.tag = "yanlisCevap";
//         Instantiate(kirkbir, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 42)
//       {
//         kirkiki.gameObject.tag = "dogruCevap";
//         Instantiate(kirkiki, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 43)
//       {
//         kirkuc.gameObject.tag = "yanlisCevap";
//         Instantiate(kirkuc, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 44)
//       {
//         kirkdort.gameObject.tag = "yanlisCevap";
//         Instantiate(kirkdort, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 45)
//       {
//         kirkbes.gameObject.tag = "yanlisCevap";
//         Instantiate(kirkbes, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 46)
//       {
//         kirkalti.gameObject.tag = "yanlisCevap";
//         Instantiate(kirkalti, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 47)
//       {
//         kirkyedi.gameObject.tag = "yanlisCevap";
//         Instantiate(kirkyedi, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 48)
//       {
//         kirksekiz.gameObject.tag = "yanlisCevap";
//         Instantiate(kirksekiz, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 49)
//       {
//         kirkdokuz.gameObject.tag = "yanlisCevap";
//         Instantiate(kirkdokuz, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 50)
//       {
//         elli.gameObject.tag = "yanlisCevap";
//         Instantiate(elli, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 51)
//       {
//         ellibir.gameObject.tag = "yanlisCevap";
//         Instantiate(ellibir, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 52)
//       {
//         elliiki.gameObject.tag = "yanlisCevap";
//         Instantiate(elliiki, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 53)
//       {
//         elliuc.gameObject.tag = "yanlisCevap";
//         Instantiate(elliuc, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 54)
//       {
//         ellidort.gameObject.tag = "yanlisCevap";
//         Instantiate(ellidort, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 55)
//       {
//         ellibes.gameObject.tag = "yanlisCevap";
//         Instantiate(ellibes, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 56)
//       {
//         ellialti.gameObject.tag = "yanlisCevap";
//         Instantiate(ellialti, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 57)
//       {
//         elliyedi.gameObject.tag = "yanlisCevap";
//         Instantiate(elliyedi, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 58)
//       {
//         ellisekiz.gameObject.tag = "yanlisCevap";
//         Instantiate(ellisekiz, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 59)
//       {
//         ellidokuz.gameObject.tag = "yanlisCevap";
//         Instantiate(ellidokuz, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 60)
//       {
//         atmis.gameObject.tag = "yanlisCevap";
//         Instantiate(atmis, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 61)
//       {
//         atmisbir.gameObject.tag = "yanlisCevap";
//         Instantiate(atmisbir, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 62)
//       {
//         atmisiki.gameObject.tag = "yanlisCevap";
//         Instantiate(atmisiki, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 63)
//       {
//         atmisuc.gameObject.tag = "yanlisCevap";
//         Instantiate(atmisuc, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 64)
//       {
//         atmisdort.gameObject.tag = "yanlisCevap";
//         Instantiate(atmisdort, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 65)
//       {
//         atmisbes.gameObject.tag = "yanlisCevap";
//         Instantiate(atmisbes, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 66)
//       {
//         atmisalti.gameObject.tag = "yanlisCevap";
//         Instantiate(atmisalti, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 67)
//       {
//         atmisyedi.gameObject.tag = "yanlisCevap";
//         Instantiate(atmisyedi, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 68)
//       {
//         atmissekiz.gameObject.tag = "yanlisCevap";
//         Instantiate(atmissekiz, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 69)
//       {
//         atmisdokuz.gameObject.tag = "yanlisCevap";
//         Instantiate(atmisdokuz, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 70)
//       {
//         yetmis.gameObject.tag = "yanlisCevap";
//         Instantiate(yetmis, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 71)
//       {
//         yetmisbir.gameObject.tag = "yanlisCevap";
//         Instantiate(yetmisbir, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 72)
//       {
//         yetmisiki.gameObject.tag = "yanlisCevap";
//         Instantiate(yetmisiki, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 73)
//       {
//         yetmisuc.gameObject.tag = "yanlisCevap";
//         Instantiate(yetmisuc, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 74)
//       {
//         yetmisdort.gameObject.tag = "yanlisCevap";
//         Instantiate(yetmisdort, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 75)
//       {
//         yetmisbes.gameObject.tag = "yanlisCevap";
//         Instantiate(yetmisbes, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 76)
//       {
//         yetmisalti.gameObject.tag = "yanlisCevap";
//         Instantiate(yetmisalti, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 77)
//       {
//         yetmisyedi.gameObject.tag = "yanlisCevap";
//         Instantiate(yetmisyedi, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 78)
//       {
//         yetmissekiz.gameObject.tag = "yanlisCevap";
//         Instantiate(yetmissekiz, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 79)
//       {
//         yetmisdokuz.gameObject.tag = "yanlisCevap";
//         Instantiate(yetmisdokuz, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 80)
//       {
//         seksen.gameObject.tag = "yanlisCevap";
//         Instantiate(seksen, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 81)
//       {
//         seksenbir.gameObject.tag = "yanlisCevap";
//         Instantiate(seksenbir, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 82)
//       {
//         sekseniki.gameObject.tag = "yanlisCevap";
//         Instantiate(sekseniki, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 83)
//       {
//         seksenuc.gameObject.tag = "yanlisCevap";
//         Instantiate(seksenuc, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 84)
//       {
//         seksendort.gameObject.tag = "yanlisCevap";
//         Instantiate(seksendort, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 85)
//       {
//         seksenbes.gameObject.tag = "yanlisCevap";
//         Instantiate(seksenbes, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 86)
//       {
//         seksenalti.gameObject.tag = "yanlisCevap";
//         Instantiate(seksenalti, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 87)
//       {
//         seksenyedi.gameObject.tag = "yanlisCevap";
//         Instantiate(seksenyedi, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 88)
//       {
//         seksensekiz.gameObject.tag = "yanlisCevap";
//         Instantiate(seksensekiz, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 89)
//       {
//         seksendokuz.gameObject.tag = "yanlisCevap";
//         Instantiate(seksendokuz, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 90)
//       {
//         doksan.gameObject.tag = "yanlisCevap";
//         Instantiate(doksan, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 91)
//       {
//         doksanbir.gameObject.tag = "yanlisCevap";
//         Instantiate(doksanbir, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 92)
//       {
//         doksaniki.gameObject.tag = "yanlisCevap";
//         Instantiate(doksaniki, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 93)
//       {
//         doksanuc.gameObject.tag = "yanlisCevap";
//         Instantiate(doksanuc, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 94)
//       {
//         doksandort.gameObject.tag = "yanlisCevap";
//         Instantiate(doksandort, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 95)
//       {
//         doksanbes.gameObject.tag = "yanlisCevap";
//         Instantiate(doksanbes, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 96)
//       {
//         doksanalti.gameObject.tag = "yanlisCevap";
//         Instantiate(doksanalti, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 97)
//       {
//         doksanyedi.gameObject.tag = "yanlisCevap";
//         Instantiate(doksanyedi, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 98)
//       {
//         doksansekiz.gameObject.tag = "yanlisCevap";
//         Instantiate(doksansekiz, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
//       }
//
//       if(soruSpawn.yanlisCevap == 99)
//       {
//         doksandokuz.gameObject.tag = "yanlisCevap";
//         Instantiate(doksandokuz, new Vector3 (-dogruSayiSpawn.dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
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
