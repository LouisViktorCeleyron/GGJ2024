using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetText : MonoBehaviour
{
    public TextMeshProUGUI textMeshPro;
    MoneyManager moneyManager;
    // Start is called before the first frame update
    void Start()
    {
        moneyManager = ManagerManager.GetManager<MoneyManager>();
        textMeshPro.text = $" You just cost <color=red>{moneyManager.GetMoney()}</color> US$ to the owner of Criminou Mc Patoune";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
