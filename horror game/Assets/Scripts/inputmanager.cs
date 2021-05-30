using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class inputmanager : MonoBehaviour
{
    public Vector2 movement,rotation;
    [SerializeField] InputActionAsset playerinput;
    public static inputmanager input;
    public Playeraction pinput;
    [SerializeField] int inputsensivity = 20;
    float valuey=0;
   public float valuex = 0;
    public bool HoldRotation;
    Vector3 rot;

    float mousewheeltest;
        // Start is called before the first frame update
    void Awake()
    {
        input = this;
        //pinput.playerkeyboardcontols.mouse.performed += ctx => rotation = ctx.ReadValue<Vector2>();
        //movement = new Vector3(playerinput.)

        registerinput();
    }

    void registerinput()
    {
        pinput = new Playeraction();
        pinput.playerkeyboardcontols.Movement.performed += ctx => movement = ctx.ReadValue<Vector2>();
        pinput.playerkeyboardcontols.mouse.performed += ctx => rotation = ctx.ReadValue<Vector2>();
        //pinput.playerkeyboardcontols.weaponwheel.performed += ctx => mousewheeltest = ctx.ReadValue<float>();
        Cursor.visible = false;
    }

    private void OnEnable()
    {
        pinput.Enable();
    }
    private void OnDisable()
    {
        pinput.Disable();
    }

    public void Update()
    {
       rot = Camera.main.transform.rotation.eulerAngles;
        valuey += - (rotation.y * inputsensivity*Time.deltaTime);
        valuex += rotation.x * inputsensivity*Time.deltaTime;
        valuey = Mathf.Clamp(valuey, -50, 50);
      /*  if (valuey> 60)
        {
            //rot.x=45;
            //rotation.y = 0;
            //value = 45;
            valuey = 60;
        }

       else if (valuey < -60)
        {
            //rot.x = -45;
            //rotation.y = 0;
            //value = 45;
            valuey =-60;

        }*/
       // Debug.Log(rot);
    }

    // Update is called once per frame
    public void FixedUpdate()
    {
       
            Camera.main.transform.rotation = Quaternion.Euler(valuey, valuex, 0);
            //Debug.Log(mousewheeltest);
        
    }
}
