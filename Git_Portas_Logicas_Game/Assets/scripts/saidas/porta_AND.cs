using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//PORTA AND
// A | B | S 
// 0 | 0 | 0
// 0 | 1 | 0
// 1 | 0 | 0
// 1 | 1 | 1

public class porta_AND : MonoBehaviour
{
    
    public button bt;
    public button_02 bt2;
    public button_03 bt3;
    public button_04 bt4;
    public int lState = 0;
    void Start()
    {
    }


    void Update()
    {
        //Definindo os bot�es
        bt = FindObjectOfType<button>();
        bt2 = FindObjectOfType<button_02>();
        bt3 = FindObjectOfType<button_03>();
        bt4 = FindObjectOfType<button_04>();

        if ((bt.saida01) * (bt2.saida02) < 1)
        {
            lState = 0;
        }
        else if ((bt.saida01) * (bt2.saida02) >= 1)
        {
            lState = 1;
        }

    }
}