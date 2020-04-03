using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonGo : MonoBehaviour
{
    // Start is called before the first frame update
    CodeGestionnaireScript CGS;
    void Start()
    {
        CGS = FindObjectOfType<CodeGestionnaireScript>();
        GetComponent<UnityEngine.UI.Button>().onClick.AddListener(ClickGO);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ClickGO()
    {
        CGS.ClickOnGo();
    }
}
