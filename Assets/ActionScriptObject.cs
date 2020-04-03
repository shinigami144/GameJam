using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionScriptObject : MonoBehaviour
{
    // Start is called before the first frame update
    GameMasterScript gm;
    public ActionBlock.Action myActionID;
    void Start()
    {
        gm = FindObjectOfType<GameMasterScript>();
        gm.AddAction(myActionID, gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public ActionBlock.Action getAction()
    {
        return myActionID;
    }
}
