﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager ins;
    public Node currentNode;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        ins = this;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}