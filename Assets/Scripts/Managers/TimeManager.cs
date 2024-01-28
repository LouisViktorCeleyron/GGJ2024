using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimeManager : MonoBehaviour
{

    [SerializeField]
    private TextMeshProUGUI timerTextGUI;
    private SoundManager soundManager;
    public float timer;
    private bool doOnce;
    private void Start()
    {
        soundManager = ManagerManager.GetManager<SoundManager>();   
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
            SceneManager.LoadScene(3);
        }
        if(timer<=10)
        {
            if(!doOnce)
            {
                doOnce = true;
                soundManager.ChangeSongByTime();
            }
        }
    }

}
