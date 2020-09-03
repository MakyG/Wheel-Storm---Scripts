using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PaddleManager : MonoBehaviour
{
    public GameObject BrakePaddleDown;
    public GameObject BrakePaddleUp;
    public GameObject ThrottlePaddleDown;
    public GameObject ThrottlePaddleUp;
    public AudioSource TurboSound;
    public void Update()
    {
        if (CrossPlatformInputManager.GetAxis("Horizontal") < 0)
        {
            BrakePaddleDown.SetActive(true);
            BrakePaddleUp.SetActive(false);
        }
        else
        {
            BrakePaddleUp.SetActive(true);
            BrakePaddleDown.SetActive(false);
        }
        if (CrossPlatformInputManager.GetAxis("Horizontal") > 0)
        {
            ThrottlePaddleDown.SetActive(true);
            ThrottlePaddleUp.SetActive(false);
        }
        else
        {
            ThrottlePaddleUp.SetActive(true);
            ThrottlePaddleDown.SetActive(false);
        }
    }
}
