using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//script que ser� usado nos displays de sa�da

public class Saida_OR : MonoBehaviour
{
    public Sprite saida0, saida1;
    public SpriteRenderer spriteRenderer;
    public porta_OR lOr;

    // Start is called before the first frame update
    void Start()
    {
        
        lOr = FindObjectOfType<porta_OR>();
        spriteRenderer = this.GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {


        if (lOr.lState == 0)
        {
            spriteRenderer.sprite = saida0;
        }
        else if (lOr.lState == 1)
        {
            spriteRenderer.sprite = saida1;
        }
    }
}
