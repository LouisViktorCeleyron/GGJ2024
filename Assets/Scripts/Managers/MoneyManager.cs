using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MoneyManager : Manager
{
    private int money;
    public TextMeshProUGUI moneyTextGUI;
    public Image angerFill;
    public Color baseColor,angryColor;

    public void LoseMoney(int moneyAmount)
    {
        this.money += moneyAmount;
        UpdateText();
    }

    public string GetMoney() 
    {
        return money.ToString("");
    }

    private void UpdateText()
    {
        var ratio = (float)money / 900.00f;
        angerFill.color = Color.Lerp(baseColor, angryColor, ratio);
        angerFill.fillAmount = ratio;

        moneyTextGUI.text = "$ -" + money.ToString("000000");
    }
}
