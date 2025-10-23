using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class timeSave : ScriptableObject
{
    [SerializeField]
    private float _time;
    public float Time
    {
        get { return _time; }
        set { _time = value; }
    }
    
}
