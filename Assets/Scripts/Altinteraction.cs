using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Altinteraction : MonoBehaviour
{
    public List<ParticleSystem> systems;
    public void ActivateAllChildEffect()
    {
        foreach (var sys in systems)
        {
            sys.Play();
        }
    }

    public void ChangeScene(int index)
    {
        SceneManager.LoadScene(index);
    }
}
