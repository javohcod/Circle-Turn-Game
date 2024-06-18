using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BallScript : MonoBehaviour
{
    public int score;
    public bool isMulti;
    public GameObject BonusEffect;
    [SerializeField] Text scoreText;
    [SerializeField] Sprite[] skins; 
    [SerializeField] SpriteRenderer ballRenderer;
    

    public void Start()
    {
        isMulti = PlayerPrefs.GetInt("isMulti") == 1 ? true : false;
        int selectedSkinIndex = PlayerPrefs.GetInt("SelectedSkinIndex", 0);
        if (ballRenderer != null && skins.Length > selectedSkinIndex)
        {
            ballRenderer.sprite = skins[selectedSkinIndex];
        }
        else
        {
            Debug.LogError("ballRenderer is not set in the inspector or skins array is invalid");
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Bonus")
        {
            Destroy(other.gameObject);
            Instantiate(BonusEffect, transform.position, Quaternion.identity);
            if (isMulti == true)
            {
                score += 2;
            }
            else
                score++;
        }

        if (other.gameObject.tag == "Enemy")
        {
            PlayerPrefs.SetInt("Score", score);
            SceneManager.LoadScene(2);
        }
    }

    private void Update()
    {
        scoreText.text = score.ToString();
    }
}
