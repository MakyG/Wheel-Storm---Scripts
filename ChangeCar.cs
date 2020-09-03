using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeCar : MonoBehaviour
{
    public GameObject Car1;
    public GameObject Car2;
    public GameObject Car3;
    public GameObject Car4;
    public GameObject Car5;
    public GameObject Car6;
    public GameObject Camera1;
    public GameObject Camera2;
    public GameObject Camera3;
    public GameObject Camera4;
    public GameObject Camera5;
    public GameObject Camera6;

    public static bool CarSelected = false;
    
    public void ChangeCarBtn()
    {
        Car1.transform.position = new Vector3(26, -90, 5);
        CarSelected = true;
        Car1.SetActive(true);
        Car2.SetActive(false);
        Car3.SetActive(false);
        Car4.SetActive(false);
        Car5.SetActive(false);
        Car6.SetActive(false);
        Camera1.SetActive(true);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
        Camera4.SetActive(false);
        Camera5.SetActive(false);
        Camera6.SetActive(false);
    }
    public void ChangeCar2Btn()
    {
        Car2.transform.position = new Vector3(26, -90, 5);
        CarSelected = true;
        Car1.SetActive(false);
        Car2.SetActive(true);
        Car3.SetActive(false);
        Car4.SetActive(false);
        Car5.SetActive(false);
        Car6.SetActive(false);
        Camera1.SetActive(false);
        Camera2.SetActive(true);
        Camera3.SetActive(false);
        Camera4.SetActive(false);
        Camera5.SetActive(false);
        Camera6.SetActive(false);
    }
    public void ChangeCar3Btn()
    {
        Car3.transform.position = new Vector3(26, -88.5f, 5);
        CarSelected = true;
        Car1.SetActive(false);
        Car2.SetActive(false);
        Car3.SetActive(true);
        Car4.SetActive(false);
        Car5.SetActive(false);
        Car6.SetActive(false);
        Camera1.SetActive(false);
        Camera2.SetActive(false);
        Camera3.SetActive(true);
        Camera4.SetActive(false);
        Camera5.SetActive(false);
        Camera6.SetActive(false);
    }
    public void ChangeCar4Btn()
    {
        Car4.transform.position = new Vector3(26, -90, 5);
        CarSelected = true;
        Car1.SetActive(false);
        Car2.SetActive(false);
        Car3.SetActive(false);
        Car4.SetActive(true);
        Car5.SetActive(false);
        Car6.SetActive(false);
        Camera1.SetActive(false);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
        Camera4.SetActive(true);
        Camera5.SetActive(false);
        Camera6.SetActive(false);
    }
    public void ChangeCar5Btn()
    {
        Car5.transform.position = new Vector3(26, -90, 5);
        CarSelected = true;
        Car1.SetActive(false);
        Car2.SetActive(false);
        Car3.SetActive(false);
        Car4.SetActive(false);
        Car5.SetActive(true);
        Car6.SetActive(false);
        Camera1.SetActive(false);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
        Camera4.SetActive(false);
        Camera5.SetActive(true);
        Camera6.SetActive(false);
    }
    public void ChangeCar6Btn()
    {
        Car6.transform.position = new Vector3(26, -90, 5);
        CarSelected = true;
        Car1.SetActive(false);
        Car2.SetActive(false);
        Car3.SetActive(false);
        Car4.SetActive(false);
        Car5.SetActive(false);
        Car6.SetActive(true);
        Camera1.SetActive(false);
        Camera2.SetActive(false);
        Camera3.SetActive(false);
        Camera4.SetActive(false);
        Camera5.SetActive(false);
        Camera6.SetActive(true);
    }
}
