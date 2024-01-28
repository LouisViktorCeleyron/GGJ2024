using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeManager : MonoBehaviour
{
   
    public List<GameObject> interactibles;
    private List<GameObject> interactiblesTemp;
    // Start is called before the first frame update
    void Start()
    {
        interactiblesTemp = new List<GameObject>();
        for (int i = 0; i <= 7; i++) 
        {
            interactiblesTemp.Add(interactibles[Random.Range(0,interactibles.Count)]);   
        }
        foreach (GameObject obj in interactiblesTemp)
        {
            obj.SetActive(true);
        }
    }

}
