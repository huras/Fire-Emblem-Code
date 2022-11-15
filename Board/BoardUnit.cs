
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoardUnit : BoardObject
{
    private bool alive; // field
    public bool Alive { get { return alive; } set { alive = value; } }

    public string label;
    public float hp;

    public BoardTeam team;
    public BoardTile units;
}
