using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemyai : MonoBehaviour
{
    NavMeshAgent navi;
    enemystats statcomp;
    [SerializeField]float alertlevel;
   [SerializeField] bool heard;
    [SerializeField] Vector3 lasthint;
    [SerializeField]int AlertMax = 100;
    // Start is called before the first frame update
    void Start()
    {
        navi = GetComponent<NavMeshAgent>();
        statcomp = GetComponent<enemystats>();
       
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 7)
        {
            lasthint = other.gameObject.transform.position;
            alertlevel += other.gameObject.GetComponent<soundmaker>().size*3;
            heard = true;
            //Rot = transform.rotation.eulerAngles;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (statcomp.player != null && alertlevel >= AlertMax)
        {
            navi.SetDestination(statcomp.player.transform.position);
        }


        //transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(other.gameObject.transform.position - transform.position), 5);
    }

    public void FixedUpdate()
    {
        if (lasthint != null && heard == true && alertlevel <AlertMax )
        {
            Vector3 V = lasthint - transform.position;

            Quaternion Rot = Quaternion.LookRotation( V);
            transform.rotation = Quaternion.Lerp(transform.rotation, Rot, 2 * Time.deltaTime);
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
          
        }
    }
}
