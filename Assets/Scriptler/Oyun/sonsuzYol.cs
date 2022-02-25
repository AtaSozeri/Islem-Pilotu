using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sonsuzYol : MonoBehaviour
{

    float yolUzunluk = 378f;
    //hazırladığım yolun "z" eksenindeki uzunluğu 378 birim.

    void OnTriggerEnter(Collider carpan)
    {
      switch(carpan.gameObject.tag)
      {
        case "oyuncu":
        transform.position += new Vector3(0, 0, yolUzunluk * 4);
        //aynı anda dört eş yol modeli kullandığım için bir modeli geçtiğimde "z" eksenindeki değere kendi uzunluğunun dört katı kadar birim ekledim.
        break;
      }
    }
}
