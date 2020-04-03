using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Deplacement : MonoBehaviour
{

    public static Deplacement marcher;
    float vitex = 0;
    float vitey = 0;
    int PosX = 0;
    int PosY = 0;


    Rigidbody2D CorpsPerso;
    // Start is called before the first frame update
    private void Start()
    {
        marcher = this;
        CorpsPerso = this.GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (PosY <= transform.position.y)
        {

            vitey = 0;
            CorpsPerso.velocity = new Vector2(vitex, vitey);

            print("arriver");
        }
        if (PosX <= transform.position.x)
        {

            vitex = 0;
            CorpsPerso.velocity = new Vector2(vitex, vitey);

            print("arriver");
        }

    }


   public void deplacer(int Hauteur, int Vertical,bool Parti)
    {
        PosY = Hauteur;
        PosX = Vertical;
        if (Parti == true)
        {
            vitey++;
            vitex++;
            CorpsPerso.velocity = new Vector2(vitex, vitey);
            //print(transform.position.x);
            //print(Hauteur);
         
        }
        
       
       

    }
}
