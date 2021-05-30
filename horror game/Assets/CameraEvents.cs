using System.Collections;
using System.Collections.Generic;
using Cinemachine;
using UnityEngine;

public class CameraEvents : MonoBehaviour
{
   [SerializeField] CinemachineImpulseSource Shaker;
    // Start is called before the first frame update
    void Start()
    {
        Shaker = GetComponent<CinemachineImpulseSource>();
        godscript.god.Shake += shake;
    }

    void shake()
    {
        Shaker.GenerateImpulse();
    }
}
