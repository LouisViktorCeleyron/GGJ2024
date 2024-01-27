using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CatAnimInteractor : MonoBehaviour
{

    public CatAnimation animToPlay;
    public UnityEvent endOfAnimEvent;
    private Cat cat;



    private void Start()
    {
        cat = ManagerManager.GetManager<CatManager>().GetCat();
    }

    public void LaunchAnim()
    {
        cat.SetAndLaunchAnimation(animToPlay, endOfAnimEvent);
    }
    

}
