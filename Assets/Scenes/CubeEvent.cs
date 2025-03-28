using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class CubeEvent : MonoBehaviour
{
    public GameObject thePrize;
    public delegate void RolledSixEvent();
    public static event RolledSixEvent OnSixRolled;

    private List<string> inventory = new List<string>();
    
    public void GenerateRandomNumber()
    {
        //Generates a random number from 1-6 then outputs it to debug log
        int randomNumber = Random.Range(1, 7);  
        Debug.Log("Rolled a " + randomNumber + "!");  

        if (randomNumber == 6)
        {
            AddTicTac();
            //EventTrigger();
        }
    }

   //public void EventTrigger()
   // {
   //     //creates the prize
   //     Instantiate(thePrize);
   // }

    
    public void AddTicTac()
    {
        OnSixRolled?.Invoke();
    }
}
