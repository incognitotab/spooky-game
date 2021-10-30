using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public static InputManager Minput;
    public Vector2 Movement, Rotnorm;
    public Playerandboatcontrols pinput;
    // Start is called before the first frame update

    private void Awake()
    {
        Minput = this;
        Onregisterinput();
    }

    void Start()
    {
        
    }

    void Onregisterinput()
    {
        pinput = new Playerandboatcontrols();
        
    }

    private void OnEnable()
    {
        pinput.Enable();
    }
    private void OnDisable()
    {
        pinput.Disable();
    }

   
}
