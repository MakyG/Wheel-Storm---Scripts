using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//MOTORBIKE!
public class CarController6 : MonoBehaviour
{

    public GameObject GasDisplay;
    public GameObject DisplaySpeed;
    public GameObject ArrowTachometer;
    public GameObject EngineDisplay;
    public GameObject SuspensionDisplay;
    public GameObject TiresDisplay;
    public GameObject RotationDisplay;
    public GameObject TankDisplay;

    public GameObject EngineLevelDisplay;
    public GameObject SuspensionLevelDisplay;
    public GameObject TiresLevelDisplay;
    public GameObject RotationLevelDisplay;
    public GameObject TankLevelDisplay;
    public GameObject DeathCanvas;
    public GameObject EarnedDisplay;

    public GameObject GasSoundAudio;
    public static int EngineLevel = 0;
    public static int SuspensionLevel = 0;
    public static int TiresLevel = 0;
    public static int RotationLevel = 0;
    public static int TankLevel = 0;
    public static int UpgradeCost = GlobalCash.cash;
    public static int UpgradeCostRotation = GlobalCash.cash;
    public static int UpgradeCostSuspension = GlobalCash.cash;
    public static int UpgradeCostTank = GlobalCash.cash;
    public static int UpgradeCostTires = GlobalCash.cash;

    public static int CashEarned = 0;
    public static float gas = 100f;
    public static float gasLeak = 0.02f;
    public SpringJoint2D frontSuspension;
    public SpringJoint2D backSuspension;

    public WheelJoint2D frontwheel;
    public WheelJoint2D backwheel;

    public AudioSource ThrottleSound;
    public AudioSource IdleSound;


    public Rigidbody2D rb;

    JointMotor2D motorFront;
    JointMotor2D motorBack;

    public static float speedF = 1200f;
    public static float speedB = -1200f;
    public float dirX;
    public float speedReal;
    public float speedRealFloored;
    public float arrowAngle;

    public static float torqueF = 350f;
    public static float torqueB = 350f;


    public bool TractionFront = true;
    public bool TractionBack = true;
    public bool ThrottleClicked = false;


    public float carRotationSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        ThrottleSound.Play();
        IdleSound.Play();
        gas = 100f;
        GasBar.currentCar = 6;
        rb.sharedMaterial.friction = 1f;

    }
    public void StartLeaking()
    {
        StartCoroutine("gasCoroutine");
    }
    void Update()
    {

        GasDisplay.GetComponent<Text>().text = "GAS: " + gas;
        CashEarned = GlobalCash.EarnedCashCount;

        EngineLevelDisplay.GetComponent<Text>().text = EngineLevel + "/15";
        SuspensionLevelDisplay.GetComponent<Text>().text = SuspensionLevel + "/15";
        RotationLevelDisplay.GetComponent<Text>().text = RotationLevel + "/15";
        TankLevelDisplay.GetComponent<Text>().text = TankLevel + "/15";
        TiresLevelDisplay.GetComponent<Text>().text = TiresLevel + "/15";

        EngineDisplay.GetComponent<Text>().text = "" + UpgradeCost;
        SuspensionDisplay.GetComponent<Text>().text = "" + UpgradeCostSuspension;
        RotationDisplay.GetComponent<Text>().text = "" + UpgradeCostRotation;
        TankDisplay.GetComponent<Text>().text = "" + UpgradeCostTank;
        TiresDisplay.GetComponent<Text>().text = "" + UpgradeCostTires;

        speedReal = GetComponent<Rigidbody2D>().velocity.magnitude * 3.6f;
        arrowAngle = speedReal;
        ArrowTachometer.transform.Rotate(0, 0, arrowAngle, Space.World);


        ThrottleSound.volume = 0.08f;
        ThrottleSound.pitch = 1f;

        speedRealFloored = Mathf.Floor(speedReal);

        DisplaySpeed.GetComponent<Text>().text = speedRealFloored + " km/h";
        ShowVelocity.ShowSpeed(speedReal, 0, 130);


        GetComponent<Rigidbody2D>().AddTorque(carRotationSpeed * CrossPlatformInputManager.GetAxis("Horizontal"));
        dirX = CrossPlatformInputManager.GetAxis("Horizontal");
        dirX = Input.GetAxisRaw("Horizontal");
        if (CrossPlatformInputManager.GetAxis("Horizontal") > 0 && gas > 0)
        {
            ThrottleSound.volume = 0.9f;
            ThrottleSound.pitch = (speedReal / 80) + 0.1f;
            gasLeak = 0.03f * ((5 + TankLevel) / 5);
            if (TractionFront)
            {
                motorFront.motorSpeed = speedF * -1;
                motorFront.maxMotorTorque = torqueF;
                frontwheel.motor = motorFront;
            }

            if (TractionBack)
            {
                motorBack.motorSpeed = speedF * -1;
                motorBack.maxMotorTorque = torqueF;
                backwheel.motor = motorBack;

            }
            else
            {
                motorBack.motorSpeed = 0;
            }

        }
        else if (CrossPlatformInputManager.GetAxis("Horizontal") < 0 && gas > 0)
        {
            ThrottleSound.volume = 0.9f;
            ThrottleSound.pitch = (speedReal / 80) + 0.1f;
            gasLeak = 0.03f * ((5 + TankLevel) / 5);
            if (TractionFront)
            {
                motorFront.motorSpeed = speedB * -1;
                motorFront.maxMotorTorque = torqueB;
                frontwheel.motor = motorFront;
            }

            if (TractionBack)
            {
                motorBack.motorSpeed = speedB * -1;
                motorBack.maxMotorTorque = torqueB;
                backwheel.motor = motorBack;
            }
            
            else
            {
                motorBack.motorSpeed = 0;
            }
        }
        else
        {
            gasLeak = 0.017f * (5 + TankLevel);
            backwheel.useMotor = false;
            frontwheel.useMotor = false;

        }
        torqueF = (130f * EngineLevel + 4200) * 0.25f;
        torqueB = (130f * EngineLevel + 4200) * 0.25f;
        speedF = (130f * EngineLevel + 4200) * 0.25f;
        UpgradeCost = 400 * (EngineLevel) + 400;

        carRotationSpeed = RotationLevel + 8;
        UpgradeCostRotation = 400 * (RotationLevel) + 400;

        frontSuspension.frequency = (SuspensionLevel + 1) * 0.25f;
        backSuspension.frequency = (SuspensionLevel + 1) * 0.25f;
        UpgradeCostSuspension = 400 * (SuspensionLevel) + 400;

        
        UpgradeCostTank = 400 * (TankLevel) + 400;

        WheelMaterial.wheelFriction = 0.1f + (0.05f * (TiresLevel + 1));
        UpgradeCostTires = 400 * (TiresLevel) + 400;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Gas"))
        {
            Destroy(other.gameObject);
            GasSoundAudio.GetComponent<AudioSource>().Play();
            gas = 100f;
        }
    }
    IEnumerator gasCoroutine()
    {
        yield return new WaitForSeconds(gasLeak);
        gas -= 0.15f;
        StartCoroutine("gasCoroutine");
        if (gas <= 0)
        {
            StopCoroutine("gasCoroutine");
            StartCoroutine("DeathDelay");

        }
    }

    IEnumerator DeathDelay()
    {
        yield return new WaitForSeconds(3f);

        if (gas <= 0)
        {
            DeathCanvas.SetActive(true);
            EarnedDisplay.GetComponent<Text>().text = "" + CashEarned;
        }
        StartCoroutine("gasCoroutine");
    }




    public void upgradeEngine()
    {
        if (GlobalCash.CashCount >= UpgradeCost)
        {
            if (EngineLevel < 15)
            {
                GlobalCash.CashCount -= UpgradeCost;
                UpgradeCost += 600;
                EngineLevel++;
            }
        }
    }
    public void upgradeRotation()
    {
        if (GlobalCash.CashCount >= UpgradeCostRotation)
        {
            if (RotationLevel < 15)
            {
                GlobalCash.CashCount -= UpgradeCostRotation;
                RotationLevel++;
            }
        }
    }
    public void upgradeSuspension()
    {
        if (GlobalCash.CashCount >= UpgradeCostSuspension)
        {
            if (SuspensionLevel < 15)
            {
                GlobalCash.CashCount -= UpgradeCostSuspension;
                SuspensionLevel++;
            }
        }
    }
    public void upgradeTank()
    {
        if (GlobalCash.CashCount >= UpgradeCostTank)
        {
            if (TankLevel < 15)
            {
                GlobalCash.CashCount -= UpgradeCostTank;
                TankLevel++;
            }
        }
    }
    public void upgradeTires()
    {
        if (GlobalCash.CashCount >= UpgradeCostTires)
        {
            if (TiresLevel < 15)
            {
                GlobalCash.CashCount -= UpgradeCostTires;
                TiresLevel++;
            }
        }
    }
}