using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuffEffect : MonoBehaviour
{
    public float _timeremain;
    public virtual void start() { }
    public virtual void RunEffect() { Debug.Log("A"); }
}
