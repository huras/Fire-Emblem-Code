
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoardMechanic : MonoBehaviour
{
    // trade
    // attack
    // skill

    public abstract bool CheckIfTargetIsValid (BoardObject object) {
        return false;
    }

    public BoardObject targetObject;
    public void SetTarget (BoardObject object) {
        targetObject = object;
    }

    public List<BoardObject> targetObjects;
    public void SetTargets (List<BoardObject> objects) {
        targetObjects = objects;
    }

    public abstract bool MayStart () {
        return false;
    }

    public abstract void SetUp () {
    }

    public void Start () {
        SetUp();
    }

    public abstract void Evolve () {

    }

    public void Finish () {
        CleanUp();
    }

    public abstract  void CleanUp () {
    }
}
