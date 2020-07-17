using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float moveSpeed=0.1f;
    void Update()
    {
        transform.position -= new Vector3(moveSpeed, 0, 0);
    }
}
