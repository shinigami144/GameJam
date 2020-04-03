using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    // Start is called before the first frame update
 [SerializeField] public   List<Button> MesBouton = new List<Button>();
    public UnityEngine.UI.Text TextField;
    void Start()
    {
       TextField =  GetComponentInChildren<UnityEngine.UI.Text>();
       TextField.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void WriteInText(string s)
    {
        TextField.text += s;
    }
}
