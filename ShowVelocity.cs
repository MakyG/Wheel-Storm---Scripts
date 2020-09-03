using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowVelocity : MonoBehaviour
{
    static float minAngle = 115f;
    static float maxAngle = -115f;
    static ShowVelocity thisSpeedo;
    void Start()
    {
        thisSpeedo = this;
    }
    public static void ShowSpeed(float speed, float min, float max)
    {
        float ang = Mathf.Lerp(minAngle, maxAngle, Mathf.InverseLerp(min, max, speed));
        thisSpeedo.transform.eulerAngles = new Vector3(0, 0, ang);
    }
}
