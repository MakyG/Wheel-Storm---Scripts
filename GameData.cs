using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]

public class GameData
{
    public int Ccount = GlobalCash.CashCount;
    public bool car1bought = Purchases.car1bought; // car1bought != car1
    public bool car2bought = Purchases.car2bought;
    public bool car3bought = Purchases.car3bought;
    public bool car4bought = Purchases.car4bought;
    public bool car5bought = Purchases.car5bought;
    
    public bool map1bought = Purchases.map1bought;
    public bool map2bought = Purchases.map2bought;
    public bool map3bought = Purchases.map3bought;

    public int car1engine = CarController.EngineLevel;
    public int car1rotation = CarController.RotationLevel;
    public int car1suspension = CarController.SuspensionLevel;
    public int car1tires = CarController.TiresLevel;
    public int car1tank = CarController.TankLevel;
    public int car2engine = CarController2.EngineLevel;
    public int car2rotation = CarController2.RotationLevel;
    public int car2suspension = CarController2.SuspensionLevel;
    public int car2tires = CarController2.TiresLevel;
    public int car2tank = CarController2.TankLevel;
    public int car3engine = CarController3.EngineLevel;
    public int car3rotation = CarController3.RotationLevel;
    public int car3suspension = CarController3.SuspensionLevel;
    public int car3tires = CarController3.TiresLevel;
    public int car3tank = CarController3.TankLevel;
    public int car4engine = CarController4.EngineLevel;
    public int car4rotation = CarController4.RotationLevel;
    public int car4suspension = CarController4.SuspensionLevel;
    public int car4tires = CarController4.TiresLevel;
    public int car4tank = CarController4.TankLevel;
    public int car5engine = CarController5.EngineLevel;
    public int car5rotation = CarController5.RotationLevel;
    public int car5suspension = CarController5.SuspensionLevel;
    public int car5tires = CarController5.TiresLevel;
    public int car5tank = CarController5.TankLevel;
    public int car6engine = CarController6.EngineLevel;
    public int car6rotation = CarController6.RotationLevel;
    public int car6suspension = CarController6.SuspensionLevel;
    public int car6tires = CarController6.TiresLevel;
    public int car6tank = CarController6.TankLevel;

    public GameData(Game game)
    { 
        game.Ccount = GlobalCash.CashCount;
        game.car1bought = Purchases.car1bought;
        game.car2bought = Purchases.car2bought;
        game.car3bought = Purchases.car3bought;
        game.car4bought = Purchases.car4bought;
        game.car5bought = Purchases.car5bought;
        game.map1bought = Purchases.map1bought;
        game.map2bought = Purchases.map2bought;
        game.map3bought = Purchases.map3bought;
        game.car1engine = CarController.EngineLevel;
        game.car1rotation = CarController.RotationLevel;
        game.car1suspension = CarController.SuspensionLevel;
        game.car1tires = CarController.TiresLevel;
        game.car1tank = CarController.TankLevel;
        game.car2engine = CarController2.EngineLevel;
        game.car2rotation = CarController2.RotationLevel;
        game.car2suspension = CarController2.SuspensionLevel;
        game.car2tires = CarController2.TiresLevel;
        game.car2tank = CarController2.TankLevel;
        game.car3engine = CarController3.EngineLevel;
        game.car3rotation = CarController3.RotationLevel;
        game.car3suspension = CarController3.SuspensionLevel;
        game.car3tires = CarController3.TiresLevel;
        game.car3tank = CarController3.TankLevel;
        game.car4engine = CarController4.EngineLevel;
        game.car4rotation = CarController4.RotationLevel;
        game.car4suspension = CarController4.SuspensionLevel;
        game.car4tires = CarController4.TiresLevel;
        game.car4tank = CarController4.TankLevel;
        game.car5engine = CarController5.EngineLevel;
        game.car5rotation = CarController5.RotationLevel;
        game.car5suspension = CarController5.SuspensionLevel;
        game.car5tires = CarController5.TiresLevel;
        game.car5tank = CarController5.TankLevel;
        game.car6engine = CarController6.EngineLevel;
        game.car6rotation = CarController6.RotationLevel;
        game.car6suspension = CarController6.SuspensionLevel;
        game.car6tires = CarController6.TiresLevel;
        game.car6tank = CarController6.TankLevel;
    }
}
