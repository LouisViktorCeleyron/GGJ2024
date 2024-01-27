using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class MoneyManager : Manager
{
    private int money;
    public TextMeshProUGUI moneyTextGUI;


    public void LoseMoney(int moneyAmount)
    {
        this.money += moneyAmount;
        UpdateText();
    }

    private void UpdateText()
    {
        moneyTextGUI.text = "$ -" + money.ToString("000000");
    }
}
