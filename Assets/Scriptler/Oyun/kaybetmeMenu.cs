using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kaybetmeMenu : MonoBehaviour
{


    public void AnaMenuDon() //ana menüye dönme kodu
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void TekrarOyna() //tekrar oynama kodu
    {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
      aracSoru.puan = 0;
      Time.timeScale = 1;
    }
}
