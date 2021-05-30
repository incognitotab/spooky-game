using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class basedamagable : MonoBehaviour,Idamagable<float,Vector3,int>
{
    public float health;
    public float cooldown;
    public GameObject rection;
    public GameObject player;
    public ParticleSystem partic;

    public abstract void takedamage(float damageamount, Vector3 reactionposition, int stunamount);

    public void Start()
    {
        Invoke("playertrap", 0.5f);
        //partic = GetComponent<ParticleSystem>();
    }

    void playertrap()
    {
        player = godscript.god.player;
    }

}
