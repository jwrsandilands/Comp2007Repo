using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectScore : MonoBehaviour
{
    public int coinScore;
    public int playerScore;
    public AudioClip coinAudio;
    public GameObject cameraMic;
    

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Coin")
        {
            playerScore += coinScore;
            Destroy(other.gameObject);
            AudioSource.PlayClipAtPoint(coinAudio, cameraMic.transform.position);
        }
        if(other.tag == "Cone")
        {
            if(playerScore >= 30)
            {
                playerScore -= coinScore * 3;
            }
            else
            {
                playerScore -= playerScore;
            }

            Destroy(other.gameObject);
        }
    }
}
