using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Button = UnityEngine.UI.Button;


public class Menu : MonoBehaviour
{
    //-----PANELLER-----
    public GameObject anaMenu;
    public GameObject ayarMenu;
    public GameObject oyunİci;
    public GameObject olumEkrani;
    public GameObject PuanM;
    //----TUŞLAR------
    public Button basla;
    public Button cik;
    public Button ayar;
    public Button ayarCik;
    public Button oyunIciDurdur;
    public Button oldunTekrar;
    public Button enYuksekSifirla;
    public Text guncelPuan;
    public Text menuEnyYuksekSkor;

    private PuanManag puanManag;




    // Start is called before the first frame update
    void Start()
    {

        puanManag = GameObject.Find("PuanM").GetComponent<PuanManag>();
        Time.timeScale = 0f;
        anaMenu.active = true;
        ayarMenu.active = false;
        oyunİci.active = false;
        olumEkrani.active = false;

    }
    public void OyunaBaslaButton()
    {
        Time.timeScale = 1f;
        anaMenu.active = false;
        ayarMenu.active = false;
        oyunİci.active = true;
    }
    public void OyundanCikButton()
    {
        Application.Quit();
    }
    public void AyaraGir()
    {
        anaMenu.active = false;
        ayarMenu.active = true;
        oyunİci.active = false;
        olumEkrani.active = false;
    }
    public void AyardanCik()
    {
        puanManag.UpdatePuan(0);
       
        anaMenu.active = true;
        ayarMenu.active = false;
        oyunİci.active = false;
        olumEkrani.active = false;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);


        Time.timeScale = 0f;
    }
    public void OyunuDurdur()
    {
        oyunİci.active = false;
        Time.timeScale = 0f;
            AyardanCik(); 
    }
    public void Olum()
    {
        guncelPuan.text = puanManag.puan.ToString();
        olumEkrani.active = true;
        oyunİci.active = false;

    }
    public void RekorTazele()
    {
        PlayerPrefs.DeleteKey("EnYuksekSkor");
    }
    private void Update()
    {
        menuEnyYuksekSkor.text = $"En Yüksek Skor: {puanManag.enYuksekPuan}";
    }

}
