﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BonusPointsCheck : MonoBehaviour
{
    Collider worldCollider;


    [SerializeField]
    private GameController controller;

    [SerializeField]
    private GameObject enemy;

    private Collider enemyCollider;



    bool hasBeenTriggered;

    // Start is called before the first frame update
    void Start()
    {
        worldCollider = GetComponent<Collider>();
        hasBeenTriggered = false;
        enemyCollider = enemy.GetComponent<Collider>();
        //aStar = GetComponent<AStar>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.tag);

        if (!hasBeenTriggered && other.CompareTag("Player"))
        {
            controller.AddScore(50);
            hasBeenTriggered = true;
            Debug.Log("Player1 beat the bean!");

        }
        if (!hasBeenTriggered && other.CompareTag("enemy"))
        {
            hasBeenTriggered = true;
            Debug.Log("The Bean beat player1");
        }
        //hasBeenTriggered = true;


    }
}