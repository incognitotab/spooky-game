using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectHit : basedamagable
{

    public override void takedamage(float damageamount, Vector3 reactionposition, int stunamount)
    {
        particlepos(reactionposition, godscript.god.player.transform.position);
    }

    void particlepos(Vector3 pos, Vector3 ogpos)
    {
        //var position = partic.shape;
        //position.position = pos-ogpos;
        Vector3 unipos = ogpos-pos;
        var specific = Quaternion.LookRotation(unipos, Vector3.up);
        //Debug.Log(unipos);
        partic.gameObject.transform.position = pos;
        partic.gameObject.transform.rotation = specific;
        partic.Play();
    }
}
