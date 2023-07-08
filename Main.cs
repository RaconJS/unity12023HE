using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{

    private string[] foods =
    {
        "Bacon",
        "Beef",
        "Bread",
        "Chicken",
        "Cucumber",
        "Egg",
        "Leek",
        "Lettuce",
        "Onion",
        "Pasta",
        "Peas",
        "Pepper",
        "Potato",
        "Rice",
        "Tofu",
        "Tomato"
    };

    private int currentIngredient = 0;

    // Start is called before the first frame update
    void Start()
    {

        /*for (int i = 1; i < foods.Length; i++)
        {
            Debug.Log(foods[i]);
            GameObject.Find(foods[i]).GetComponent<PlayerMovement>().enabled = false;
        }*/
        
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.E))
        {
            //Debug.Log("before: "+currentIngredient + " - " + foods[currentIngredient]);

            GameObject.Find(foods[currentIngredient]).GetComponent<PlayerMovement>().enabled = false;

            currentIngredient++;

            if (currentIngredient >= foods.Length)
            {
                currentIngredient = 0;
            }

            GameObject.Find(foods[currentIngredient]).GetComponent<PlayerMovement>().enabled = true;

            Debug.Log("after: " + currentIngredient + " - " + foods[currentIngredient]);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            //Debug.Log("before: " + currentIngredient + " - " + foods[currentIngredient]);

            GameObject.Find(foods[currentIngredient]).GetComponent<PlayerMovement>().enabled = false;

            currentIngredient--;

            if (currentIngredient < 0)
            {
                currentIngredient = foods.Length - 1;
            }

            GameObject.Find(foods[currentIngredient]).GetComponent<PlayerMovement>().enabled = true;

            Debug.Log("after: " + currentIngredient + " - " + foods[currentIngredient]);
        }

    }

}
