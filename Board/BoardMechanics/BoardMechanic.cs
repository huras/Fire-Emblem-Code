
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class BoardMechanic : MonoBehaviour
{
    // trade
    // attack
    // skill

    public abstract bool CheckIfTargetIsValid (BoardObject objeto);

    public BoardObject targetObject;
    public void SetTarget (BoardObject objeto) {
        targetObject = objeto;
    }

    public List<BoardObject> targetObjects;
    public void SetTargets (List<BoardObject> objects) {
        targetObjects = objects;
    }

    public abstract bool MayStart ();

    public abstract void SetUp ();

    public void Start () {
        SetUp();
    }

    public abstract void Evolve ();

    public void Finish () {
        CleanUp();
    }

    public abstract  void CleanUp ();
}
