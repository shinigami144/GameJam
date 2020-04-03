using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DataBlockScript : InterfaceBlock
{
    private Vector2 dataVectorType;
    private int dataIntType;
    // Start is called before the first frame update
    public DataBlockScript(Vector2 dataSet)
    {
        dataVectorType = dataSet;
    }

    public DataBlockScript(int dataSet)
    {
        dataIntType = dataSet;
    }

    public string Activate()
    {
        return dataIntType.ToString();
    }

    public int getDataInt()
    {
        return dataIntType ;
    }

    public Vector2 GetVector2()
    {
        return dataVectorType;
    }

}
