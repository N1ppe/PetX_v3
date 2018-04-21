using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class cheats : MonoBehaviour {

    public GameObject cheatUIpart,gm;
	void Start ()
    {
        gm = GameObject.FindGameObjectWithTag("GameManagementTag");
	}
	void Update ()
    {
        //if (cheatUIpart.activeInHierarchy == true)
        cheatbuttonCheck(); 

	}
    public void allPetsOpen()
    {
        for(int loopy = 0; loopy < gm.GetComponent<gamemanagement>().AllMonsters.Length; loopy++)
        {
            gm.GetComponent<gamemanagement>().AllMonsters[loopy].allowEvolution = true;
        }
    }

    public void cheatbuttonCheck()
    {
        if (EventSystem.current.currentSelectedGameObject != null)
        {
            if (EventSystem.current.currentSelectedGameObject.name == "cheat1") { allPetsOpen(); EventSystem.current.currentSelectedGameObject.GetComponentInChildren<Text>().text = "All pets in use"; }
            if (EventSystem.current.currentSelectedGameObject.name == "cheat2") { gm.GetComponent<gamemanagement>().money = 1000; }
            if (EventSystem.current.currentSelectedGameObject.name == "cheat3") { }
            if (EventSystem.current.currentSelectedGameObject.name == "cheat4") { }
            if (EventSystem.current.currentSelectedGameObject.name == "cheat5") { }
            if (EventSystem.current.currentSelectedGameObject.name == "cheat6") { }
            if (EventSystem.current.currentSelectedGameObject.name == "cheat7") { }
            if (EventSystem.current.currentSelectedGameObject.name == "cheat8") { }
            if (EventSystem.current.currentSelectedGameObject.name == "cheat9") { }
            if (EventSystem.current.currentSelectedGameObject.name == "cheat10") { }
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            cheatUIpart.SetActive(true);
        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            cheatUIpart.SetActive(false);
        }
    }
}
