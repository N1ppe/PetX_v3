﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quest : MonoBehaviour
{
    [Header("TO GET TO NEXT TEXT, CALL  missionsUiUpdating();  ONCE")]
    public GameObject gm;
    public bool startedQuest=false;
    public missionNames questName;

    public int missionAdvancement;
    [TextArea(1, 15)]
    public string[] logtexts;
    [Header("Quest Advancer")]
    public bool isQuestAdvancer = false;
    public GameObject parent;
    public int advCapInt = 0;

    void Start ()
    {
        gm = GameObject.FindWithTag("GameManagementTag");
    }
	void Update ()
    {
        if (Input.GetKeyDown(KeyCode.V)) { missionsUiUpdating(); }

        if (isQuestAdvancer == true)
        {
            //missionAndvancement = parent.GetComponent<quest>().missionAndvancement;
        }
    }
    public void missionsUi()
    {
        //start text
        if (questName == missionNames.Gaia)
        {
            gm.GetComponent<gamemanagement>().questLogTexts[0].text = gm.GetComponent<gamemanagement>().quests[0].questName;
            gm.GetComponent<gamemanagement>().questUiSprites[0].sprite = gm.GetComponent<gamemanagement>().quests[0].qSprt;
        }
        if (questName == missionNames.Holy)
        {
            gm.GetComponent<gamemanagement>().questLogTexts[1].text = gm.GetComponent<gamemanagement>().quests[1].questName;
            gm.GetComponent<gamemanagement>().questUiSprites[1].sprite = gm.GetComponent<gamemanagement>().quests[1].qSprt;
        }
        if (questName == missionNames.PrimalWater)
        {
            gm.GetComponent<gamemanagement>().questLogTexts[2].text = gm.GetComponent<gamemanagement>().quests[2].questName;
            gm.GetComponent<gamemanagement>().questUiSprites[2].sprite = gm.GetComponent<gamemanagement>().quests[2].qSprt;
        }
        if (questName == missionNames.PrimalEarth)
        {
            gm.GetComponent<gamemanagement>().questLogTexts[3].text = gm.GetComponent<gamemanagement>().quests[3].questName;
            gm.GetComponent<gamemanagement>().questUiSprites[3].sprite = gm.GetComponent<gamemanagement>().quests[3].qSprt;
        }
        if (questName == missionNames.BlackIce)
        {
            gm.GetComponent<gamemanagement>().questLogTexts[4].text = gm.GetComponent<gamemanagement>().quests[4].questName;
            gm.GetComponent<gamemanagement>().questUiSprites[4].sprite = gm.GetComponent<gamemanagement>().quests[4].qSprt;
        }
        if (questName == missionNames.IceFire)
        {
            gm.GetComponent<gamemanagement>().questLogTexts[5].text = gm.GetComponent<gamemanagement>().quests[5].questName;
            gm.GetComponent<gamemanagement>().questUiSprites[5].sprite = gm.GetComponent<gamemanagement>().quests[5].qSprt;
        }
        if (questName == missionNames.Thunderstorm)
        {
            gm.GetComponent<gamemanagement>().questLogTexts[6].text = gm.GetComponent<gamemanagement>().quests[6].questName;
            gm.GetComponent<gamemanagement>().questUiSprites[6].sprite = gm.GetComponent<gamemanagement>().quests[6].qSprt;
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
        string questNameCheck = "";
        if (questName == missionNames.Gaia) { questNameCheck = gm.GetComponent<gamemanagement>().quests[0].questName; }
        if (questName == missionNames.Holy) { questNameCheck = questNameCheck = gm.GetComponent<gamemanagement>().quests[1].questName; }
        if (questName == missionNames.PrimalWater) { questNameCheck = questNameCheck = gm.GetComponent<gamemanagement>().quests[2].questName; }
        if (questName == missionNames.PrimalEarth) { questNameCheck = gm.GetComponent<gamemanagement>().quests[3].questName; }
        if (questName == missionNames.BlackIce) { questNameCheck = gm.GetComponent<gamemanagement>().quests[4].questName; }
        if (questName == missionNames.IceFire) { questNameCheck = gm.GetComponent<gamemanagement>().quests[5].questName; }
        if (questName == missionNames.Thunderstorm) { questNameCheck = gm.GetComponent<gamemanagement>().quests[6].questName; }

        for (int r = 0; r < gm.GetComponent<gamemanagement>().questLogTexts.Length; r++)
        {
            if (questNameCheck == gm.GetComponent<gamemanagement>().quests[r].questName)//from quests list
            {
                for(int t=0;t< parent.GetComponent<quest>().logtexts.Length; t++)
                {
                    if (parent.GetComponent<quest>().missionAdvancement < parent.GetComponent<quest>().logtexts.Length)
                    {
                        gm.GetComponent<gamemanagement>().questLogTexts[r].text = parent.GetComponent<quest>().logtexts[parent.GetComponent<quest>().missionAdvancement];
                        parent.GetComponent<quest>().missionAdvancement = parent.GetComponent<quest>().missionAdvancement + 1;
                        return;
                    }
                }
            }
        }
    }
    public void missionsOperation()
    {
        switch (questName)
        {
            case missionNames.Gaia:
                if (parent.GetComponent<quest>().missionAdvancement == 0 && advCapInt == 1)
                {
                    for (int e = 0; e < gm.GetComponent<gamemanagement>().playersBackpack.Length; e++)
                    {
                        if (gm.GetComponent<gamemanagement>().playersBackpack[e].name == "")
                        {
                            gm.GetComponent<gamemanagement>().playersBackpack[e].name = gm.GetComponent<gamemanagement>().AllItems[5].name;
                            gm.GetComponent<gamemanagement>().playersBackpack[e].description = gm.GetComponent<gamemanagement>().AllItems[5].description;
                            gm.GetComponent<gamemanagement>().playersBackpack[e].itemPropertyInt = gm.GetComponent<gamemanagement>().AllItems[5].itemPropertyInt;
                            gm.GetComponent<gamemanagement>().playersBackpack[e].sellCost = gm.GetComponent<gamemanagement>().AllItems[5].sellCost;
                            gm.GetComponent<gamemanagement>().playersBackpack[e].itemImage = gm.GetComponent<gamemanagement>().AllItems[5].itemImage;
                            missionsUiUpdating();
                            return;
                        }
                    }
                }
                else if (parent.GetComponent<quest>().missionAdvancement==1 && advCapInt == 2)
                {
                    for (int e = 0; e < gm.GetComponent<gamemanagement>().playersBackpack.Length; e++)
                    {
                        if (gm.GetComponent<gamemanagement>().playersBackpack[e].name == "Goblet")
                        {
                            gm.GetComponent<gamemanagement>().playersBackpack[e].name = gm.GetComponent<gamemanagement>().AllItems[6].name;
                            gm.GetComponent<gamemanagement>().playersBackpack[e].description = gm.GetComponent<gamemanagement>().AllItems[6].description;
                            gm.GetComponent<gamemanagement>().playersBackpack[e].itemPropertyInt = gm.GetComponent<gamemanagement>().AllItems[6].itemPropertyInt;
                            gm.GetComponent<gamemanagement>().playersBackpack[e].sellCost = gm.GetComponent<gamemanagement>().AllItems[6].sellCost;
                            gm.GetComponent<gamemanagement>().playersBackpack[e].itemImage = gm.GetComponent<gamemanagement>().AllItems[6].itemImage;
                            missionsUiUpdating();
                        }
                    }
                }
                else if (parent.GetComponent<quest>().missionAdvancement == 2 && advCapInt == 3)
                {
                    for (int et = 0; et < gm.GetComponent<gamemanagement>().playersBackpack.Length; et++)
                    {
                        if(gm.GetComponent<gamemanagement>().playersBackpack[et].name == "Goblet of water")
                        {
                            gm.GetComponent<gamemanagement>().playersBackpack[et] = null;
                            missionsUiUpdating();
                        }
                    }
                }
                break;
            case missionNames.Holy:
                if (advCapInt ==0 && parent.GetComponent<quest>().missionAdvancement == advCapInt-1)
                { missionsUiUpdating(); }
                else if(parent.GetComponent<quest>().missionAdvancement == advCapInt - 1)
                { missionsUiUpdating(); }
                    break;
            case missionNames.PrimalWater:
                if (advCapInt == 1 && parent.GetComponent<quest>().missionAdvancement == advCapInt - 1)
                { missionsUiUpdating(); }
                break;
            case missionNames.PrimalEarth:


                if (advCapInt <= 3 && parent.GetComponent<quest>().missionAdvancement == advCapInt - 1)
                {
                    for (int e = 0; e < gm.GetComponent<gamemanagement>().playersBackpack.Length; e++)
                    {
                        if (gm.GetComponent<gamemanagement>().playersBackpack[e].name == "")
                        {
                            gm.GetComponent<gamemanagement>().playersBackpack[e].name = gm.GetComponent<gamemanagement>().AllItems[7].name;
                            gm.GetComponent<gamemanagement>().playersBackpack[e].description = gm.GetComponent<gamemanagement>().AllItems[7].description;
                            gm.GetComponent<gamemanagement>().playersBackpack[e].itemPropertyInt = gm.GetComponent<gamemanagement>().AllItems[7].itemPropertyInt;
                            gm.GetComponent<gamemanagement>().playersBackpack[e].sellCost = gm.GetComponent<gamemanagement>().AllItems[7].sellCost;
                            gm.GetComponent<gamemanagement>().playersBackpack[e].itemImage = gm.GetComponent<gamemanagement>().AllItems[7].itemImage;
                            missionsUiUpdating();
                            return;
                        }
                    }
                }
                else if (advCapInt == 4 && parent.GetComponent<quest>().missionAdvancement == advCapInt - 1)
                {
                    for (int e = 0; e < gm.GetComponent<gamemanagement>().playersBackpack.Length; e++)
                    {
                        if (gm.GetComponent<gamemanagement>().playersBackpack[e].name == gm.GetComponent<gamemanagement>().AllItems[7].name)
                        {
                            gm.GetComponent<gamemanagement>().playersBackpack[e].name = "";
                            gm.GetComponent<gamemanagement>().playersBackpack[e].description = "";
                            gm.GetComponent<gamemanagement>().playersBackpack[e].itemPropertyInt = 0;
                            gm.GetComponent<gamemanagement>().playersBackpack[e].sellCost = 0;
                            gm.GetComponent<gamemanagement>().playersBackpack[e].itemImage = null;

                         /*
                             set the altar visible or do an anim or something like thats, something visual
                         */
                        }
                    }
                    missionsUiUpdating();
                }
                break;
            case missionNames.BlackIce:
                if (advCapInt == 1 && parent.GetComponent<quest>().missionAdvancement == advCapInt - 1)
                { missionsUiUpdating(); }
                break;
            case missionNames.IceFire:
                if (parent.GetComponent<quest>().missionAdvancement == 0 && advCapInt == 1)
                {
                    for (int e = 0; e < gm.GetComponent<gamemanagement>().playersBackpack.Length; e++)
                    {
                        if (gm.GetComponent<gamemanagement>().playersBackpack[e].name == "")
                        {
                            gm.GetComponent<gamemanagement>().playersBackpack[e].name = gm.GetComponent<gamemanagement>().AllItems[9].name;
                            gm.GetComponent<gamemanagement>().playersBackpack[e].description = gm.GetComponent<gamemanagement>().AllItems[9].description;
                            gm.GetComponent<gamemanagement>().playersBackpack[e].itemPropertyInt = gm.GetComponent<gamemanagement>().AllItems[9].itemPropertyInt;
                            gm.GetComponent<gamemanagement>().playersBackpack[e].sellCost = gm.GetComponent<gamemanagement>().AllItems[9].sellCost;
                            gm.GetComponent<gamemanagement>().playersBackpack[e].itemImage = gm.GetComponent<gamemanagement>().AllItems[9].itemImage;
                            missionsUiUpdating();
                            return;
                        }
                    }
                }
                if (parent.GetComponent<quest>().missionAdvancement == 1 && advCapInt == 2)
                {
                    for (int e = 0; e < gm.GetComponent<gamemanagement>().playersBackpack.Length; e++)
                    {
                        if (gm.GetComponent<gamemanagement>().playersBackpack[e].name == "")
                        {
                            gm.GetComponent<gamemanagement>().playersBackpack[e].name = gm.GetComponent<gamemanagement>().AllItems[8].name;
                            gm.GetComponent<gamemanagement>().playersBackpack[e].description = gm.GetComponent<gamemanagement>().AllItems[8].description;
                            gm.GetComponent<gamemanagement>().playersBackpack[e].itemPropertyInt = gm.GetComponent<gamemanagement>().AllItems[8].itemPropertyInt;
                            gm.GetComponent<gamemanagement>().playersBackpack[e].sellCost = gm.GetComponent<gamemanagement>().AllItems[8].sellCost;
                            gm.GetComponent<gamemanagement>().playersBackpack[e].itemImage = gm.GetComponent<gamemanagement>().AllItems[8].itemImage;
                            missionsUiUpdating();
                            return;
                        }
                    }
                }

                if (parent.GetComponent<quest>().missionAdvancement == 2 && advCapInt == 3)
                {
                    for (int e = 0; e < gm.GetComponent<gamemanagement>().playersBackpack.Length; e++)
                    {
                        if (gm.GetComponent<gamemanagement>().playersBackpack[e].name == gm.GetComponent<gamemanagement>().AllItems[8].name)
                        {
                            gm.GetComponent<gamemanagement>().playersBackpack[e].name = "";
                            gm.GetComponent<gamemanagement>().playersBackpack[e].description = "";
                            gm.GetComponent<gamemanagement>().playersBackpack[e].itemPropertyInt = 0;
                            gm.GetComponent<gamemanagement>().playersBackpack[e].sellCost = 0;
                            gm.GetComponent<gamemanagement>().playersBackpack[e].itemImage = null;
                        }
                        if (gm.GetComponent<gamemanagement>().playersBackpack[e].name == gm.GetComponent<gamemanagement>().AllItems[9].name)
                        {
                            gm.GetComponent<gamemanagement>().playersBackpack[e].name = "";
                            gm.GetComponent<gamemanagement>().playersBackpack[e].description = "";
                            gm.GetComponent<gamemanagement>().playersBackpack[e].itemPropertyInt = 0;
                            gm.GetComponent<gamemanagement>().playersBackpack[e].sellCost = 0;
                            gm.GetComponent<gamemanagement>().playersBackpack[e].itemImage = null;
                        }
                    }
                    missionsUiUpdating();
                }

                break;
            case missionNames.Thunderstorm:
                if (advCapInt == 1 && parent.GetComponent<quest>().missionAdvancement == advCapInt - 1)
                { missionsUiUpdating(); }
                break;
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            if (isQuestAdvancer == false)
            {
                if (startedQuest == false) { missionsUi(); }
                startedQuest = true;
                missionsOperation();
            }
            else if (isQuestAdvancer == true && startedQuest==false) { missionsOperation(); startedQuest = true; }
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