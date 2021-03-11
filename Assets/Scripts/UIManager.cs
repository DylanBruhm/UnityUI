using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public float score = 0;
    public Text ScoreOutput;

    public GameObject moneyImage;
    public bool isMoneyVisible = false;

    
    // Update is called once per frame
    private void Update()
    {
        ScoreOutput.text = score.ToString();
    }
    public void IncreaseMoney()
    {
        score++;
    }
    public void ResetMoney()
    {
        score = 0;
    }
    public void HideShowImage()
    {
        if (isMoneyVisible == false) { isMoneyVisible = true; moneyImage.SetActive(true); }
        else if (isMoneyVisible ) { isMoneyVisible = false; moneyImage.SetActive(false); }
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
