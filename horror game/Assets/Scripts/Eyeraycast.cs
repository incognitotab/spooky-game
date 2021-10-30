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
    float timer;
    Quaternion OgRotation;

    private void Start()
    {
        aim = GetComponent<AimConstraint>();
        OgRotation = transform.rotation;
        
    }

    public void awoken(Vector3 pos)
    {
        
        aim.constraintActive = true;
        GetComponent<Renderer>().material.color = Color.black;
        inherintpos = pos - transform.position;
        timer = 8;
        StartCoroutine(eyetimer());
        awake = true;
    }

    IEnumerator eyetimer()
    {
        if (awake == false)
        {
            while (timer > 0)
            {
                timer -=1;
                yield return new WaitForSecondsRealtime(1);
                yield return null;
            }
           
            awake = false;
            aim.constraintActive = false;
            GetComponent<Renderer>().material.color = Color.white;
           yield return StartCoroutine(eyereturn());
        }
        yield break;
    }

    IEnumerator eyereturn()
    {
        while (Quaternion.Angle(OgRotation, transform.rotation) > 2f)
        {
            transform.rotation = Quaternion.Lerp(transform.rotation, OgRotation, 2 * Time.deltaTime);
           
            yield return new WaitForFixedUpdate();
            yield return null;
        }

        yield break;
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
                    godscript.god.alertadditive(1, hit.transform.position);
                }
            }
        }
        Debug.Log(timer);
    }
}
