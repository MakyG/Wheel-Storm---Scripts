using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GasBar : MonoBehaviour
{
    public float totalGas = 100;
    public static int currentCar;

    void Update()
    {
        if (currentCar == 1)
        {
            totalGas = CarController.gas;
        }
        if (currentCar == 2)
        {
            totalGas = CarController2.gas;
        }
        if (currentCar == 3)
        {
            totalGas = CarController3.gas;
        }
        if (currentCar == 4)
        {
            totalGas = CarController4.gas;
        }
        if (currentCar == 5)
        {
            totalGas = CarController5.gas;
        }
        if (currentCar == 6)
        {
            totalGas = CarController6.gas;
        }
        Transform bar = transform.Find("Bar");
        bar.localScale = new Vector3((totalGas / 100), 1f);
    }
}
