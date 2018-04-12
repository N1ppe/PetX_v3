using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quest : MonoBehaviour
{
    public GameObject gm;
    public bool startedQuest=false;
    public missionNames questName;

    void Start ()
    {
        gm = GameObject.FindWithTag("GameManagementTag");
    }
	void Update ()
    {
        if (startedQuest == true) { missionsUiUpdating(); }
	}
    public void missionsUi()
    {
        //start text
        if (questName == missionNames.Gaia){
            gm.GetComponent<gamemanagement>().questLogTexts[0].text = gm.GetComponent<gamemanagement>().quests[0].questName;
            gm.GetComponent<gamemanagement>().questSprites[0] = gm.GetComponent<gamemanagement>().quests[0].qSprt;
        }
        if (questName == missionNames.Holy) {
            gm.GetComponent<gamemanagement>().questLogTexts[1].text = gm.GetComponent<gamemanagement>().quests[1].questName;
            gm.GetComponent<gamemanagement>().questSprites[1] = gm.GetComponent<gamemanagement>().quests[1].qSprt;
        }
        if (questName == missionNames.PrimalWater) {
            gm.GetComponent<gamemanagement>().questLogTexts[2].text = gm.GetComponent<gamemanagement>().quests[2].questName;
            gm.GetComponent<gamemanagement>().questSprites[2] = gm.GetComponent<gamemanagement>().quests[2].qSprt;
        }
        if (questName == missionNames.PrimalEarth) {
            gm.GetComponent<gamemanagement>().questLogTexts[3].text = gm.GetComponent<gamemanagement>().quests[3].questName;
            gm.GetComponent<gamemanagement>().questSprites[3] = gm.GetComponent<gamemanagement>().quests[3].qSprt;
        }
        if (questName == missionNames.BlackIce) {
            gm.GetComponent<gamemanagement>().questLogTexts[4].text = gm.GetComponent<gamemanagement>().quests[4].questName;
            gm.GetComponent<gamemanagement>().questSprites[4] = gm.GetComponent<gamemanagement>().quests[4].qSprt;
        }
        if (questName == missionNames.IceFire) {
            gm.GetComponent<gamemanagement>().questLogTexts[5].text = gm.GetComponent<gamemanagement>().quests[5].questName;
            gm.GetComponent<gamemanagement>().questSprites[5] = gm.GetComponent<gamemanagement>().quests[5].qSprt;
        }
        if (questName == missionNames.Thunderstorm) {
            gm.GetComponent<gamemanagement>().questLogTexts[6].text = gm.GetComponent<gamemanagement>().quests[6].questName;
            gm.GetComponent<gamemanagement>().questSprites[6] = gm.GetComponent<gamemanagement>().quests[6].qSprt;
        }
        /*
        string questNameCheck="";
        if (questName == missionNames.Gaia) { questNameCheck = gm.GetComponent<gamemanagement>().quests[0].questName; }
        if (questName == missionNames.Holy) { questNameCheck = questNameCheck = gm.GetComponent<gamemanagement>().quests[1].questName; }
        if (questName == missionNames.PrimalWater) { questNameCheck = questNameCheck = gm.GetComponent<gamemanagement>().quests[2].questName; }
        if (questName == missionNames.PrimalEarth) { questNameCheck = gm.GetComponent<gamemanagement>().quests[3].questName; }
        if (questName == missionNames.BlackIce) { questNameCheck = gm.GetComponent<gamemanagement>().quests[4].questName; }
        if (questName == missionNames.IceFire) { questNameCheck = gm.GetComponent<gamemanagement>().quests[5].questName; }
        if (questName == missionNames.Thunderstorm) { questNameCheck = gm.GetComponent<gamemanagement>().quests[6].questName; }

        for (int r = 0; r < gm.GetComponent<gamemanagement>().questLogTexts.Length;r++)
        {
            if (questNameCheck == gm.GetComponent<gamemanagement>().quests[r].questName)//from quests list
            {
                Debug.Log(r);
                Debug.Log(gm.GetComponent<gamemanagement>().quests[r].questName);
                for (int rr = 0; rr < gm.GetComponent<gamemanagement>().questLogTexts.Length; rr++)
                {
                    if (gm.GetComponent<gamemanagement>().questLogTexts[rr].text == "")//to first empty text in UI
                    {
                        gm.GetComponent<gamemanagement>().questLogTexts[rr].text = questNameCheck;
                        return;
                    }
                }
            }
        }
        */
    }
    public void missionsUiUpdating()
    {
        if (questName == missionNames.Gaia) { }
        if (questName == missionNames.Holy) { }
        if (questName == missionNames.PrimalWater) { }
        if (questName == missionNames.PrimalEarth) { }
        if (questName == missionNames.BlackIce) { }
        if (questName == missionNames.IceFire) { }
        if (questName == missionNames.Thunderstorm) { }
    }
    public void missionsOperation()
    {
        if (questName == missionNames.Gaia) { }
        if (questName == missionNames.Holy) { }
        if (questName == missionNames.PrimalWater) { }
        if (questName == missionNames.PrimalEarth) { }
        if (questName == missionNames.BlackIce) { }
        if (questName == missionNames.IceFire) { }
        if (questName == missionNames.Thunderstorm) { }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (startedQuest == false) { missionsUi(); }
            startedQuest = true;
            missionsOperation();
        }
    }
    void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

        }
    }
    void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Player")
        {

        }
    }
}
public enum missionNames
{
    Gaia,Holy,PrimalWater,PrimalEarth,BlackIce,IceFire,Thunderstorm
}
public enum missionType
{
    gatherItems,getToLocation
}