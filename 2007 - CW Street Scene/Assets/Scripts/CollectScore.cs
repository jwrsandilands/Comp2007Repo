using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectScore : MonoBehaviour
{
    public int coinScore;
    public int playerScore;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Coin")
        {
            playerScore += coinScore;
            Destroy(other.gameObject);
        }
    }
}
