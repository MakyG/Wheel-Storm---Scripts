using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameSetup : MonoBehaviour
{
    public GameObject MainCanvas;
    public GameObject MainCanvasMap;
    public GameObject GreenHills;
    public GameObject Antarctica;
    public GameObject Swamp;
    public GameObject Moon;
    public GameObject MapCanvas;
    public GameObject CarCanvas;
    public GameObject SpaceBackground1;
    public GameObject SpaceBackground2;
    public GameObject SpaceBackground3;
    public GameObject SpaceBackground4;
    public GameObject SpaceBackground5;
    public GameObject SpaceBackground6;
    public static bool CanLeak = false;
    

    public void StartGame()
    {
        if(ChangeCar.CarSelected == true)
        {
            MainCanvas.SetActive(false);
            ChangeCar.CarSelected = false;
        }
    }

    public void EndGame()
    {
        ChangeCar.CarSelected = false;
        CanLeak = false;
        GlobalCash.EarnedCashCount = 0;
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
    public void MapChoose()
    {
        SceneManager.LoadScene("Maps");
    }

    public void PauseGame()
    {
        Time.timeScale = 0;
    }
    public void ContinueGame()
    {
        Time.timeScale = 1;
    }
    public void ChooseGreenhills()
    {
        GreenHills.SetActive(true);
        Antarctica.SetActive(false);
        Swamp.SetActive(false);
        Moon.SetActive(false);
        MapCanvas.SetActive(false);
        CarCanvas.SetActive(true);
        SpaceBackground1.SetActive(false);
        SpaceBackground2.SetActive(false);
        SpaceBackground3.SetActive(false);
        SpaceBackground4.SetActive(false);
        SpaceBackground5.SetActive(false);
        SpaceBackground6.SetActive(false);
        Physics2D.gravity = new Vector2(0.0f, -9.81f);
    }
    public void ChooseAntarctica()
    {
        GreenHills.SetActive(false);
        Antarctica.SetActive(true);
        Swamp.SetActive(false);
        Moon.SetActive(false);
        MapCanvas.SetActive(false);
        CarCanvas.SetActive(true);
        SpaceBackground1.SetActive(false);
        SpaceBackground2.SetActive(false);
        SpaceBackground3.SetActive(false);
        SpaceBackground4.SetActive(false);
        SpaceBackground5.SetActive(false);
        SpaceBackground6.SetActive(false);
        Physics2D.gravity = new Vector2(0.0f, -9.81f);
    }
    public void ChooseSwamp()
    {
        GreenHills.SetActive(false);
        Antarctica.SetActive(false);
        Swamp.SetActive(true);
        Moon.SetActive(false);
        MapCanvas.SetActive(false);
        CarCanvas.SetActive(true);
        SpaceBackground1.SetActive(false);
        SpaceBackground2.SetActive(false);
        SpaceBackground3.SetActive(false);
        SpaceBackground4.SetActive(false);
        SpaceBackground5.SetActive(false);
        SpaceBackground6.SetActive(false);
        Physics2D.gravity = new Vector2(0.0f, -9.81f);
    }
    public void ChooseMoon()
    {
        GreenHills.SetActive(false);
        Antarctica.SetActive(false);
        Swamp.SetActive(false);
        Moon.SetActive(true);
        MapCanvas.SetActive(false);
        CarCanvas.SetActive(true);
        SpaceBackground1.SetActive(true);
        SpaceBackground2.SetActive(true);
        SpaceBackground3.SetActive(true);
        SpaceBackground4.SetActive(true);
        SpaceBackground5.SetActive(true);
        SpaceBackground6.SetActive(true);
        Physics2D.gravity = new Vector2(0.0f, -5.2f);
    }
}
