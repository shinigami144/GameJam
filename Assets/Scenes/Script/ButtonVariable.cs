using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonVariable : MonoBehaviour
{
    // Start is called before the first frame update
    CodeGestionnaireScript CGS;
    public int data;
    private UnityEngine.UI.InputField ZoneNombre;


    void Start()
    {
        CGS = FindObjectOfType<CodeGestionnaireScript>();
        GetComponent<UnityEngine.UI.Button>().onClick.AddListener(ClickOnMe);
        ZoneNombre = FindObjectOfType<UnityEngine.UI.InputField>();
        //ZoneNombre.onValueChanged.AddListener(getInputNumber);
    }

    // Update is called once per frame
    void Update()
    {
     //   data = ZoneNombre.
    }

    public string getInputNumber()
    {
        return "1";
    }

    public void ClickOnMe()
    {
        CGS.ClickDataButton(data);
    }
}
