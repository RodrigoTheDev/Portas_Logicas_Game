using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class door : MonoBehaviour
{
    public control ctrl;
    public SpriteRenderer sr;

    public int lvlunlock = 2;
    public string lvlname;


    private void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        ctrl = FindObjectOfType<control>();

        sr.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(ctrl.currentLevel == lvlunlock)
        {
            sr.enabled = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        SceneManager.LoadScene(lvlname);
    }
}
