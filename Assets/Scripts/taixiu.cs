using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class taixiu : MonoBehaviour
{
    private int guessNumber; 
    private int money = 100000;
    public Text textInfo;

    public Text moneyInfo;

    public Text nameInfo;

    public static string nameStr;

    public InputField moneyGambling;

    void Start()
    {
        nameInfo.text = nameStr;

        guessNumber = Random.Range (3, 18);
        moneyInfo.text = money.ToString();
    }

    void Update()
    {
        guessNumber = Random.Range (3, 18);
    }

    public void taiController () {
        if (guessNumber >= 11) {
            textInfo.text = guessNumber.ToString() + " TAI";
            money += int.Parse(moneyGambling.text);
        } else {
            textInfo.text = guessNumber.ToString() + " XIU";
            money -= int.Parse(moneyGambling.text);
        }
        if (money > 0) {
            moneyInfo.text = money.ToString();
        } else {
            moneyInfo.text = "Nap tien de choi tiep";
        }

        moneyGambling.text = "";
    }

    public void xiuController () {
        if (guessNumber <= 10) {
            textInfo.text = guessNumber.ToString() + " XIU";
            money += int.Parse(moneyGambling.text);
        } else {
            textInfo.text = guessNumber.ToString() + " TAI";
            money -= int.Parse(moneyGambling.text);
        }
        if (money > 0) {
            moneyInfo.text = money.ToString();
        } else {
            moneyInfo.text = "Nap tien de choi tiep";
        }

        moneyGambling.text = "";
    }
}
