using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestEcrireText : MonoBehaviour
{
    public int ChoixText;
    [SerializeField] Text test;
    public static TestEcrireText lecture;
    public GameObject testinput;
    int nb;
    int X_Vertical = 0;
    int X_Horizontal = 0;
    bool activer = false;
    bool RetourLine = false;
    bool Go = false;
    int PremierLine = 1;
    public string Numero;

    // Start is called before the first frame update
    private void Start()
    {
        lecture = this;
        test.text = " ";
    }
    
    // Update is called once per frame
    void Update()
    {
        if(activer == true)
        {
            Changement();
            activer = false;
        }
    }

    public void Changement()
    {
        Numero = testinput.GetComponent<Text>().text;
        ChoixText = changerText(nb);
        if (ChoixText == 1)
        {
           // print("1");
            if (PremierLine != 1)
            { 
            test.text += "                                                                                                                                                          ";
            }
            test.text += "IF";
            RetourLine = true;
            PremierLine++;
        }
        if (ChoixText == 2 && RetourLine == true)
        {
           // print("2");
            test.text += "AND";
            X_Vertical++;
            X_Horizontal = 2;
        }
        if (ChoixText == 3 && RetourLine == true)
        {
            //print("3");
            test.text += "OR";
            X_Horizontal++;
        }
        if (ChoixText == 4 && RetourLine == true)
        {
            //print("4");
            Go = true;
            Deplacement.marcher.deplacer(X_Horizontal,X_Vertical,Go);
            Go = false;
        }
        if (ChoixText == 5 && RetourLine == true)
        {
            print("Ecrit");
            test.text += Numero;
        }
        if (ChoixText == 6 && RetourLine == true)
        {
            //print("3");
            test.text += "ELSE";
        }
        if (ChoixText == 7 && RetourLine == true)
        {
            //print("3");
            test.text += "=";
        }
        if (ChoixText == 8 && RetourLine == true)
        {
            //print("3");
            test.text += "!=";
        }
        if (ChoixText == 9 && RetourLine == true)
        {
            //print("3");
            test.text += "WHILE";
        }
        if (ChoixText == 10 && RetourLine == true)
        {
            //print("3");
            test.text += "Reveil";
        }
        if (ChoixText == 11 && RetourLine == true)
        {
            //print("3");
            test.text += "Devoir";
        }
        if (ChoixText == 12 && RetourLine == true)
        {
            //print("3");
            test.text += "Jouer";

            //X_Vertical = -2;
            //X_Horizontal = 3;
            X_Vertical++;
            X_Horizontal++;
        }
        if (ChoixText == 13 && RetourLine == true)
        {
            //print("3");
            test.text += "Nager";
        }
        if (ChoixText == 14 && RetourLine == true)
        {
            //print("3");
            test.text += "Regarder la TV";
        }
        if (ChoixText == 15 && RetourLine == true)
        {
            //print("3");
            test.text += "Faire à manger";
        }
        if (ChoixText == 16 && RetourLine == true)
        {
            //print("3");
            test.text += "Manger";
        }
        if (ChoixText == 17 && RetourLine == true)
        {
            //print("3");
            test.text += "Faire la vaiselle";
        }
        if (ChoixText == 18 && RetourLine == true)
        {
            //print("3");
            test.text += "Prendre un bain";
        }
        if (ChoixText == 19 && RetourLine == true)
        {
            //print("3");
            test.text += "Se laver les dents";
        }
        if (ChoixText == 20 && RetourLine == true)
        {
            //print("3");
            test.text += "Aller dormir";
        }
        if (ChoixText == 21 && RetourLine == true)
        {
            //print("3");
            test.text += "Tailler les arbres";
        }
        if (ChoixText == 22 && RetourLine == true)
        {
            //print("3");
            test.text += "Arroser les plantes";
        }
        if (ChoixText == 23 && RetourLine == true)
        {
            //print("3");
            test.text += "Soleil";
        }
        if (ChoixText == 24 && RetourLine == true)
        {
            //print("3");
            test.text += "Pluie";
        }
        if (ChoixText == 25 && RetourLine == true)
        {
            //print("3");
            test.text += "Nuage";
        }
        if (ChoixText == 26 && RetourLine == true)
        {
            //print("3");
            test.text += "DO";
        }
        if (ChoixText == 27 && RetourLine == true)
        {
            //print("3");
            test.text += "IFEND";
        }

    }
        
   


    public int changerText (int amount)
    {
        //print(amount);
        nb = amount;
       // print("Changer");
        activer = true;
        //print(nb);
        return nb;
    }

}
