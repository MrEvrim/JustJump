using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.UI;

public class PuanManag : MonoBehaviour
{
    public int enYuksekPuan;
    public int puan;
    public Text txtPuan;
    public Text txtEnYuksekPuan;

    void Start()
    {
        // Kaydedilmiş en yüksek skoru al ve ekrana yaz
        enYuksekPuan = PlayerPrefs.GetInt("EnYuksekSkor", 0);
        txtEnYuksekPuan.text = $"En Yüksek Skor: {enYuksekPuan}";

        // Diğer başlangıç ayarları
        txtPuan.text = $"{puan}";
    }

    public void UpdatePuan(int puanlar)
    {
        puan += puanlar;
        txtPuan.text = $"{puan}";

        
        if (puan > enYuksekPuan)
        {
            enYuksekPuan = puan;
            PlayerPrefs.SetInt("EnYuksekSkor", enYuksekPuan);
            PlayerPrefs.Save(); // PlayerPrefs'ın değişiklikleri kaydetmek için Save() kullanılmalı
            txtEnYuksekPuan.text = $"En Yüksek Skor: {enYuksekPuan}";
        }
    }
}