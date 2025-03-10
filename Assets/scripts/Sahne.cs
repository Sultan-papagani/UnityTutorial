using System;
using System.Collections.Generic;
using UnityEngine;
using System.Collections; 

public class Sahne : MonoBehaviour
{

    int sahne = 0;
    public List<Transform> kamera_pozisyonlari = new List<Transform>();
    public List<SahneKontrol> sahneler = new List<SahneKontrol>();
    Camera ana_kamera;
    void Start()
    {
        ana_kamera = Camera.main;
        SahneHandler(0);
    }

    
    public void SahneSolaKay()
    {
        if (sahne-1 < 0){return;}
        int _sahne = sahne - 1;

        SahneHandler(_sahne);
    }

    public void SahneSagaKay()
    {
        if (sahne+1 > kamera_pozisyonlari.Count-1){return;}
        int _sahne = sahne + 1;

        SahneHandler(_sahne);
    }

    public void SahneHandler(int yeni_sahne)
    {
        StartCoroutine(KameraAnimasyon(ana_kamera.transform.position, kamera_pozisyonlari[yeni_sahne].position, 0.5f));
        ana_kamera.transform.rotation = kamera_pozisyonlari[yeni_sahne].rotation;

        // eski sahneyi sıfırla
        sahneler[sahne].Sahne(false);

        // yeni sahneyi aktifleştir
        sahneler[yeni_sahne].Sahne(true);

        sahne = yeni_sahne;
    }

    IEnumerator KameraAnimasyon(Vector3 baslangic, Vector3 bitis, float zaman)
    {
        float gecen_zaman = 0f;

        while (gecen_zaman < zaman)
        {
            ana_kamera.transform.position = Vector3.Lerp(baslangic, bitis, gecen_zaman / zaman);
            gecen_zaman += Time.deltaTime;
            yield return null;
        }

        transform.position = bitis;
    }
}
