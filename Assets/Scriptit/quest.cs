using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quest : MonoBehaviour
{
    [Header("TO GET TO NEXT TEXT, CALL  missionsUiUpdating();  ONCE")]
    public GameObject gm;
    public bool startedQuest=false;
    public missionNames questName;

    public int missionAndvancement=0;
    [TextArea(1, 15)]
    public string[] logtexts;
    [Header("Quest Advancer")]
    public bool isQuestAdvancer = false;
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
                for(int t=0;t< logtexts.Length; t++)
                {
                    if (missionAndvancement < logtexts.Length)
                    {
                        gm.GetComponent<gamemanagement>().questLogTexts[r].text = logtexts[missionAndvancement];
                        missionAndvancement = missionAndvancement + 1;
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
                if(missionAndvancement==1)
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
                if (missionAndvancement == 2)
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

                break;
            case missionNames.PrimalWater:

                break;
            case missionNames.PrimalEarth:

                break;
            case missionNames.BlackIce:

                break;
            case missionNames.IceFire:

                break;
            case missionNames.Thunderstorm:

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