using System.Collections.Generic;
using NUnit.Framework.Constraints;
using Unity.VisualScripting;
using UnityEngine;

public class SahneKontrol : MonoBehaviour
{

    Vector3 poz;
    Quaternion rot;
    Vector3 scale;
    public MonoBehaviour script;
    public List<SahneKontrol> diger_objeler = new List<SahneKontrol>();

    void Start()
    {
        poz = transform.position;
        rot = transform.rotation;
        scale = transform.localScale;
        if (script == null){return;}
        script.enabled = false;
    }

    public void Sahne(bool durum = false)
    {
        transform.position = poz;
        transform.rotation = rot;
        transform.localScale = scale;
        if (TryGetComponent<Rigidbody>(out Rigidbody rb))
        {
            rb.linearVelocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
        foreach(SahneKontrol kontrol in diger_objeler){kontrol.Sahne(durum);}
        if (script == null){return;}
        script.enabled = durum;
    }    

}
