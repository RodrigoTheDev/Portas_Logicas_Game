using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Saida_OU : MonoBehaviour
{
    public Sprite saida0, saida1;
    public SpriteRenderer spriteRenderer;
    public button bt;
    public button_02 bt2;
    void Start()
    {
        
        spriteRenderer = this.GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        //encontrando  cada botão
        bt = FindObjectOfType<button>();
        bt2 = FindObjectOfType<button_02>();

        if ((bt.saida01) +(bt2.saida02) < 1)
        {
            spriteRenderer.sprite = saida0;
        }
        else if ((bt.saida01) + (bt2.saida02) >= 1)
        {
            spriteRenderer.sprite = saida1;
        }

    }
}
