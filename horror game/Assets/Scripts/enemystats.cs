using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemystats : basedamagable
{
    // Start is called before the first frame update
    

    public override void takedamage(float damageamount, Vector3 reactionposition, int stunamount)
    {
        health -= damageamount;
        particlepos(reactionposition, gameObject.transform.position);
    }

    void particlepos( Vector3 pos,Vector3 ogpos)
    {
        //var position = partic.shape;
        //position.position = pos-ogpos;
        Vector3 unipos = pos-ogpos;
        var specific = Quaternion.LookRotation(unipos, Vector3.up);
        //Debug.Log(unipos);
        partic.gameObject.transform.position = pos;
        partic.gameObject.transform.rotation = specific;
        partic.Play();
    }
    
}
