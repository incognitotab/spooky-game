using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundmaker : MonoBehaviour
{
    SphereCollider col;
    public float size;
    // Start is called before the first frame update
    void Start()
    {
      col =  GetComponent<SphereCollider>();
      StartCoroutine(sound());
    }

    IEnumerator sound()
    {
        for(int i = 0; i < 10; i++)
        {
            col.radius += size /20;
            yield return new WaitForSecondsRealtime(0.3f / 20f);
            yield return null;
        }

        Destroy(this.gameObject, 0.3F);
        yield break;
        
    }

   
}
