using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ShopAssist : MonoBehaviour
{
    public int money;
    public Text moneyText;
    public bool isMulti = false;
    public Sprite[] skins; 
    public Image ballImage;
    private int selectedSkinIndex;

    private void Start()
    {
        money = PlayerPrefs.GetInt("Money");

    }

    private void Update()
    {
        moneyText.text = money.ToString();
        selectedSkinIndex = PlayerPrefs.GetInt("SelectedSkinIndex", 0);

    }

    public void BuyMulti()
    {
        if (money >= 55 && isMulti == false)
        {
            isMulti = true;
            money -= 55;
            PlayerPrefs.SetInt("Money", money);
            PlayerPrefs.SetInt("isMulti", isMulti ? 1 : 0);

        }
        else Debug.Log("You don't have enought money");
    }
    
    public void BuySkin(int skinIndex)
    {
        if (money >= 150)
        {
            money -= 150;
            PlayerPrefs.SetInt("Money", money);
            selectedSkinIndex = skinIndex;
            PlayerPrefs.SetInt("SelectedSkinIndex", selectedSkinIndex);

            if (ballImage != null)
            {
                ballImage.sprite = skins[selectedSkinIndex];
            }
            else
            {
                Debug.LogError("ballImage is not set in the inspector");
            }
        }
        else
        {
            Debug.Log("You don't have enough money");
        }
    }
    public void BuySkin2(int skinIndex)
    {
        if (money >= 200)
        {
            money -= 200;
            PlayerPrefs.SetInt("Money", money);
            selectedSkinIndex = skinIndex;
            PlayerPrefs.SetInt("SelectedSkinIndex", selectedSkinIndex);

            if (ballImage != null)
            {
                ballImage.sprite = skins[selectedSkinIndex];
            }
            else
            {
                Debug.LogError("ballImage is not set in the inspector");
            }
        }
        else
        {
            Debug.Log("You don't have enough money");
        }
    }

    public void ExitShop()
    {
        SceneManager.LoadScene(0);
    }
}
