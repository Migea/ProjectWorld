using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrostBuff : BuffEffect
{
    public override void RunEffect()
    {
        Debug.Log("b");
    }

    public override void start()
    {
        RunEffect();
    }
}
