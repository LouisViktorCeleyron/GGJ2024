using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{

    [SerializeField]
    private TextMeshProUGUI timerTextGUI;

    public float timer;

    private void Start()
    {
        timer = 30.00f;
    }

    private void Update()
    {
        ManageTime();            
    }

    public void AddTime(float additionalTime)
    {
        timer += additionalTime;
    }

    private void ManageTime()
    {
        timer -= Time.deltaTime;
        timer = Mathf.Clamp(timer,0.0f,180.0f);

        timerTextGUI.text = timer.ToString("00");
        if(timer<=0.0)
        {
            SceneManager.LoadScene(1);
        }
    }

}
