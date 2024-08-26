using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using UnityEngine;
using Random = UnityEngine.Random;

public class PrintAndHide : MonoBehaviour
{
    [SerializeField]
    private GameObject gameObj;

    public Renderer rend;

    private int i;
    private int j;
    
    // Start is called before the first frame update
    void Start()
    {
        i = 3;
        gameObj = this.gameObject;
        if(gameObj.CompareTag("Blue") && i == Random.Range(150,251))
        {
            rend.enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObj.name + ":"+ ++i);
        if(gameObj.CompareTag("Red") && i == 100)
        {
            gameObj.SetActive(false);
        }
        if(gameObj.CompareTag("Blue") && i is >= 150 and <= 250)
        {
            rend.enabled = false;
        }
    }
}
