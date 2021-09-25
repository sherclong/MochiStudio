using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.UIElements;

public class demo : MonoBehaviour
{
    public GameObject ingredientGroup;
    public GameObject recipeGroup;

    public Text waterText;
    public Text flourText;

    public Button enterButton;

    void Start()
    {
        enterButton.onClick.AddListener(GetSelectedToggle);
    }

    void Update()
    {
        
    }

    public void GetSelectedToggle()
    {
        Toggle[] ingToggles = ingredientGroup.GetComponentsInChildren<Toggle>();
        foreach (Toggle t in ingToggles)
        {
            if (t.isOn)
            {
                string name = t.name;
                if (name == "water")
                {
                    waterText.text = "x 1";
                }
                else if (name == "flour")
                {
                    flourText.text = "x 1";
                }
                //Debug.Log(name);
            }
            //Debug.Log("none");
        }

    }

}
