using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] int movespeed = 10;
    int ogspeed;
    Vector3 inputpos;
    Vector3 rotationpos;
    float camy;
    float height = 1;
    [SerializeField] GameObject cameraobject;
    [SerializeField] bool groundcheck;
    bool moving;
    [SerializeField] GameObject soundmove;
    bool crouch;
    [SerializeField] Animator Handanim,camanim;
    bool Lockon;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        camy = cameraobject.transform.position.y/2;
        registerinput();
        ogspeed = movespeed;
        camanim = Camera.main.gameObject.GetComponent<Animator>();
    }

    void registerinput()
    {
        #region movementstyle
        inputmanager.input.pinput.playerkeyboardcontols.Sprint.performed += ctx =>
        {
            if (crouch == false)
            {
                movespeed = ogspeed + 5;
                GameObject opp = soundmove;
                opp.GetComponent<soundmaker>().size = movespeed;
                Instantiate(opp, transform.position, transform.rotation);
            }

            else
            {
                movespeed = ogspeed - 1;
            }
        };

       inputmanager.input.pinput.playerkeyboardcontols.Sprint.canceled += ctx =>
        {
            if (crouch == false)
            {
                movespeed = ogspeed;
            }

            else
            {
                movespeed = ogspeed - 3;
            }
        };

        inputmanager.input.pinput.playerkeyboardcontols.jump.performed += ctx =>
        {
            if (groundcheck == true)
            {
                rb.AddForce(Vector3.up * movespeed * 80, ForceMode.Impulse);
                height = 0.8f;
                groundcheck = false;
                GameObject opp = soundmove;
                opp.GetComponent<soundmaker>().size = movespeed+4;
                Instantiate(opp, transform.position, transform.rotation);
            }
        };

        inputmanager.input.pinput.playerkeyboardcontols.Crouch.performed += ctx =>
        {
            height = 0;
            movespeed = ogspeed - 3;
            crouch = true;
            GameObject opp = soundmove;
            opp.GetComponent<soundmaker>().size = movespeed;
            Instantiate(opp, transform.position, transform.rotation);
        };

        inputmanager.input.pinput.playerkeyboardcontols.Crouch.canceled += ctx =>
        {
            height = 1;
            movespeed = ogspeed + 3;
            crouch = false;
        };
        #endregion
        inputmanager.input.pinput.playerkeyboardcontols.soundemmiter.performed += ctx =>
          {
              moving = true;
              Handanim.SetFloat("walking", 1);
              camanim.SetFloat("walking", 1);
              StartCoroutine(soundprod());
          };

        inputmanager.input.pinput.playerkeyboardcontols.soundemmiter.canceled += ctx =>
         {
             Handanim.SetFloat("walking", 0);
             camanim.SetFloat("walking", 0);
             moving = false;
         };

        inputmanager.input.pinput.playerkeyboardcontols.lockon.performed += ctx =>
        {
            
            camanim.SetBool("Lockon", true);
        };

        inputmanager.input.pinput.playerkeyboardcontols.lockon.canceled += ctx =>
        {
            
            camanim.SetBool("Lockon", false);
        };
    }

   

    IEnumerator soundprod()
    {
        while (moving == true)
        {
            GameObject opp = soundmove;
            opp.GetComponent<soundmaker>().size = movespeed;
            Instantiate(opp, transform.position, transform.rotation);
            yield return new WaitForSecondsRealtime(1.5f/movespeed);
            yield return null;
        }
        yield break;
    }

   


    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == 3)
        {
            groundcheck = true;
            GameObject opp = soundmove;
            opp.GetComponent<soundmaker>().size = movespeed+7;
            Instantiate(opp, transform.position, transform.rotation);
            height = 1;
        }
    }

    public void Update()
    {
        inputpos = new Vector3(transform.forward.x* inputmanager.input.movement.y, 0, transform.forward.z*inputmanager.input.movement.y);
        inputpos += new Vector3(transform.right.x * inputmanager.input.movement.x, 0, transform.right.z * inputmanager.input.movement.x);
        rotationpos = gameObject.transform.rotation.eulerAngles;
        Handanim.SetFloat("movespeed", movespeed);
        camanim.SetFloat("movespeed", movespeed);
    }

    public void FixedUpdate()
    {
        rb.MovePosition(rb.position + (inputpos * movespeed * Time.deltaTime));
        rb.rotation = Quaternion.Euler(0, inputmanager.input.valuex, 0);
        cameraobject.transform.position =Vector3.LerpUnclamped((Vector3.up*camy*height) + transform.position,cameraobject.transform.position,20*Time.deltaTime);
        //cameraobject.transform.position = (Vector3.up * camy * height) + transform.position;
    }


}
