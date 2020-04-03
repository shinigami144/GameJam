using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{
    // Start is called before the first frame update
    
    void Start()
    {
        GetComponent<UnityEngine.UI.Button>().onClick.AddListener(returnMenu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void returnMenu()
    {
        SceneManager.LoadScene(0);
    }
}
