using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playerevents : MonoBehaviour
{
    [SerializeField] GameObject Gunmodel;
    [SerializeField] GunManager Gun;
    [SerializeField] ParticleSystem Partic,Partic2;
    [SerializeField] Light lit;

    // Start is called before the first frame update
    void Start()
    {
        Gun = GunManager.Gun;
        if (!Partic.isPlaying)
        {

            Partic.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GunShot()
    {
        Gun.GunShot();
        //godscript.god.camerashake();
        var emi = Partic.emission;
        emi.enabled = true;
        lit.intensity = 0;
        lit.enabled = true;
        StartCoroutine(lighter());
        Invoke("Partstop", 0.1f);
        
    }

    void reload()
    {
        Gun.Reload();
    }

    void rotationstop()
    {
        inputmanager.input.HoldRotation =inputmanager.input.HoldRotation== true ? false : true;
        
    }

    void Partstop()
    {
        var emi = Partic.emission;
        emi.enabled = false;
        lit.enabled = false;
        Partic2.Play();
    }

    IEnumerator lighter()
    {
        for(int i = 0; i < 10; i++)
        {
            lit.intensity += 300 / 10;
            yield return new WaitForSecondsRealtime(0.1f / 10);
            yield return null;
        }
        yield break;
    }

    public void Gunreal()
    {
        if (Gunmodel.activeSelf == false)
        {
            Gunmodel.SetActive(true);
        }

        else
        {
            Gunmodel.SetActive(false);
        }
    }
}
