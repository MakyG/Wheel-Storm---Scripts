using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelMaterial : MonoBehaviour
{
    public static float wheelFriction = 0;
    public void Update()
    {
        GetComponent<CircleCollider2D>().sharedMaterial.friction = wheelFriction;
    }
}
