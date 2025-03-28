using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GiveTicTacEvent : MonoBehaviour
{
    public TextMeshProUGUI receivedText;
    public GameObject ticTacPrefab;


    private void OnEnable()
    {
        CubeEvent.OnSixRolled += GiveTicTac; 
    }

    private void OnDisable()
    {
        CubeEvent.OnSixRolled -= GiveTicTac;
    }

    private void GiveTicTac()
    {
        receivedText.gameObject.SetActive(true);
        Instantiate(ticTacPrefab);
    }
}
