using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    // Start is called before the first frame update
    public int i;
    public List<GameObject> cible;
    private float speed;
    int indice ;
    ConditionSucces conditionS;
    void Start()
    {
        cible = new List<GameObject>();
        speed = 1;
        indice = 0;
        conditionS = FindObjectOfType<ConditionSucces>();
    }

    // Update is called once per frame
    void Update()
    {
        float step = speed * Time.deltaTime; // calculate distance to move
        if(cible.Count != 0)
        {
            if(cible.Count > indice)
            {
                transform.position = Vector2.MoveTowards(transform.position, cible[indice].transform.position, step);
                // Check if the position of the cube and sphere are approximately equal.
                if (Vector2.Distance(transform.position, cible[indice].transform.position) < 0.001f)
                {

                    conditionS.setTrue(cible[indice]);
                    indice += 1;

                }
            }
        }
        transform.position = new Vector3(transform.position.x, transform.position.y, 1);
    }

    public void SetCible(GameObject t)
    {
        cible.Add(t);
        speed = (Vector2.Distance(transform.position, t.transform.position) / 2);
    }




}
