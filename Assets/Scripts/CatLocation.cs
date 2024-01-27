using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatLocation : MonoBehaviour
{
    public Transform catPlace;

    private CatManager _catManager;

    private void Start()
    {
        _catManager = ManagerManager.GetManager<CatManager>();
    }

    public void AddCat()
    {
        _catManager.GetCat().SetPosition(catPlace);
    }

    public void RemoveCat()
    {



    }
}
