using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyai : MonoBehaviour
{
    NavMeshAgent navi;
    enemystats statcomp;
    [SerializeField]float alertlevel;
   [SerializeField] bool heard,alerted;
    [SerializeField] Vector3 lasthint;
    [SerializeField]int AlertMax = 100;
    [SerializeField] GameObject target;
    [SerializeField] List<Eyeraycast> Eyes = new List<Eyeraycast>();
    float timer = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        navi = GetComponent<NavMeshAgent>();
        statcomp = GetComponent<enemystats>();
        foreach(Eyeraycast eye in Eyes)
        {
            eye.Aicomp = this;
        }

        godscript.god.Alert += alertmeasure;
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 7)
        {
            alertmeasure(other.gameObject.GetComponent<soundmaker>().size,other.gameObject.transform.position);
        }

        if(other.gameObject.layer == 8)
        {
            alertmeasure(AlertMax, other.transform.position);
        }
    }

    void statecheck()
    {
       

        if (alertlevel/AlertMax < 0.6f)
        {
            
            float distance = 100;
            Eyeraycast oneeye = null;
            foreach (Eyeraycast eye in Eyes)
            {
                float dist = Vector3.Distance(eye.transform.position, statcomp.player.transform.position);
                if (dist < distance)
                {
                    distance = dist;
                    oneeye = eye;
                }
            }
            oneeye.awoken(lasthint);
            return;
        }

        if (alertlevel / AlertMax < 1) 
        {
            
            alerted = true;
            float distance = 100;
            Eyeraycast oneeye = null;
            foreach (Eyeraycast eye in Eyes)
            {
                float dist = Vector3.Distance(eye.transform.position, statcomp.player.transform.position);
                if (dist < distance)
                {
                    distance = dist;
                    oneeye = eye;
                }
            }
            oneeye.awoken(lasthint);
            return;
        }

        if (alertlevel / AlertMax > 1)
        {
            heard = true;
            alerted = true;
            lasthint = statcomp.player.transform.position;
            alertlevel = 1150;
        }
    }

    IEnumerator drain()
    {
        if (heard==false)
        {
            heard = true;
            while (alertlevel > 0)
            {
                if(timer > 0)
                {
                    timer--;
                    yield return new WaitForSecondsRealtime(1);
                    yield return null;
                }

                alertlevel -= 10;
                yield return new WaitForSecondsRealtime(0.2f);
                yield return null;
            }
            heard = false;
            alerted = false;
            alertlevel = 0;
        }
        yield break;
    }

    // Update is called once per frame
    void Update()
    {
        if (statcomp.player != null && alerted == true)
        {
            navi.SetDestination(lasthint);
        }


        //transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(other.gameObject.transform.position - transform.position), 5);
    }

    public void FixedUpdate()
    {
        if (lasthint != null && heard == true && alertlevel >AlertMax )
        {
            //Vector3 V = lasthint - transform.position;

            //Quaternion Rot = Quaternion.LookRotation( V);
            //transform.rotation = Quaternion.Lerp(transform.rotation, Rot, 2 * Time.deltaTime);
            /*float checkdir = Mathf.Atan2(V.x, V.y) * Mathf.Rad2Deg;

            if (V.y < 0)
            {
                checkdir = 180 - checkdir;
            }
            else
            if (V.x < 0)
            {
                checkdir = 360 + checkdir;
            }

            transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(new Vector3(Rot.x,checkdir,Rot.z)), 50);*/
            lasthint = statcomp.player.transform.position;
        }
    }

    void alertmeasure(float amount,Vector3 position)
    {
        lasthint = position;
        alertlevel += amount;
        if(amount >0)
        {
            timer = 3;
        }
        statecheck();
        StartCoroutine(drain());
    }
}
