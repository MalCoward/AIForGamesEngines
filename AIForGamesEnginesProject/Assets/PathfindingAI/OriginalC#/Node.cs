﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Node
{
    //G and H cost of each node used to calculate the f cost.
    public int g;
    public int h;


    public int nodePosOnGridX;
    public int nodePosOnGridY;
    
    public bool notObstructed;
    public Vector3 nodeWorldPosition;
   

    public Node parentNode;
    


    public Node(bool _notObstructed, Vector3 _nodeWorldPos, int _posOnGridX, int _posOnGridY)
    {
        notObstructed = _notObstructed;
        nodeWorldPosition = _nodeWorldPos;
        nodePosOnGridX = _posOnGridX;
        nodePosOnGridY = _posOnGridY;
    }

    //obtaining the value of the f cost.
    public int fcost
    {
        get
        {
            return g + h;
        }
        
    }
}
