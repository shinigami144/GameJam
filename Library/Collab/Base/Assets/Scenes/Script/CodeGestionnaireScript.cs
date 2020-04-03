using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CodeGestionnaireScript : MonoBehaviour
{
    public List<InterfaceBlock> actionList;
    //GameMasterScript GM;
    PlayerScript PlScript;
    DataBlockScript metaDataBlockScript;
    ActionBlock metaActionBlockScript;
    public DataBlockScript dataForCondition;
    public List<OperatorBlock> operatorBlockForCondition;
    private bool conditionActive;
    private ConditionBlock conditionBlock;
    private int LastIndex;
    private bool inCondition;

    private UIManager uI;


    // Start is called before the first frame update
    void Start()
    {
        actionList = new List<InterfaceBlock>();
        PlScript = FindObjectOfType<PlayerScript>();
        LastIndex = 0;
        conditionActive = false;
        inCondition = false;
        uI = FindObjectOfType<UIManager>();
    }

    // Update is called once per frame    
    void Update()
    {

    }

    public void ClickDoButton()
    {
        // Stop et verifie la condition

        //Debug.Log("DO");
        if (operatorBlockForCondition.Count == 0)
        {
            if (!(dataForCondition is null))
            {
                Debug.Log("OK 1");
            }
        }
        else
        {
            for (int i = 0; i < operatorBlockForCondition.Count; i++)
            {
                //Debug.Log(operatorBlockForCondition.Count + " " + i);
                if (!operatorBlockForCondition[i].isOk())
                {
                    Debug.Log("NOT OK 2");
                }
                else
                {
                    Debug.Log("OK 2");
                }
            }
        }
        //Debug.Log("End DO");
        conditionActive = false;
        inCondition = true;
    }

    public void ClickIFButton()
    {
        conditionActive = true;
        conditionBlock = new ConditionBlock(ConditionBlock.Condition.IF);
        operatorBlockForCondition = new List<OperatorBlock>();
        dataForCondition = null;
        LastIndex = 0;
        uI.WriteInText("IF ");
    }

    public void ClickDataButton(int DataValue)
    {
        if (conditionActive == true)
        {
            dataForCondition = new DataBlockScript(DataValue);
            if (LastIndex != 0)
            {
                if (!operatorBlockForCondition[LastIndex - 1].isOk())
                {
                    if (operatorBlockForCondition[LastIndex - 1].GetOperator() == OperatorBlock.Operator.EGAL ||
                        operatorBlockForCondition[LastIndex - 1].GetOperator() == OperatorBlock.Operator.DIFFERENT) {
                        operatorBlockForCondition[LastIndex - 1].AddData(dataForCondition);
                    }

                }
            }
        }
    }

    public void ClickOperator(OperatorBlock.Operator op)
    {
        if(op == OperatorBlock.Operator.AND || op == OperatorBlock.Operator.OR)
        {
            ClickOperatorType1(op);
        }
        else if(op == OperatorBlock.Operator.EGAL || op ==  OperatorBlock.Operator.DIFFERENT)
        {
            ClickOperatorType2(op);
        }
    }
    
    public void ClickEndIFButton()
    {
        inCondition = false;
    }

    public void ClickOperatorType2(OperatorBlock.Operator opt)
    {
        if(conditionActive == true)
        {
            OperatorBlock op = new OperatorBlock(opt,dataForCondition);
            if (LastIndex != 0)
            { 
                if (!operatorBlockForCondition[LastIndex - 1].isOk())
                {
                    if (operatorBlockForCondition[LastIndex - 1].GetOperator() == OperatorBlock.Operator.AND ||
                        operatorBlockForCondition[LastIndex - 1].GetOperator() == OperatorBlock.Operator.OR)
                    {
                        
                        operatorBlockForCondition[LastIndex - 1].AddOperator(op);
                    }

                }
            }
            operatorBlockForCondition.Add(op);
            LastIndex++;
            uI.WriteInText(op.GetOperator().ToString());
        }
    } 

    public void ClickOperatorType1(OperatorBlock.Operator opt)
    {
        if (conditionActive == true)
        {
            OperatorBlock op = new OperatorBlock(opt, operatorBlockForCondition[LastIndex-1]);
            operatorBlockForCondition.Add(op);
            LastIndex++;
            uI.WriteInText(op.GetOperator().ToString());
        }
    }

    public void ClickActionButton(ActionBlock.Action theTypeOfAction)
    {
        actionList.Add(new ActionBlock(theTypeOfAction));
    }

    public void ClickConditionButton(ConditionBlock.Condition conditionClicked)
    {
        switch (conditionClicked)
        {
            case ConditionBlock.Condition.IF:
                ClickIFButton();
                break;
            case ConditionBlock.Condition.ELSE:
                // Click Button ELse
                break;
            case ConditionBlock.Condition.WHILE:
                // ClickWhile
                break;
        }
    }
    
    public void ClickOnGo()
    {
        for(int i = 0;i< actionList.Count; i++)
        {
            actionList[i].Activate();
        }
    }








}
