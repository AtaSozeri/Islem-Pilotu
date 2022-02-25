using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(AudioSource))]
public class aracSoru : MonoBehaviour
{

    public AudioClip yanlisSes;
    public AudioClip dogruSes;
    AudioSource sesKaynagi;

    public GameObject kaybetmeMenusu;

    public enum StateBir {soruMevcut, soruHazirlik, dogru, yanlis};
    public StateBir durum = StateBir.soruHazirlik;

    public enum State {bir, iki, uc, dort, bes, alti, yedi};
    public State seviye=State.bir;

    public float cevapPoz;
    private Transform dogru;
    private Transform yanlis;


    public TextMeshProUGUI soru;
    public TextMeshProUGUI oyuncuPuan;

    public int solSayi;
    public int sagSayi;

    public int islem;

    public static float soruSuresi = 5f;

    public int dogruCevap;
    public int yanlisCevap;

    public float dogruXDeger;
    [SerializeField] Transform arac;

    [SerializeField] bool birKerelik = false;
    [SerializeField] bool birKerelikIki= false;

    public static float puan = 0;

    void Awake()
    {

    }

    void AraMetod()
    {
      durum = StateBir.soruMevcut;
      birKerelik = true;
    }

    void FixedUpdate() //seviyeye göre puan ekleme, esc tuşu ile oyun durdurma, puan yazısı ve araç durum kodları
    {

      if(Input.GetKeyDown(KeyCode.Escape))
      {
        Time.timeScale = 0;
        kaybetmeMenusu.gameObject.SetActive(true);
      }

      oyuncuPuan.text = "Puan: " + puan.ToString();

      if(yanlisCevap < 0){SoruYarat();}

      if(puan <= 10)
      {seviye = State.bir;}

      if(puan > 25)
      {seviye = State.iki;}

      if(puan > 50)
      {seviye = State.uc;}

      if(puan > 85)
      {seviye = State.dort;}

      if(puan > 110)
      {seviye = State.bes;}

      if(puan > 145)
      {seviye = State.alti;}

      if(puan > 200)
      {seviye = State.yedi;}

      switch(durum)
      {
        case StateBir.soruHazirlik:
        if(!birKerelik)
        {
          islem = Random.Range(0,4);
          cevapPoz = Random.Range(0,2);
          if(cevapPoz == 0)
          {dogruXDeger = 5f;}
          else
          {dogruXDeger = -5f;}

          if(transform.localPosition.x > 0.2 || transform.localPosition.x < -0.2){transform.localPosition = new Vector3 (0, transform.localPosition.y, transform.localPosition.z);}

          Invoke ("AraMetod", 1f);
          birKerelikIki = false;
        }
        break;

        case StateBir.soruMevcut:
        if(!birKerelikIki)
        {
          while(dogruCevap == yanlisCevap || yanlisCevap < 0)
          {
            SoruYarat();
            Destroy(GameObject.FindWithTag("dogruCevap"));
            Destroy(GameObject.FindWithTag("yanlisCevap"));
            if(transform.localPosition.x > 0.2 || transform.localPosition.x < -0.2){transform.localPosition = new Vector3 (0, transform.localPosition.y, transform.localPosition.z);}
          }
          Invoke("DogruSpawn", 0.6f);
          Invoke("YanlisSpawn", 0.6f);
          Invoke("AracHareketEttir", 0.7f);
          while(dogruCevap == 0 && yanlisCevap == 0){transform.localPosition = new Vector3 (0, transform.localPosition.y, transform.localPosition.z);}
          birKerelikIki = true;
          geriSayim.guncelSure = soruSuresi;
        }
        GameObject.FindWithTag("dogruCevap").transform.position = new Vector3(dogruXDeger, transform.position.y, transform.position.z + 4);
        GameObject.FindWithTag("yanlisCevap").transform.position = new Vector3(-dogruXDeger, transform.position.y, transform.position.z + 4);
        if(geriSayim.guncelSure <= 0)
        {
          durum = StateBir.yanlis;
        }
        break;

        case StateBir.dogru:
        Invoke("DegerResetle", 0.1f);
        transform.position = new Vector3(0, transform.localPosition.y, transform.localPosition.z);
        aracHareket.hassasiyet = 0f;
        durum = StateBir.soruHazirlik;
        break;

        case StateBir.yanlis:
        Destroy(GameObject.FindWithTag("dogruCevap"));
        Destroy(GameObject.FindWithTag("yanlisCevap"));
        Invoke("HerSeyiDurdur" , 0.1f);
        kaybetmeMenusu.gameObject.SetActive(true);
        break;
      }
    }

    void AracHareketEttir()
    {
      aracHareket.hassasiyet = 7f;
    }

    void HerSeyiDurdur()
    {Time.timeScale = 0;}

    void DegerResetle() //değer resetlemek için metod
    {
      solSayi = 0;
      sagSayi = 0;
      dogruCevap = 0;
      yanlisCevap = 0;
      geriSayim.guncelSure = 5f;
    }

    void OnTriggerEnter(Collider carpisma) //araçın çarpışma kodları (doğru ve yanlış obje ile)
    {
      switch(carpisma.gameObject.tag)
      {
        case "dogruCevap":
        Destroy(GameObject.FindWithTag("dogruCevap"));
        Destroy(GameObject.FindWithTag("yanlisCevap"));
        birKerelik = false;
        durum = StateBir.dogru;
        Debug.Log("dogru");
        sesKaynagi.PlayOneShot(dogruSes, 0.2f);
        switch(seviye)
        {
          case State.bir:
          puan += 4;
          break;

          case State.iki:
          puan += 6;
          break;

          case State.uc:
          puan += 8;
          break;

          case State.dort:
          puan += 10;
          break;

          case State.bes:
          puan += 12;
          break;

          case State.alti:
          puan += 14;
          break;

          case State.yedi:
          puan += 16;
          break;
        }
        break;

        case "yanlisCevap":
        durum = StateBir.yanlis;
        sesKaynagi.PlayOneShot(yanlisSes, 0.2f);
        Debug.Log("yanlis");
        break;
      }
    }

    void Start()
    {
      sesKaynagi = GetComponent<AudioSource>();
    }

    void SoruYarat() //seviyeye göre sol sayı, sağ sayı, doğru ve yanlış cevap belirleme kodları
    {
      switch (seviye)
      {
        case State.bir:
        switch (islem)
        {
          case 0:
          while(dogruCevap == yanlisCevap || yanlisCevap < 0)
          {
          solSayi = Random.Range(0, 10);
          sagSayi = Random.Range(0,10);
          dogruCevap = solSayi + sagSayi;
          yanlisCevap = dogruCevap + Random.Range(-2,3);
          soru.text = solSayi.ToString() + " + " + sagSayi.ToString();
          soruSuresi = 5f;
          return;
          }
          break;

          case 1:
          while(dogruCevap == yanlisCevap || yanlisCevap < 0)
          {
          solSayi = Random.Range(0, 10);
          sagSayi = Random.Range(0,10);
          dogruCevap = solSayi + sagSayi;
          yanlisCevap = dogruCevap + Random.Range(-2,3);
          soru.text = solSayi.ToString() + " + " + sagSayi.ToString();
          soruSuresi = 5f;
          return;
          }
          break;

          case 2:
          while(dogruCevap == yanlisCevap || yanlisCevap < 0)
          {
          solSayi = Random.Range(1,5);
          sagSayi = Random.Range(1,5);
          dogruCevap = solSayi * sagSayi;
          yanlisCevap = (solSayi + Random.Range(-2,2)) * sagSayi;
          soru.text = solSayi.ToString() + " x " + sagSayi.ToString();
          soruSuresi = 5f;
          return;
          }
          break;

          case 3:
          while(dogruCevap == yanlisCevap || yanlisCevap < 0)
          {
          solSayi = Random.Range(1,5);
          sagSayi = Random.Range(1,10);
          dogruCevap = solSayi * sagSayi;
          yanlisCevap = (solSayi + Random.Range(-2,2)) * sagSayi;
          soru.text = solSayi.ToString() + " x " + sagSayi.ToString();
          soruSuresi = 7f;
          return;
          }
          break;
        }
        break;

        case State.iki:
        switch (islem)
        {
          case 0:
          while(dogruCevap == yanlisCevap || yanlisCevap < 0)
          {
          solSayi = Random.Range(0,20);
          sagSayi = Random.Range(0,20);
          dogruCevap = solSayi + sagSayi;
          yanlisCevap = dogruCevap + Random.Range(-4,6);
          soru.text = solSayi.ToString() + " + " + sagSayi.ToString();
          soruSuresi = 5f;
          }
          break;

          case 1:
          while(solSayi < sagSayi || dogruCevap == yanlisCevap || yanlisCevap < 0)
          {
          solSayi = Random.Range(0,20);
          sagSayi = Random.Range(0,20);
          dogruCevap = solSayi - sagSayi;
          yanlisCevap = dogruCevap + Random.Range(-5,5);
          soru.text = solSayi.ToString() + " - " + sagSayi.ToString();
          soruSuresi = 5f;
          }
          break;

          case 2:
          while(dogruCevap == yanlisCevap || yanlisCevap < 0)
          {
          solSayi = Random.Range(1,10);
          sagSayi = Random.Range(1,10);
          dogruCevap = solSayi * sagSayi;
          yanlisCevap = (solSayi + Random.Range(-2,2)) * sagSayi;
          soru.text = solSayi.ToString() + " x " + sagSayi.ToString();
          soruSuresi = 7f;
          }
          break;

          case 3:
          while(dogruCevap == yanlisCevap || yanlisCevap < 0)
          {
          solSayi = Random.Range(1,10);
          sagSayi = Random.Range(1,10);
          dogruCevap = solSayi * sagSayi;
          yanlisCevap = (solSayi + Random.Range(-2,2)) * sagSayi;
          soru.text = solSayi.ToString() + " x " + sagSayi.ToString();
          soruSuresi = 7f;
          }
          break;
        }
        break;

        case State.uc:
        switch (islem)
        {
          case 0:
          while(dogruCevap == yanlisCevap || yanlisCevap < 0)
          {
          solSayi = Random.Range(10,30);
          sagSayi = Random.Range(10,30);
          dogruCevap = solSayi + sagSayi;
          yanlisCevap = dogruCevap + Random.Range(-5,7);
          soru.text = solSayi.ToString() + " + " + sagSayi.ToString();
          soruSuresi = 5f;
          }
          break;

          case 1:
          while(solSayi < sagSayi || dogruCevap == yanlisCevap || yanlisCevap < 0)
          {
          solSayi = Random.Range(10,30);
          sagSayi = Random.Range(10,30);
          dogruCevap = solSayi - sagSayi;
          yanlisCevap = dogruCevap + Random.Range(-5,6);
          soru.text = solSayi.ToString() + " - " + sagSayi.ToString();
          soruSuresi = 5f;
          }
          break;

          case 2:
          while(dogruCevap == yanlisCevap || yanlisCevap < 0)
          {
          solSayi = Random.Range(1,15);
          sagSayi = Random.Range(1,7);
          dogruCevap = solSayi * sagSayi;
          yanlisCevap = (solSayi + Random.Range(-2,2)) * sagSayi;
          soru.text = solSayi.ToString() + " x " + sagSayi.ToString();
          soruSuresi = 6f;
          }
          break;

          case 3:
          while(dogruCevap == yanlisCevap || yanlisCevap < 0)
          {
          solSayi = Random.Range(10,30);
          sagSayi = Random.Range(10,30);
          dogruCevap = solSayi + sagSayi;
          yanlisCevap = dogruCevap + Random.Range(-5,7);
          soru.text = solSayi.ToString() + " + " + sagSayi.ToString();
          soruSuresi = 5f;
          }
          break;
        }
        break;

        case State.dort:
        switch (islem)
        {
          case 0:
          while(dogruCevap == yanlisCevap || yanlisCevap < 0)
          {
          solSayi = Random.Range(15,40);
          sagSayi = Random.Range(15,40);
          dogruCevap = solSayi + sagSayi;
          yanlisCevap = dogruCevap + Random.Range(-5,7);
          soru.text = solSayi.ToString() + " + " + sagSayi.ToString();
          soruSuresi = 5f;
          }
          break;

          case 1:
          while(solSayi < sagSayi || dogruCevap == yanlisCevap || yanlisCevap < 0)
          {
          solSayi = Random.Range(15,40);
          sagSayi = Random.Range(10,40);
          dogruCevap = solSayi - sagSayi;
          yanlisCevap = dogruCevap + Random.Range(-5,6);
          soru.text = solSayi.ToString() + " - " + sagSayi.ToString();
          soruSuresi = 5f;
          }
          break;

          case 2:
          while(dogruCevap == yanlisCevap || yanlisCevap < 0)
          {
          solSayi = Random.Range(1,19);
          sagSayi = Random.Range(1,5);
          dogruCevap = solSayi * sagSayi;
          yanlisCevap = (solSayi + Random.Range(-2,2)) * sagSayi;
          soru.text = solSayi.ToString() + " x " + sagSayi.ToString();
          soruSuresi = 6f;
          }
          break;

          case 3:
          while(dogruCevap == yanlisCevap || yanlisCevap < 0)
          {
          solSayi = Random.Range(1,19);
          sagSayi = Random.Range(1,5);
          dogruCevap = solSayi * sagSayi;
          yanlisCevap = (solSayi + Random.Range(-2,2)) * sagSayi;
          soru.text = solSayi.ToString() + " x " + sagSayi.ToString();
          soruSuresi = 6f;
          }
          break;
        }
        break;

        case State.bes:
        switch (islem)
        {
          case 0:
          while(dogruCevap == yanlisCevap || yanlisCevap < 0)
          {
          solSayi = Random.Range(15,49);
          sagSayi = Random.Range(15,49);
          dogruCevap = solSayi + sagSayi;
          yanlisCevap = dogruCevap + Random.Range(-7,9);
          soru.text = solSayi.ToString() + " + " + sagSayi.ToString();
          soruSuresi = 5f;
          }
          break;

          case 1:
          while(solSayi < sagSayi || dogruCevap == yanlisCevap || yanlisCevap < 0)
          {
          solSayi = Random.Range(15,49);
          sagSayi = Random.Range(10,49);
          dogruCevap = solSayi - sagSayi;
          yanlisCevap = dogruCevap + Random.Range(-5,6);
          soru.text = solSayi.ToString() + " - " + sagSayi.ToString();
          soruSuresi = 5f;
          }
          break;

          case 2:
          while(dogruCevap == yanlisCevap || yanlisCevap < 0)
          {
          solSayi = Random.Range(1,19);
          sagSayi = Random.Range(1,5);
          dogruCevap = solSayi * sagSayi;
          yanlisCevap = (solSayi + Random.Range(-2,2)) * sagSayi;
          soru.text = solSayi.ToString() + " x " + sagSayi.ToString();
          soruSuresi = 5f;
          }
          break;

          case 3:
          while(solSayi < sagSayi || dogruCevap == yanlisCevap || yanlisCevap < 0)
          {
          solSayi = Random.Range(15,49);
          sagSayi = Random.Range(10,49);
          dogruCevap = solSayi - sagSayi;
          yanlisCevap = dogruCevap + Random.Range(-5,6);
          soru.text = solSayi.ToString() + " - " + sagSayi.ToString();
          soruSuresi = 5f;
          }
          break;
        }
        break;

        case State.alti:
        switch (islem)
        {
          case 0:
          while(dogruCevap == yanlisCevap || yanlisCevap < 0)
          {
          solSayi = Random.Range(15,49);
          sagSayi = Random.Range(15,49);
          dogruCevap = solSayi + sagSayi;
          yanlisCevap = dogruCevap + Random.Range(-7,9);
          soru.text = solSayi.ToString() + " + " + sagSayi.ToString();
          soruSuresi = 4f;
          }
          break;

          case 1:
          while(solSayi < sagSayi || dogruCevap == yanlisCevap || yanlisCevap < 0)
          {
          solSayi = Random.Range(15,49);
          sagSayi = Random.Range(10,49);
          dogruCevap = solSayi - sagSayi;
          yanlisCevap = dogruCevap + Random.Range(-5,6);
          soru.text = solSayi.ToString() + " - " + sagSayi.ToString();
          soruSuresi = 4f;
          }
          break;

          case 2:
          while(dogruCevap == yanlisCevap || yanlisCevap < 0)
          {
          solSayi = Random.Range(1,19);
          sagSayi = Random.Range(1,5);
          dogruCevap = solSayi * sagSayi;
          yanlisCevap = (solSayi + Random.Range(-2,2)) * sagSayi;
          soru.text = solSayi.ToString() + " x " + sagSayi.ToString();
          soruSuresi = 4f;
          }
          break;

          case 3:
          while(dogruCevap == yanlisCevap || yanlisCevap < 0)
          {
          solSayi = Random.Range(15,49);
          sagSayi = Random.Range(15,49);
          dogruCevap = solSayi + sagSayi;
          yanlisCevap = dogruCevap + Random.Range(-7,9);
          soru.text = solSayi.ToString() + " + " + sagSayi.ToString();
          soruSuresi = 4f;
          }
          break;
        }
        break;

        case State.yedi:
        switch (islem)
        {
          case 0:
          while(dogruCevap == yanlisCevap || yanlisCevap < 0)
          {
          solSayi = Random.Range(15,49);
          sagSayi = Random.Range(15,49);
          dogruCevap = solSayi + sagSayi;
          yanlisCevap = dogruCevap + Random.Range(-7,9);
          soru.text = solSayi.ToString() + " + " + sagSayi.ToString();
          soruSuresi = 3f;
          }
          break;

          case 1:
          while(solSayi < sagSayi || dogruCevap == yanlisCevap || yanlisCevap < 0)
          {
          solSayi = Random.Range(15,49);
          sagSayi = Random.Range(10,49);
          dogruCevap = solSayi - sagSayi;
          yanlisCevap = dogruCevap + Random.Range(-5,6);
          soru.text = solSayi.ToString() + " - " + sagSayi.ToString();
          soruSuresi = 3f;
          }
          break;

          case 2:
          while(dogruCevap == yanlisCevap || yanlisCevap < 0)
          {
          solSayi = Random.Range(1,19);
          sagSayi = Random.Range(1,5);
          dogruCevap = solSayi * sagSayi;
          yanlisCevap = (solSayi + Random.Range(-2,2)) * sagSayi;
          soru.text = solSayi.ToString() + " x " + sagSayi.ToString();
          soruSuresi = 3f;
          }
          break;

          case 3:
          while(dogruCevap == yanlisCevap || yanlisCevap < 0)
          {
          solSayi = Random.Range(1,19);
          sagSayi = Random.Range(1,5);
          dogruCevap = solSayi * sagSayi;
          yanlisCevap = (solSayi + Random.Range(-2,2)) * sagSayi;
          soru.text = solSayi.ToString() + " x " + sagSayi.ToString();
          soruSuresi = 3f;
          }
          break;
        }
        break;

      }
    }

    void DogruSpawn() //doğru cevaba göre obje spawn kodları
    {
      if(dogruCevap == 0)
      {
        sifir.gameObject.tag = "dogruCevap";
        Instantiate(sifir, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 1)
      {
        bir.gameObject.tag = "dogruCevap";
        Instantiate(bir, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 2)
      {
        iki.gameObject.tag = "dogruCevap";
        Instantiate(iki, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 3)
      {
        uc.gameObject.tag = "dogruCevap";
        Instantiate(uc, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 4)
      {
        dort.gameObject.tag = "dogruCevap";
        Instantiate(dort, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 5)
      {
        bes.gameObject.tag = "dogruCevap";
        Instantiate(bes, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 6)
      {
        alti.gameObject.tag = "dogruCevap";
        Instantiate(alti, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 7)
      {
        yedi.gameObject.tag = "dogruCevap";
        Instantiate(yedi, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 8)
      {
        sekiz.gameObject.tag = "dogruCevap";
        Instantiate(sekiz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 9)
      {
        dokuz.gameObject.tag = "dogruCevap";
        Instantiate(dokuz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 10)
      {
        on.gameObject.tag = "dogruCevap";
        Instantiate(on, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 11)
      {
        onbir.gameObject.tag = "dogruCevap";
        Instantiate(onbir, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 12)
      {
        oniki.gameObject.tag = "dogruCevap";
        Instantiate(oniki, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 13)
      {
        onuc.gameObject.tag = "dogruCevap";
        Instantiate(onuc, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 14)
      {
        ondort.gameObject.tag = "dogruCevap";
        Instantiate(ondort, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 15)
      {
        onbes.gameObject.tag = "dogruCevap";
        Instantiate(onbes, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 16)
      {
        onalti.gameObject.tag = "dogruCevap";
        Instantiate(onalti, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 17)
      {
        onyedi.gameObject.tag = "dogruCevap";
        Instantiate(onyedi, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 18)
      {
        onsekiz.gameObject.tag = "dogruCevap";
        Instantiate(onsekiz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 19)
      {
        ondokuz.gameObject.tag = "dogruCevap";
        Instantiate(ondokuz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 20)
      {
        yirmi.gameObject.tag = "dogruCevap";
        Instantiate(yirmi, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 21)
      {
        yirmibir.gameObject.tag = "dogruCevap";
        Instantiate(yirmibir, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 22)
      {
        yirmiiki.gameObject.tag = "dogruCevap";
        Instantiate(yirmiiki, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 23)
      {
        yirmiuc.gameObject.tag = "dogruCevap";
        Instantiate(yirmiuc, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 24)
      {
        yirmidort.gameObject.tag = "dogruCevap";
        Instantiate(yirmidort, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 25)
      {
        yirmibes.gameObject.tag = "dogruCevap";
        Instantiate(yirmibes, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 26)
      {
        yirmialti.gameObject.tag = "dogruCevap";
        Instantiate(yirmialti, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 27)
      {
        yirmiyedi.gameObject.tag = "dogruCevap";
        Instantiate(yirmiyedi, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 28)
      {
        yirmisekiz.gameObject.tag = "dogruCevap";
        Instantiate(yirmisekiz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 29)
      {
        yirmidokuz.gameObject.tag = "dogruCevap";
        Instantiate(yirmidokuz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 30)
      {
        otuz.gameObject.tag = "dogruCevap";
        Instantiate(otuz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 31)
      {
        otuzbir.gameObject.tag = "dogruCevap";
        Instantiate(otuzbir, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 32)
      {
        otuziki.gameObject.tag = "dogruCevap";
        Instantiate(otuziki, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 33)
      {
        otuzuc.gameObject.tag = "dogruCevap";
        Instantiate(otuzuc, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 34)
      {
        otuzdort.gameObject.tag = "dogruCevap";
        Instantiate(otuzdort, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 35)
      {
        otuzbes.gameObject.tag = "dogruCevap";
        Instantiate(otuzbes, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 36)
      {
        otuzalti.gameObject.tag = "dogruCevap";
        Instantiate(otuzalti, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 37)
      {
        otuzyedi.gameObject.tag = "dogruCevap";
        Instantiate(otuzyedi, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 38)
      {
        otuzsekiz.gameObject.tag = "dogruCevap";
        Instantiate(otuzsekiz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 39)
      {
        otuzdokuz.gameObject.tag = "dogruCevap";
        Instantiate(otuzdokuz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 40)
      {
        kirk.gameObject.tag = "dogruCevap";
        Instantiate(kirk, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 41)
      {
        kirkbir.gameObject.tag = "dogruCevap";
        Instantiate(kirkbir, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 42)
      {
        kirkiki.gameObject.tag = "dogruCevap";
        Instantiate(kirkiki, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 43)
      {
        kirkuc.gameObject.tag = "dogruCevap";
        Instantiate(kirkuc, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 44)
      {
        kirkdort.gameObject.tag = "dogruCevap";
        Instantiate(kirkdort, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 45)
      {
        kirkbes.gameObject.tag = "dogruCevap";
        Instantiate(kirkbes, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 46)
      {
        kirkalti.gameObject.tag = "dogruCevap";
        Instantiate(kirkalti, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 47)
      {
        kirkyedi.gameObject.tag = "dogruCevap";
        Instantiate(kirkyedi, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 48)
      {
        kirksekiz.gameObject.tag = "dogruCevap";
        Instantiate(kirksekiz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 49)
      {
        kirkdokuz.gameObject.tag = "dogruCevap";
        Instantiate(kirkdokuz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 50)
      {
        elli.gameObject.tag = "dogruCevap";
        Instantiate(elli, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 51)
      {
        ellibir.gameObject.tag = "dogruCevap";
        Instantiate(ellibir, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 52)
      {
        elliiki.gameObject.tag = "dogruCevap";
        Instantiate(elliiki, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 53)
      {
        elliuc.gameObject.tag = "dogruCevap";
        Instantiate(elliuc, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 54)
      {
        ellidort.gameObject.tag = "dogruCevap";
        Instantiate(ellidort, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 55)
      {
        ellibes.gameObject.tag = "dogruCevap";
        Instantiate(ellibes, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 56)
      {
        ellialti.gameObject.tag = "dogruCevap";
        Instantiate(ellialti, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 57)
      {
        elliyedi.gameObject.tag = "dogruCevap";
        Instantiate(elliyedi, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 58)
      {
        ellisekiz.gameObject.tag = "dogruCevap";
        Instantiate(ellisekiz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 59)
      {
        ellidokuz.gameObject.tag = "dogruCevap";
        Instantiate(ellidokuz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 60)
      {
        atmis.gameObject.tag = "dogruCevap";
        Instantiate(atmis, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 61)
      {
        atmisbir.gameObject.tag = "dogruCevap";
        Instantiate(atmisbir, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 62)
      {
        atmisiki.gameObject.tag = "dogruCevap";
        Instantiate(atmisiki, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 63)
      {
        atmisuc.gameObject.tag = "dogruCevap";
        Instantiate(atmisuc, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 64)
      {
        atmisdort.gameObject.tag = "dogruCevap";
        Instantiate(atmisdort, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 65)
      {
        atmisbes.gameObject.tag = "dogruCevap";
        Instantiate(atmisbes, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 66)
      {
        atmisalti.gameObject.tag = "dogruCevap";
        Instantiate(atmisalti, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 67)
      {
        atmisyedi.gameObject.tag = "dogruCevap";
        Instantiate(atmisyedi, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 68)
      {
        atmissekiz.gameObject.tag = "dogruCevap";
        Instantiate(atmissekiz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 69)
      {
        atmisdokuz.gameObject.tag = "dogruCevap";
        Instantiate(atmisdokuz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 70)
      {
        yetmis.gameObject.tag = "dogruCevap";
        Instantiate(yetmis, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 71)
      {
        yetmisbir.gameObject.tag = "dogruCevap";
        Instantiate(yetmisbir, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 72)
      {
        yetmisiki.gameObject.tag = "dogruCevap";
        Instantiate(yetmisiki, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 73)
      {
        yetmisuc.gameObject.tag = "dogruCevap";
        Instantiate(yetmisuc, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 74)
      {
        yetmisdort.gameObject.tag = "dogruCevap";
        Instantiate(yetmisdort, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 75)
      {
        yetmisbes.gameObject.tag = "dogruCevap";
        Instantiate(yetmisbes, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 76)
      {
        yetmisalti.gameObject.tag = "dogruCevap";
        Instantiate(yetmisalti, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 77)
      {
        yetmisyedi.gameObject.tag = "dogruCevap";
        Instantiate(yetmisyedi, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 78)
      {
        yetmissekiz.gameObject.tag = "dogruCevap";
        Instantiate(yetmissekiz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 79)
      {
        yetmisdokuz.gameObject.tag = "dogruCevap";
        Instantiate(yetmisdokuz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 80)
      {
        seksen.gameObject.tag = "dogruCevap";
        Instantiate(seksen, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 81)
      {
        seksenbir.gameObject.tag = "dogruCevap";
        Instantiate(seksenbir, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 82)
      {
        sekseniki.gameObject.tag = "dogruCevap";
        Instantiate(sekseniki, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 83)
      {
        seksenuc.gameObject.tag = "dogruCevap";
        Instantiate(seksenuc, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 84)
      {
        seksendort.gameObject.tag = "dogruCevap";
        Instantiate(seksendort, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 85)
      {
        seksenbes.gameObject.tag = "dogruCevap";
        Instantiate(seksenbes, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 86)
      {
        seksenalti.gameObject.tag = "dogruCevap";
        Instantiate(seksenalti, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 87)
      {
        seksenyedi.gameObject.tag = "dogruCevap";
        Instantiate(seksenyedi, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 88)
      {
        seksensekiz.gameObject.tag = "dogruCevap";
        Instantiate(seksensekiz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 89)
      {
        seksendokuz.gameObject.tag = "dogruCevap";
        Instantiate(seksendokuz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 90)
      {
        doksan.gameObject.tag = "dogruCevap";
        Instantiate(doksan, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 91)
      {
        doksanbir.gameObject.tag = "dogruCevap";
        Instantiate(doksanbir, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 92)
      {
        doksaniki.gameObject.tag = "dogruCevap";
        Instantiate(doksaniki, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 93)
      {
        doksanuc.gameObject.tag = "dogruCevap";
        Instantiate(doksanuc, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 94)
      {
        doksandort.gameObject.tag = "dogruCevap";
        Instantiate(doksandort, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 95)
      {
        doksanbes.gameObject.tag = "dogruCevap";
        Instantiate(doksanbes, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 96)
      {
        doksanalti.gameObject.tag = "dogruCevap";
        Instantiate(doksanalti, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 97)
      {
        doksanyedi.gameObject.tag = "dogruCevap";
        Instantiate(doksanyedi, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 98)
      {
        doksansekiz.gameObject.tag = "dogruCevap";
        Instantiate(doksansekiz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }

      if(dogruCevap == 99)
      {
        doksandokuz.gameObject.tag = "dogruCevap";
        Instantiate(doksandokuz, new Vector3 (dogruXDeger, arac.transform.position.y, arac.transform.position.z + 4), Quaternion.Euler(270, 180, 0));
      }
    }

    void YanlisSpawn() //yanlış cevaba göre obje spawn kodları
    {
      if(yanlisCevap == 0)
      {
        sifir.gameObject.tag = "yanlisCevap";
        Instantiate(sifir, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 1)
      {
        bir.gameObject.tag = "yanlisCevap";
        Instantiate(bir, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 2)
      {
        iki.gameObject.tag = "yanlisCevap";
        Instantiate(iki, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 3)
      {
        uc.gameObject.tag = "yanlisCevap";
        Instantiate(uc, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 4)
      {
        dort.gameObject.tag = "yanlisCevap";
        Instantiate(dort, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 5)
      {
        bes.gameObject.tag = "yanlisCevap";
        Instantiate(bes, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 6)
      {
        alti.gameObject.tag = "yanlisCevap";
        Instantiate(alti, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 7)
      {
        yedi.gameObject.tag = "yanlisCevap";
        Instantiate(yedi, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 8)
      {
        sekiz.gameObject.tag = "yanlisCevap";
        Instantiate(sekiz, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 9)
      {
        dokuz.gameObject.tag = "yanlisCevap";
        Instantiate(dokuz, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 10)
      {
        on.gameObject.tag = "yanlisCevap";
        Instantiate(on, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 11)
      {
        onbir.gameObject.tag = "yanlisCevap";
        Instantiate(onbir, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 12)
      {
        oniki.gameObject.tag = "yanlisCevap";
        Instantiate(oniki, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 13)
      {
        onuc.gameObject.tag = "yanlisCevap";
        Instantiate(onuc, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 14)
      {
        ondort.gameObject.tag = "yanlisCevap";
        Instantiate(ondort, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 15)
      {
        onbes.gameObject.tag = "yanlisCevap";
        Instantiate(onbes, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 16)
      {
        onalti.gameObject.tag = "yanlisCevap";
        Instantiate(onalti, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 17)
      {
        onyedi.gameObject.tag = "yanlisCevap";
        Instantiate(onyedi, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 18)
      {
        onsekiz.gameObject.tag = "yanlisCevap";
        Instantiate(onsekiz, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 19)
      {
        ondokuz.gameObject.tag = "yanlisCevap";
        Instantiate(ondokuz, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 20)
      {
        yirmi.gameObject.tag = "yanlisCevap";
        Instantiate(yirmi, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 21)
      {
        yirmibir.gameObject.tag = "yanlisCevap";
        Instantiate(yirmibir, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 22)
      {
        yirmiiki.gameObject.tag = "yanlisCevap";
        Instantiate(yirmiiki, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 23)
      {
        yirmiuc.gameObject.tag = "yanlisCevap";
        Instantiate(yirmiuc, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 24)
      {
        yirmidort.gameObject.tag = "yanlisCevap";
        Instantiate(yirmidort, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 25)
      {
        yirmibes.gameObject.tag = "yanlisCevap";
        Instantiate(yirmibes, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 26)
      {
        yirmialti.gameObject.tag = "yanlisCevap";
        Instantiate(yirmialti, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 27)
      {
        yirmiyedi.gameObject.tag = "yanlisCevap";
        Instantiate(yirmiyedi, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 28)
      {
        yirmisekiz.gameObject.tag = "yanlisCevap";
        Instantiate(yirmisekiz, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 29)
      {
        yirmidokuz.gameObject.tag = "yanlisCevap";
        Instantiate(yirmidokuz, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 30)
      {
        otuz.gameObject.tag = "yanlisCevap";
        Instantiate(otuz, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 31)
      {
        otuzbir.gameObject.tag = "yanlisCevap";
        Instantiate(otuzbir, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 32)
      {
        otuziki.gameObject.tag = "yanlisCevap";
        Instantiate(otuziki, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 33)
      {
        otuzuc.gameObject.tag = "yanlisCevap";
        Instantiate(otuzuc, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 34)
      {
        otuzdort.gameObject.tag = "yanlisCevap";
        Instantiate(otuzdort, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 35)
      {
        otuzbes.gameObject.tag = "yanlisCevap";
        Instantiate(otuzbes, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 36)
      {
        otuzalti.gameObject.tag = "yanlisCevap";
        Instantiate(otuzalti, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 37)
      {
        otuzyedi.gameObject.tag = "yanlisCevap";
        Instantiate(otuzyedi, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 38)
      {
        otuzsekiz.gameObject.tag = "yanlisCevap";
        Instantiate(otuzsekiz, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 39)
      {
        otuzdokuz.gameObject.tag = "yanlisCevap";
        Instantiate(otuzdokuz, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 40)
      {
        kirk.gameObject.tag = "yanlisCevap";
        Instantiate(kirk, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 41)
      {
        kirkbir.gameObject.tag = "yanlisCevap";
        Instantiate(kirkbir, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 42)
      {
        kirkiki.gameObject.tag = "dogruCevap";
        Instantiate(kirkiki, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 43)
      {
        kirkuc.gameObject.tag = "yanlisCevap";
        Instantiate(kirkuc, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 44)
      {
        kirkdort.gameObject.tag = "yanlisCevap";
        Instantiate(kirkdort, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 45)
      {
        kirkbes.gameObject.tag = "yanlisCevap";
        Instantiate(kirkbes, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 46)
      {
        kirkalti.gameObject.tag = "yanlisCevap";
        Instantiate(kirkalti, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 47)
      {
        kirkyedi.gameObject.tag = "yanlisCevap";
        Instantiate(kirkyedi, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 48)
      {
        kirksekiz.gameObject.tag = "yanlisCevap";
        Instantiate(kirksekiz, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 49)
      {
        kirkdokuz.gameObject.tag = "yanlisCevap";
        Instantiate(kirkdokuz, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 50)
      {
        elli.gameObject.tag = "yanlisCevap";
        Instantiate(elli, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 51)
      {
        ellibir.gameObject.tag = "yanlisCevap";
        Instantiate(ellibir, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 52)
      {
        elliiki.gameObject.tag = "yanlisCevap";
        Instantiate(elliiki, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 53)
      {
        elliuc.gameObject.tag = "yanlisCevap";
        Instantiate(elliuc, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 54)
      {
        ellidort.gameObject.tag = "yanlisCevap";
        Instantiate(ellidort, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 55)
      {
        ellibes.gameObject.tag = "yanlisCevap";
        Instantiate(ellibes, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 56)
      {
        ellialti.gameObject.tag = "yanlisCevap";
        Instantiate(ellialti, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 57)
      {
        elliyedi.gameObject.tag = "yanlisCevap";
        Instantiate(elliyedi, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 58)
      {
        ellisekiz.gameObject.tag = "yanlisCevap";
        Instantiate(ellisekiz, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 59)
      {
        ellidokuz.gameObject.tag = "yanlisCevap";
        Instantiate(ellidokuz, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 60)
      {
        atmis.gameObject.tag = "yanlisCevap";
        Instantiate(atmis, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 61)
      {
        atmisbir.gameObject.tag = "yanlisCevap";
        Instantiate(atmisbir, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 62)
      {
        atmisiki.gameObject.tag = "yanlisCevap";
        Instantiate(atmisiki, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 63)
      {
        atmisuc.gameObject.tag = "yanlisCevap";
        Instantiate(atmisuc, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 64)
      {
        atmisdort.gameObject.tag = "yanlisCevap";
        Instantiate(atmisdort, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 65)
      {
        atmisbes.gameObject.tag = "yanlisCevap";
        Instantiate(atmisbes, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 66)
      {
        atmisalti.gameObject.tag = "yanlisCevap";
        Instantiate(atmisalti, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 67)
      {
        atmisyedi.gameObject.tag = "yanlisCevap";
        Instantiate(atmisyedi, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 68)
      {
        atmissekiz.gameObject.tag = "yanlisCevap";
        Instantiate(atmissekiz, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 69)
      {
        atmisdokuz.gameObject.tag = "yanlisCevap";
        Instantiate(atmisdokuz, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 70)
      {
        yetmis.gameObject.tag = "yanlisCevap";
        Instantiate(yetmis, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 71)
      {
        yetmisbir.gameObject.tag = "yanlisCevap";
        Instantiate(yetmisbir, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 72)
      {
        yetmisiki.gameObject.tag = "yanlisCevap";
        Instantiate(yetmisiki, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 73)
      {
        yetmisuc.gameObject.tag = "yanlisCevap";
        Instantiate(yetmisuc, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 74)
      {
        yetmisdort.gameObject.tag = "yanlisCevap";
        Instantiate(yetmisdort, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 75)
      {
        yetmisbes.gameObject.tag = "yanlisCevap";
        Instantiate(yetmisbes, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 76)
      {
        yetmisalti.gameObject.tag = "yanlisCevap";
        Instantiate(yetmisalti, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 77)
      {
        yetmisyedi.gameObject.tag = "yanlisCevap";
        Instantiate(yetmisyedi, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 78)
      {
        yetmissekiz.gameObject.tag = "yanlisCevap";
        Instantiate(yetmissekiz, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 79)
      {
        yetmisdokuz.gameObject.tag = "yanlisCevap";
        Instantiate(yetmisdokuz, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 80)
      {
        seksen.gameObject.tag = "yanlisCevap";
        Instantiate(seksen, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 81)
      {
        seksenbir.gameObject.tag = "yanlisCevap";
        Instantiate(seksenbir, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 82)
      {
        sekseniki.gameObject.tag = "yanlisCevap";
        Instantiate(sekseniki, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 83)
      {
        seksenuc.gameObject.tag = "yanlisCevap";
        Instantiate(seksenuc, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 84)
      {
        seksendort.gameObject.tag = "yanlisCevap";
        Instantiate(seksendort, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 85)
      {
        seksenbes.gameObject.tag = "yanlisCevap";
        Instantiate(seksenbes, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 86)
      {
        seksenalti.gameObject.tag = "yanlisCevap";
        Instantiate(seksenalti, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 87)
      {
        seksenyedi.gameObject.tag = "yanlisCevap";
        Instantiate(seksenyedi, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 88)
      {
        seksensekiz.gameObject.tag = "yanlisCevap";
        Instantiate(seksensekiz, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 89)
      {
        seksendokuz.gameObject.tag = "yanlisCevap";
        Instantiate(seksendokuz, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 90)
      {
        doksan.gameObject.tag = "yanlisCevap";
        Instantiate(doksan, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 91)
      {
        doksanbir.gameObject.tag = "yanlisCevap";
        Instantiate(doksanbir, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 92)
      {
        doksaniki.gameObject.tag = "yanlisCevap";
        Instantiate(doksaniki, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 93)
      {
        doksanuc.gameObject.tag = "yanlisCevap";
        Instantiate(doksanuc, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 94)
      {
        doksandort.gameObject.tag = "yanlisCevap";
        Instantiate(doksandort, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 95)
      {
        doksanbes.gameObject.tag = "yanlisCevap";
        Instantiate(doksanbes, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 96)
      {
        doksanalti.gameObject.tag = "yanlisCevap";
        Instantiate(doksanalti, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 97)
      {
        doksanyedi.gameObject.tag = "yanlisCevap";
        Instantiate(doksanyedi, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 98)
      {
        doksansekiz.gameObject.tag = "yanlisCevap";
        Instantiate(doksansekiz, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }

      if(yanlisCevap == 99)
      {
        doksandokuz.gameObject.tag = "yanlisCevap";
        Instantiate(doksandokuz, new Vector3 (-dogruXDeger, GameObject.FindWithTag("dogruCevap").transform.position.y, GameObject.FindWithTag("dogruCevap").transform.position.z +4), Quaternion.Euler(270, 180, 0));
      }
    }


    [SerializeField] MeshFilter sifir;
    [SerializeField] MeshFilter bir;
    [SerializeField] MeshFilter iki;
    [SerializeField] MeshFilter uc;
    [SerializeField] MeshFilter dort;
    [SerializeField] MeshFilter bes;
    [SerializeField] MeshFilter alti;
    [SerializeField] MeshFilter yedi;
    [SerializeField] MeshFilter sekiz;
    [SerializeField] MeshFilter dokuz;
    [SerializeField] MeshFilter on;
    [SerializeField] MeshFilter onbir;
    [SerializeField] MeshFilter oniki;
    [SerializeField] MeshFilter onuc;
    [SerializeField] MeshFilter ondort;
    [SerializeField] MeshFilter onbes;
    [SerializeField] MeshFilter onalti;
    [SerializeField] MeshFilter onyedi;
    [SerializeField] MeshFilter onsekiz;
    [SerializeField] MeshFilter ondokuz;
    [SerializeField] MeshFilter yirmi;
    [SerializeField] MeshFilter yirmibir;
    [SerializeField] MeshFilter yirmiiki;
    [SerializeField] MeshFilter yirmiuc;
    [SerializeField] MeshFilter yirmidort;
    [SerializeField] MeshFilter yirmibes;
    [SerializeField] MeshFilter yirmialti;
    [SerializeField] MeshFilter yirmiyedi;
    [SerializeField] MeshFilter yirmisekiz;
    [SerializeField] MeshFilter yirmidokuz;
    [SerializeField] MeshFilter otuz;
    [SerializeField] MeshFilter otuzbir;
    [SerializeField] MeshFilter otuziki;
    [SerializeField] MeshFilter otuzuc;
    [SerializeField] MeshFilter otuzdort;
    [SerializeField] MeshFilter otuzbes;
    [SerializeField] MeshFilter otuzalti;
    [SerializeField] MeshFilter otuzyedi;
    [SerializeField] MeshFilter otuzsekiz;
    [SerializeField] MeshFilter otuzdokuz;
    [SerializeField] MeshFilter kirk;
    [SerializeField] MeshFilter kirkbir;
    [SerializeField] MeshFilter kirkiki;
    [SerializeField] MeshFilter kirkuc;
    [SerializeField] MeshFilter kirkdort;
    [SerializeField] MeshFilter kirkbes;
    [SerializeField] MeshFilter kirkalti;
    [SerializeField] MeshFilter kirkyedi;
    [SerializeField] MeshFilter kirksekiz;
    [SerializeField] MeshFilter kirkdokuz;
    [SerializeField] MeshFilter elli;
    [SerializeField] MeshFilter ellibir;
    [SerializeField] MeshFilter elliiki;
    [SerializeField] MeshFilter elliuc;
    [SerializeField] MeshFilter ellidort;
    [SerializeField] MeshFilter ellibes;
    [SerializeField] MeshFilter ellialti;
    [SerializeField] MeshFilter elliyedi;
    [SerializeField] MeshFilter ellisekiz;
    [SerializeField] MeshFilter ellidokuz;
    [SerializeField] MeshFilter atmis;
    [SerializeField] MeshFilter atmisbir;
    [SerializeField] MeshFilter atmisiki;
    [SerializeField] MeshFilter atmisuc;
    [SerializeField] MeshFilter atmisdort;
    [SerializeField] MeshFilter atmisbes;
    [SerializeField] MeshFilter atmisalti;
    [SerializeField] MeshFilter atmisyedi;
    [SerializeField] MeshFilter atmissekiz;
    [SerializeField] MeshFilter atmisdokuz;
    [SerializeField] MeshFilter yetmis;
    [SerializeField] MeshFilter yetmisbir;
    [SerializeField] MeshFilter yetmisiki;
    [SerializeField] MeshFilter yetmisuc;
    [SerializeField] MeshFilter yetmisdort;
    [SerializeField] MeshFilter yetmisbes;
    [SerializeField] MeshFilter yetmisalti;
    [SerializeField] MeshFilter yetmisyedi;
    [SerializeField] MeshFilter yetmissekiz;
    [SerializeField] MeshFilter yetmisdokuz;
    [SerializeField] MeshFilter seksen;
    [SerializeField] MeshFilter seksenbir;
    [SerializeField] MeshFilter sekseniki;
    [SerializeField] MeshFilter seksenuc;
    [SerializeField] MeshFilter seksendort;
    [SerializeField] MeshFilter seksenbes;
    [SerializeField] MeshFilter seksenalti;
    [SerializeField] MeshFilter seksenyedi;
    [SerializeField] MeshFilter seksensekiz;
    [SerializeField] MeshFilter seksendokuz;
    [SerializeField] MeshFilter doksan;
    [SerializeField] MeshFilter doksanbir;
    [SerializeField] MeshFilter doksaniki;
    [SerializeField] MeshFilter doksanuc;
    [SerializeField] MeshFilter doksandort;
    [SerializeField] MeshFilter doksanbes;
    [SerializeField] MeshFilter doksanalti;
    [SerializeField] MeshFilter doksanyedi;
    [SerializeField] MeshFilter doksansekiz;
    [SerializeField] MeshFilter doksandokuz;
}
