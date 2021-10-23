using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//PORTA OR
// A | B | S 
// 0 | 0 | 0
// 0 | 1 | 1
// 1 | 0 | 1
// 1 | 1 | 0

public class porta_XOR : MonoBehaviour
{
    public Sprite saida0, saida1;
    public SpriteRenderer spriteRenderer;
    public button bt;
    public button_02 bt2;
    public button_03 bt3;
    public button_04 bt4;

    void Start()
    {

        spriteRenderer = this.GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        //Definindo os botões
        bt = FindObjectOfType<button>();
        bt2 = FindObjectOfType<button_02>();
        bt3 = FindObjectOfType<button_03>();
        bt4 = FindObjectOfType<button_04>();

        if ((bt.saida01) == (bt2.saida02))
        {
            spriteRenderer.sprite = saida0;
        }
        else if ((bt.saida01) != (bt2.saida02))
        {
            spriteRenderer.sprite = saida1;
        }
    }
}
