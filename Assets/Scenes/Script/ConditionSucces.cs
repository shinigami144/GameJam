using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ConditionSucces : MonoBehaviour
{
    // Start is called before the first frame update
    public Dictionary<ActionBlock.Action, bool> Objectif;
    bool Manger;
    private void Awake()
    {
        Objectif = new Dictionary<ActionBlock.Action, bool>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Etat())
        {
            // fin game
            Debug.Log("Win");
            SceneManager.LoadScene("FinalGameScene");
        }
    }


    public bool Etat()
    {
        bool endGame = true;
        foreach( var alpha  in Objectif.Keys)
        {
            Debug.Log(alpha + " etat " + Objectif[alpha]);
            if(Objectif[alpha] == false)
            {
                endGame = false;
            }
        }
        return endGame;
    }


    public void Add(ActionBlock.Action act)
    {
        Objectif.Add(act, false);
    }

    public void setTrue(GameObject g)
    {
        if (Objectif.ContainsKey(g.GetComponent<ActionScriptObject>().getAction())){
            Objectif[g.GetComponent<ActionScriptObject>().getAction()] = true;
        }
    }
}
