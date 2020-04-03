using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMasterScript : MonoBehaviour
{

    // Start is called before the first frame update
    Dictionary<ActionBlock.Action, GameObject> EmplacementAction;
    private ConditionSucces condition;
    public UnityEngine.UI.Text TextField;
    private void Awake()
    {
        EmplacementAction = new Dictionary<ActionBlock.Action, GameObject>();
        condition = GetComponent<ConditionSucces>();
        
    }   

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void WriteInObjectif(string s)
    {
        TextField.text += s + "\n";
    }

    public void AddAction(ActionBlock.Action theAction,GameObject empla)
    {
        EmplacementAction.Add(theAction,empla);
        if (Random.Range(0,11) < 6)
        {
            condition.Add(theAction);
            WriteInObjectif(theAction.ToString());
            
        }
    }

    public GameObject getAction(ActionBlock.Action act)
    {
        return EmplacementAction[act];
    }

}
