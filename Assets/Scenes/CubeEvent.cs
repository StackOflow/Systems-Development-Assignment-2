using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeEvent : MonoBehaviour
{
    public void GenerateRandomNumber()
    {
        //Generates a random number from 1-6 then outputs it to debug log
        int randomNumber = Random.Range(1, 7);  
        Debug.Log("Rolled a " + randomNumber + "!");  
    }
}
