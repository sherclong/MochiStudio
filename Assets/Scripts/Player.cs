using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //ingredient gameobject
    public GameObject ing1;
    public GameObject ing2;
    public GameObject ing3;
    public GameObject ing4;
    public GameObject ing5;
    public GameObject ing6;
    public GameObject ing7;
    public GameObject ing8;
    public GameObject ing9;
    //public GameObject[] ingredientsList;

    public Dictionary<int, int> ingredientDict = new Dictionary<int, int>();
    public Dictionary<GameObject, int> recipeDict = new Dictionary<GameObject, int>();

    // Start is called before the first frame update
    void Start()
    {
        ingredientDict[0] = 0;
        ingredientDict[1] = 0;
        ingredientDict[2] = 0;
        ingredientDict[3] = 0;
        ingredientDict[4] = 0;
        ingredientDict[5] = 0;
        ingredientDict[6] = 0;
        ingredientDict[7] = 0;
        ingredientDict[8] = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }

    //dict.Add(key, value) to add values to dictionary

    public void buyRecipe(GameObject card)
    {
        //but if they buy a duplicate, it will not update to two
        //maybe we should make a dictionary with all keys define and just update value
        recipeDict.Add(card, 1);
    }

    public void selectIngredients(int card)
    {
        //same problem as above
        ingredientDict[card] += 1;
        Debug.Log("Card val:" + ingredientDict[card]);
    }

    public void containsIngredient(int card)
    {
        if (ingredientDict.ContainsKey(card) == true)
        {
            Debug.Log("Key is found.");
        }
        else
        {
            Debug.Log("Key is not found.");
        }
    }

    public void containsRecipe(GameObject card)
    {
        if (recipeDict.ContainsKey(card) == true)
        {
            Debug.Log("Key is found.");
        }
        else
        {
            Debug.Log("Key is not found.");
        }
    }


}
