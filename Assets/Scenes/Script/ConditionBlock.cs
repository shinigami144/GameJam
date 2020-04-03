using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConditionBlock : InterfaceBlock
{
    // Start is called before the first frame update
    public enum Condition
    {
        IF,WHILE,ELSE
    }

    private OperatorBlock operateur;
    private DataBlockScript data;
    private CodeGestionnaireScript SousGestionaire;

    public ConditionBlock(Condition myConditionType)
    {
        switch (myConditionType)
        {
            case Condition.IF:
                SousGestionaire = new CodeGestionnaireScript();
                break;
            case Condition.WHILE:
                SousGestionaire = new CodeGestionnaireScript();
                break;
            case Condition.ELSE:
                SousGestionaire = new CodeGestionnaireScript();
                break;
        }
    }

    public string Activate()
    {
        throw new System.NotImplementedException();
    }
}
