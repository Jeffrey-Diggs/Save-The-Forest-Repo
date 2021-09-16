using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float speed;
    private float strength;
   
public void CutTree(GameObject tree)
    {
        tree.SetActive(false);
    }
}
