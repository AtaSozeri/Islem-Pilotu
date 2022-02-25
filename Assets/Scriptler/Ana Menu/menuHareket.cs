using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuHareket : MonoBehaviour
{

    public float surat = 1f;

    void FixedUpdate()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * surat); //öne hareket komudu
    }


}
