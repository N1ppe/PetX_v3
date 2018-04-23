using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirshipPortals : MonoBehaviour {

    public GameObject player, pet;
    public GameObject TeleportLocation;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        pet = GameObject.FindWithTag("Pet");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            player.transform.position = TeleportLocation.transform.position;
            pet.transform.position = TeleportLocation.transform.position;
        }
    }
}