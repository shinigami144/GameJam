using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperatorBlock : InterfaceBlock
{
    // Start is called before the first frame update
    public enum Operator
    {
        AND,OR,EGAL,DIFFERENT,
    }

    private OperatorBlock[] operatorL;
    private DataBlockScript[] datablockL;
    private Operator myOperator;
    private bool etat;

    private void ChangeEtat(bool newEtat)
    {
        etat = newEtat;
    }

    public OperatorBlock(Operator theOperator,DataBlockScript dataBlock)
    {
        etat = false;
        myOperator = theOperator;
        switch (theOperator)
        {
            case Operator.EGAL:
                datablockL = new DataBlockScript[2];
                datablockL[0] = dataBlock;
                break;
            case Operator.DIFFERENT:
                datablockL = new DataBlockScript[2];
                datablockL[0] = dataBlock;
                break;
        }
    }
    public OperatorBlock(Operator theOperator, OperatorBlock operatorBlock)
    {
        etat = false;
        myOperator = theOperator;
        switch (theOperator)
        {
            case Operator.AND:
                operatorL = new OperatorBlock[2];
                operatorL[0] = operatorBlock;
                break;
            case Operator.OR:
                operatorL = new OperatorBlock[2];
                operatorL[0] = operatorBlock;
                break;
        }
    }

    public void AddData(DataBlockScript data)
    {
        datablockL[1] = data;
        ChangeEtat(true);
    }

    public void AddOperator(OperatorBlock op)
    {
        operatorL[1] = op;
        ChangeEtat(true);
    }

    public string Activate()
    {
        throw new System.NotImplementedException();
    }

    public bool isOk()
    {
        return etat;
    }
    public Operator GetOperator()
    {
        return myOperator;
    }
}
