using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class godscript : MonoBehaviour
{
    public static godscript god;
    public GameObject player;
    // Start is called before the first frame update
    void Awake()
    {
        god = this;
    }

    public event Action Shake;
   public void camerashake()
    {
        Shake.Invoke();
    }

    public event Action<float,Vector3> Alert;
    public void alertadditive(float amount,Vector3 position)
    {
        Alert.Invoke(amount,position);
    }
}
