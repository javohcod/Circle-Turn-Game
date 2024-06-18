using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public int money;
    private int earnedmoney;
    public Text moneyText;

    private void Start()
    {
        money = PlayerPrefs.GetInt("Money");
        earnedmoney = PlayerPrefs.GetInt("Score");
        money += earnedmoney;
        PlayerPrefs.SetInt("Money", money);
        moneyText.text = money.ToString();
        earnedmoney = 0;
        PlayerPrefs.SetInt("Score", earnedmoney);
    }
}
