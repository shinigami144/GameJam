using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCondition : MonoBehaviour
{
    // Start is called before the first frame update
    CodeGestionnaireScript CGS;
    public ConditionBlock.Condition myCondition;
    void Start()
    {
        CGS = FindObjectOfType<CodeGestionnaireScript>();
        GetComponent<UnityEngine.UI.Button>().onClick.AddListener(ClickOnMe);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickOnMe()
    {
        CGS.ClickConditionButton(myCondition);
    }
}
