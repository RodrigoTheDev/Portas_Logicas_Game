using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
*/

public class level_04 : MonoBehaviour
{
    public control ctrl;
    public Sprite saida0, saida1;
    public SpriteRenderer spriteRenderer;
    public button bt;
    public button_02 bt2;
    public button_03 bt3;
    public button_04 bt4;

    public int porta1 = 0;
    public int porta2 = 0;

    public int lState = 0;
    void Start()
    {
        ctrl = FindObjectOfType<control>();
        //Definindo os bot�es
        bt = FindObjectOfType<button>();
        bt2 = FindObjectOfType<button_02>();
        bt3 = FindObjectOfType<button_03>();
        bt4 = FindObjectOfType<button_04>();

        //Definindo o sprite renderer (coloquei a a��o e a imagem no mesmo script)
        spriteRenderer = this.GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        if (bt.saida01 == bt2.saida02) porta1 = 0;
        if (bt.saida01 != bt2.saida02) porta1 = 1;

        porta2 = bt3.saida03 * bt4.saida04;

        //para 0
        if (porta1 * porta2 == 0)
        {
            spriteRenderer.sprite = saida0;
            lState = 0;
        }

        //para 1
        else if (porta1 * porta2 >= 1)
        {
            spriteRenderer.sprite = saida1;
            lState = 1;
        }

        if (porta1 * porta2 == 1)
        {
            ctrl.currentLevel = 6;
            Destroy(bt.GetComponent<BoxCollider2D>());
            Destroy(bt4.GetComponent<BoxCollider2D>());
        }
    }
}