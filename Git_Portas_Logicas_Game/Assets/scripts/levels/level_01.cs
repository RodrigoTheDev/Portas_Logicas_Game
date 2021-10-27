using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*
lvl_01:
A|B|C|S
0 0 0 0
0 0 1 0
0 1 0 0
0 1 1 0
1 0 0 0
1 0 1 0
1 1 0 0
1 1 1 1
*/

public class level_01 : MonoBehaviour
{
    public Sprite saida0, saida1;
    public SpriteRenderer spriteRenderer;
    public button bt;
    public button_02 bt2;
    public button_03 bt3;
    public int lState = 0;
    void Start()
    {
        //Definindo os botões
        bt = FindObjectOfType<button>();
        bt2 = FindObjectOfType<button_02>();
        bt3 = FindObjectOfType<button_03>();

        //Definindo o sprite renderer (coloquei a ação e a imagem no mesmo script)
        spriteRenderer = this.GetComponent<SpriteRenderer>();
    }


    void Update()
    {

        //para 0
        if ((bt.saida01) * (bt2.saida02) * (bt3.saida03)< 1)
        {
            spriteRenderer.sprite = saida0;
            lState = 0;
        }
        //para 1
        else if ((bt.saida01) * (bt2.saida02) * (bt3.saida03) >= 1)
        {
            spriteRenderer.sprite = saida1;
            lState = 1;
        }
    }
}
