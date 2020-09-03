using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public int Ccount;
    public bool car1bought;
    public bool car2bought;
    public bool car3bought;
    public bool car4bought;
    public bool car5bought;
    public bool map1bought;
    public bool map2bought;
    public bool map3bought;

    public int car1engine;
    public int car1rotation;
    public int car1suspension;
    public int car1tires;
    public int car1tank;

    public int car2engine;
    public int car2rotation;
    public int car2suspension;
    public int car2tires;
    public int car2tank;

    public int car3engine;
    public int car3rotation;
    public int car3suspension;
    public int car3tires;
    public int car3tank;

    public int car4engine;
    public int car4rotation;
    public int car4suspension;
    public int car4tires;
    public int car4tank;

    public int car5engine;
    public int car5rotation;
    public int car5suspension;
    public int car5tires;
    public int car5tank;

    public int car6engine;
    public int car6rotation;
    public int car6suspension;
    public int car6tires;
    public int car6tank;

    public void SaveGame()
    {
        SaveSystem.SaveGame(this);
    }
    public void LoadGame()
    {
        GameData data = SaveSystem.LoadGame();

        GlobalCash.CashCount = data.Ccount;
        Purchases.car1bought = data.car1bought;
        Purchases.car2bought = data.car2bought;
        Purchases.car3bought = data.car3bought;
        Purchases.car4bought = data.car4bought;
        Purchases.car5bought = data.car5bought;
        Purchases.map1bought = data.map1bought;
        Purchases.map2bought = data.map2bought;
        Purchases.map3bought = data.map3bought;
        CarController.EngineLevel = data.car1engine;
        CarController.RotationLevel = data.car1rotation;
        CarController.SuspensionLevel = data.car1suspension;
        CarController.TiresLevel = data.car1tires;
        CarController.TankLevel = data.car1tank;
        CarController2.EngineLevel = data.car2engine;
        CarController2.RotationLevel = data.car2rotation;
        CarController2.SuspensionLevel = data.car2suspension;
        CarController2.TiresLevel = data.car2tires;
        CarController2.TankLevel = data.car2tank;
        CarController3.EngineLevel = data.car3engine;
        CarController3.RotationLevel = data.car3rotation;
        CarController3.SuspensionLevel = data.car3suspension;
        CarController3.TiresLevel = data.car3tires;
        CarController3.TankLevel = data.car3tank;
        CarController4.EngineLevel = data.car4engine;
        CarController4.RotationLevel = data.car4rotation;
        CarController4.SuspensionLevel = data.car4suspension;
        CarController4.TiresLevel = data.car4tires;
        CarController4.TankLevel = data.car4tank;
        CarController5.EngineLevel = data.car5engine;
        CarController5.RotationLevel = data.car5rotation;
        CarController5.SuspensionLevel = data.car5suspension;
        CarController5.TiresLevel = data.car5tires;
        CarController5.TankLevel = data.car5tank;
        CarController6.EngineLevel = data.car6engine;
        CarController6.RotationLevel = data.car6rotation;
        CarController6.SuspensionLevel = data.car6suspension;
        CarController6.SuspensionLevel = data.car6suspension;
        CarController6.TankLevel = data.car6tank;
    }
    public void Start()
    {
        InvokeRepeating("SaveGame", 1.0f, 1.0f);
        LoadGame();

    }
    // ERASE DATA
    public void EraseData()
    {
        car1bought = false;
        car2bought = false;
        car3bought = false;
        car4bought = false;
        car5bought = false;
        map1bought = false;
        map2bought = false;
        map3bought = false;
        car1engine = 0;
        car1rotation = 0;
        car1suspension = 0;
        car1tires = 0;
        car1tank = 0;
        car2engine = 0;
        car2rotation = 0;
        car2suspension = 0;
        car2tires = 0;
        car2tank = 0;
        car3engine = 0;
        car3rotation = 0;
        car3suspension = 0;
        car3tires = 0;
        car3tank = 0;
        car4engine = 0;
        car4rotation = 0;
        car4suspension = 0;
        car4tires = 0;
        car4tank = 0;
        car5engine = 0;
        car5rotation = 0;
        car5suspension = 0;
        car5tires = 0;
        car5tank = 0;
        car6engine = 0;
        car6rotation = 0;
        car6suspension = 0;
        car6tires = 0;
        car6tank = 0;
        GlobalCash.CashCount = 0;
    }
}
