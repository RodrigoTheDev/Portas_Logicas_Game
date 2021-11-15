using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class door : MonoBehaviour
{
    public control ctrl; //variável que puxa valores do script control
    public SpriteRenderer sr;

    public int lvlunlock = 2; //lvl é a variável que armazena o valor requerido para que essa porta se abra
    public string lvlname; //o nome da cena que essa porta deve levar


    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        ctrl = FindObjectOfType<control>();

        sr.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        // se a currentLevel(variável do script control) for igual a lvlunlock, a porta surge
        if(ctrl.currentLevel == lvlunlock)
        {
            sr.enabled = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(lvlname);
    } //ao colidir, essa porta nos leva à fase que tem o nome inserido na string lvlname
}
