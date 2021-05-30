using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Idamagable<t,s,a>
{
    void takedamage(t dmaageamount, s rectionposition, a stunamount);
}
