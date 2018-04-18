using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroySpawner : MonoBehaviour {

    public elements portalsElement;
    public GameObject UIpart;
    bool inTrigger = false;

	void Start ()
    {
		
	}
	void Update ()
    {
        if (Input.GetButtonDown("interract"))
        {
            UIpart.active = !UIpart.active;
        }
	}
    void OnTriggerStay2D(Collider2D other)
    {
        
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        inTrigger = true;
    }
    void OnTriggerExit2D(Collider2D other)
    {
        inTrigger = false;
        UIpart.active = false;
    }
}