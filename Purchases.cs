using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Purchases : MonoBehaviour
{
    public GameObject unlockButton1;
    public GameObject unlockButton2;
    public GameObject unlockButton3;
    public GameObject unlockButton4;
    public GameObject unlockButton5;
    public GameObject unlockButtonA;
    public GameObject unlockButtonB;
    public GameObject unlockButtonC;
    public static bool car1bought = false;
    public static bool car2bought = false;
    public static bool car3bought = false;
    public static bool car4bought = false;
    public static bool car5bought = false;
    public static bool map1bought = false;
    public static bool map2bought = false;
    public static bool map3bought = false;
    public void BuyArmyTruck()
    {
        if (GlobalCash.CashCount >= 15000)
        {
            unlockButton1.SetActive(false);
            car1bought = true;
            GlobalCash.CashCount -= 15000;
        }
    }
    public void BuyDakarTruck()
    {
        if (GlobalCash.CashCount >= 30000)
        {
            unlockButton2.SetActive(false);
            car2bought = true;
            GlobalCash.CashCount -= 30000;
        }
    }
    public void BuyCyberTruck()
    {
        if (GlobalCash.CashCount >= 35000)
        {
            unlockButton3.SetActive(false);
            car3bought = true;
            GlobalCash.CashCount -= 35000;
        }
    }
    public void BuyTruck8x8()
    {
        if (GlobalCash.CashCount >= 37000)
        {
            unlockButton4.SetActive(false);
            car4bought = true;
            GlobalCash.CashCount -= 37000;
        }
    }
    public void BuyMotorBike()
    {
        if (GlobalCash.CashCount >= 5000)
        {
            unlockButton5.SetActive(false);
            car5bought = true;
            GlobalCash.CashCount -= 5000;
        }
    }
    //MAPS
    public void BuyAntarctica()
    {
        if (GlobalCash.CashCount >= 30000)
        {
            unlockButtonA.SetActive(false);
            map1bought = true;
            GlobalCash.CashCount -= 30000;
        }
    }
    public void BuySwamp()
    {
        if (GlobalCash.CashCount >= 60000)
        {
            unlockButtonB.SetActive(false);
            map2bought = true;
            GlobalCash.CashCount -= 60000;
        }
    }
    public void BuyMoon()
    {
        if (GlobalCash.CashCount >= 100000)
        {
            unlockButtonC.SetActive(false);
            map3bought = true;
            GlobalCash.CashCount -= 100000;
        }
    }
    public void Update()
    {
        //CARS
        if(car1bought == true)
        {
            unlockButton1.SetActive(false);
        }
        if (car1bought == false)
        {
            unlockButton1.SetActive(true);
        }
        if (car2bought == true)
        {
            unlockButton2.SetActive(false);
        }
        if (car2bought == false)
        {
            unlockButton2.SetActive(true);
        }
        if (car3bought == true)
        {
            unlockButton3.SetActive(false);
        }
        if (car4bought == true)
        {
            unlockButton4.SetActive(false);
        }
        if (car5bought == true)
        {
            unlockButton5.SetActive(false);
        }
        if (car5bought == false)
        {
            unlockButton5.SetActive(true);
        }
        //MAPS
        if (map1bought == true)
        {
            unlockButtonA.SetActive(false);
        }
        if (map2bought == true)
        {
            unlockButtonB.SetActive(false);
        }
        if (map3bought == true)
        {
            unlockButtonC.SetActive(false);
        }
    }
}
