using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clone : MonoBehaviour {

    public GameObject preFab;
    public Text cloneAmount;
    public Text cloneLeft;
    public int counter;


	// Use this for initialization
	void Start () {
        counter = 0;
        cloneLeft.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    public void ClonePreFab()
    {

        //counter = cloneLeft.text;
        var amount = int.Parse(cloneAmount.text);
        if ( amount < counter)
        {

            Instantiate(preFab);
            counter--;
        }
        else
        {
            Debug.Log("NADA");
        }


    }

}
/*
 * 
 *         amountText = int.Parse(cloneAmount.text);
       if (counter < amountText)
        {
            Instantiate(preFab);
            counter++;
            cloneLeft.text = (amountText - counter).ToString();
        }





*/
