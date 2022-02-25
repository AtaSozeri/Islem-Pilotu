using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuKomutlari : MonoBehaviour
{


    public void OyunaGec() //oyun scene'ine geçme kodları
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
      aracSoru.puan = 0;
      Time.timeScale = 1;
    }

    public void OyunuKapa() //oyun kapama kodu
    {
      Application.Quit();
    }
}
