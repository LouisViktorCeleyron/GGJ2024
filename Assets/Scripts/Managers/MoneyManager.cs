using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoneyManager : Manager
{
    private int money;

    public void LoseMoney(int moneyAmount)
    {
        this.money -= moneyAmount;

    }
}
