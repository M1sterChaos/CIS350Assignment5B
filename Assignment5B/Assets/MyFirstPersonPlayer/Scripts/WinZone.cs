/*
 * (Austin Buck)
 * (Assignment 5B)
 * (This displays the win text when you hit the trigger)
 */
using UnityEngine;
using UnityEngine.UI;

public class WinZone : MonoBehaviour
{
    public GameObject winText;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            winText.SetActive(true);
        }
    }
}
