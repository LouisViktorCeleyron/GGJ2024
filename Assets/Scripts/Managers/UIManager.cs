using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : Manager
{

    public GameObject descriptionCanvas;
    public TextMeshProUGUI descriptionGUI;

    public void SetText(string newText)
    {
        descriptionCanvas.SetActive(true);
        descriptionGUI.text = newText;
    }


}
