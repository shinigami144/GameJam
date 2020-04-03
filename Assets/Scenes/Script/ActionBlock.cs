using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionBlock : InterfaceBlock
{
    public enum Action
    {
        Reveiller,Devoir,Jouer,Nager,RegarderTv,FaireAManger,Manger,FaireVaisselle,PrendreBain,SeLaverDent,Dormir,TaillerArbre,AroserPalnte,
    }
    Action myAction;
    DataBlockScript[] dataBlockLinked;
    int indexBlock;
    bool usableBlock;
    GameObject objectOfAction;
    PlayerScript player;
    // Start is called before the first frame update
    public ActionBlock(Action typeAction)
    {
        myAction = typeAction;
        objectOfAction = GameObject.FindObjectOfType<GameMasterScript>().getAction(typeAction);
        player = GameObject.FindObjectOfType<PlayerScript>();
    }

    private void ActionBlockMoveInit()
    {
        dataBlockLinked = new DataBlockScript[1];
        indexBlock  = 0;
        usableBlock = false;
    }


    public void AddDataBlock(DataBlockScript theBlockToAdd)
    {
        dataBlockLinked[indexBlock] = theBlockToAdd;
        indexBlock += 1;
        if(indexBlock == dataBlockLinked.Length)
        {
            usableBlock = true;
        }
    }

    public DataBlockScript[] getDataBlock()
    {
        return dataBlockLinked;
    }
    public bool IsValid()
    {
        return usableBlock;
    }

    public string Activate()
    {
        player.SetCible(objectOfAction);
        return "LOL";
    }
    public ActionBlock.Action getAction()
    {
        return myAction;
    }
}
