using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Eyeraycast : MonoBehaviour
{
    public enemyai Aicomp;
     bool awake;
    public bool alerted;
   [SerializeField] LayerMask ignoreme;
    AimConstraint aim;
    Vector3 inherintpos;

    private void Start()
    {
        aim = GetComponent<AimConstraint>();
    }

    public void awoken(Vector3 pos)
    {
        awake = true;
        aim.constraintActive = true;
        GetComponent<Renderer>().material.color = Color.black;
        inherintpos = pos - transform.position;
    }

    private void Update()
    {
        if(Aicomp != null && awake == true && alerted == false)
        {
            RaycastHit hit;
            Debug.DrawLine(transform.position, inherintpos * 80);
            if (Physics.Raycast(transform.position, inherintpos, out hit, 40, ~ignoreme))
            {
                if (hit.collider.gameObject.layer == 8)
                {
                    Debug.Log("yippi");
                }
            }
        }
    }
}
