using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    //script var
    public Player play;

    //toggle group var
    public GameObject ingredientGroup;
    public GameObject recipeGroup;
    public Text[] ingredientCountList = new Text[9];
    public Toggle[] ingredientToggleList = new Toggle[9];

    //button var
    public Button buybutton;
    public Button selectButton;


    // Start is called before the first frame update
    void Start()
    {
        foreach (Text i in ingredientCountList)
        {
            i.text = "0" ;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SelectIngredients()
    {
        Toggle[] ingToggles = ingredientGroup.GetComponentsInChildren<Toggle>();
        for(int i = 0; i < ingToggles.Length; i++)
        {
            if (ingToggles[i].isOn)
            {
                play.selectIngredients(i);
                ingredientCountList[i].text = play.ingredientDict[i].ToString();
                ingToggles[i].isOn = false;
            }
            //Debug.Log("none");
        }

    }

    public void BuyRecipe()
    {
        Toggle[] recipeToggles = recipeGroup.GetComponentsInChildren<Toggle>();
        foreach (Toggle t in recipeToggles)
        {
            if (t.isOn)
            {
                
            }
            //Debug.Log("none");
        }
    }
}
