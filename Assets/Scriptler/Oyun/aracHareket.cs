using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aracHareket : MonoBehaviour
{

    public static float hassasiyet = 7f;
    public float surat = 1f;

    void FixedUpdate()
    {
        float yatayHareket = Input.GetAxis("Horizontal"); // aracın yatay hareketi için girdilerini belirledim.
        float yatayArtis = yatayHareket * hassasiyet;


        transform.Translate(Vector3.forward * Time.deltaTime * surat);

        if(Input.GetKey("a") || Input.GetKey("d")) // a ve d tuşları sağ ve sol hareketi belirler
        {
          transform.Translate(Vector3.right * yatayArtis * Time.deltaTime);
        }
    }


}
