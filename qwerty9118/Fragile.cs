using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fragile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (this.GetComponent<FoodItem>().getCookedLevel() > 0)
        {
            Destroy(this.GetComponent<Fragile>());
        }

	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
        Destroy(this);
	}

}
