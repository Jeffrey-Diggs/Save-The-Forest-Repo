using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    float speed = 3.5f; 
    public virtual float SetSpeed()
    {
        return speed;
    }
}
