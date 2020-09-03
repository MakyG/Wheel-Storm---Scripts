using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChooseScene : MonoBehaviour
{
    // Start is called before the first frame update
    public static void ChooseGreenHills()
    {
        SceneManager.LoadScene("GreenHills");
    }
    public static void ChooseDesert()
    {
        SceneManager.LoadScene("Desert");
    }
    public static void ChooseAntarctica()
    {
        SceneManager.LoadScene("Antarctica");
    }
    public static void ChooseSwamp()
    {
        SceneManager.LoadScene("Swamp");
    }
}
