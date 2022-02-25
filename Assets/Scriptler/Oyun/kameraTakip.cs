using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameraTakip : MonoBehaviour
{

    public Transform kameraPoz;
    public float kameraFark;

    void Update()
    {
        kameraPoz.position = new Vector3(kameraPoz.localPosition.x, kameraPoz.localPosition.y, transform.localPosition.z -kameraFark);
        // bu scripti aracın üstüne koydum ve bu şekilde aracın "y" ve "x" koordinatları fark etmeksizin kameranın "z" değerini değiştirebildim.
    }
}
