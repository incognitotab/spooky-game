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
   // ParticleSystemRenderer partrend;
    public bool Npc;

    public abstract void takedamage(float damageamount, Vector3 reactionposition, int stunamount);

    public void Start()
    {
        partic = GetComponentInChildren<ParticleSystem>();
        //partrend = partic.gameObject.GetComponent<ParticleSystemRenderer>();
        if (Npc == true)
        {
            Invoke("playertrap", 0.5f);

        }
        /*else
        {
            Invoke("material",0.3f);
        }*/
        //partic = GetComponent<ParticleSystem>();
    }

   /*void material()
    {
        //if(gameObject.GetComponent<Renderer>()!=null)
        Material mat = this.gameObject.GetComponent<Renderer>().material;

       partrend.material=mat;
    }*/

    void playertrap()
    {
        player = godscript.god.player;
    }

}
