using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class demo : MonoBehaviour
{
    public GameObject ingredientGroup;
    public GameObject recipeGroup;

    void Start()
    {


    }

    void Update()
    {
        GetSelectedToggle();
    }

    public void GetSelectedToggle()
    {
        Toggle[] ingToggles = ingredientGroup.GetComponentsInChildren<Toggle>();
        foreach (Toggle t in ingToggles)
        {
            if (t.isOn)
            {
                string name = t.name;
                Debug.Log(name);
            }
            Debug.Log("none");
        }
    }

}
