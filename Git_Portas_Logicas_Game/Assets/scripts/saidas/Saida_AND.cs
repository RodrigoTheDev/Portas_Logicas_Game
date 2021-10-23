using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script que será usado nos displays de saída

public class Saida_AND : MonoBehaviour
{
    public Sprite saida0, saida1;
    public SpriteRenderer spriteRenderer;
    public porta_AND lAnd;

    // Start is called before the first frame update
    void Start()
    {
        lAnd = FindObjectOfType<porta_AND>();
        spriteRenderer = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if(lAnd.lState == 0)
        {
            spriteRenderer.sprite = saida0;
        }
        else if(lAnd.lState == 1)
        {
            spriteRenderer.sprite = saida1;
        }
    }
}
