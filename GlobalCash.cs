using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GlobalCash : MonoBehaviour
{
    public GameObject CashDisplay;
    public GameObject CoinSoundAudio;
    
    public static int CashCount = 0;
    public static int EarnedCashCount = 0;
    public int InternalCash;
    public static int cash = 400;




    void Update()
    {

        InternalCash = CashCount;
        CashDisplay.GetComponent<Text>().text = "" + InternalCash;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin5"))
        {
            Destroy(other.gameObject);
            CoinSoundAudio.GetComponent<AudioSource>().Play();
            CashCount += 5;
            EarnedCashCount += 5;
        }
        if (other.gameObject.CompareTag("Coin25"))
        {
            Destroy(other.gameObject);
            CoinSoundAudio.GetComponent<AudioSource>().Play();
            CashCount += 25;
            EarnedCashCount += 25;
        }
        if (other.gameObject.CompareTag("Coin50"))
        {
            Destroy(other.gameObject);
            CoinSoundAudio.GetComponent<AudioSource>().Play();
            CashCount += 50;
            EarnedCashCount += 50;
        }
        if (other.gameObject.CompareTag("Coin100"))
        {
            Destroy(other.gameObject);
            CoinSoundAudio.GetComponent<AudioSource>().Play();
            CashCount += 100;
            EarnedCashCount += 100;
        }
        if (other.gameObject.CompareTag("Coin250"))
        {
            Destroy(other.gameObject);
            CoinSoundAudio.GetComponent<AudioSource>().Play();
            CashCount += 250;
            EarnedCashCount += 250;
        }
    }

}
