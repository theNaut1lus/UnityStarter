using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ConsolePrint : MonoBehaviour
{
    [SerializeField]
    private GameObject gameObj;

    private int i;
    // Start is called before the first frame update
    void Start()
    {
        i = 3;
        gameObj = this.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObj.name + ":"+ ++i);
    }
}
