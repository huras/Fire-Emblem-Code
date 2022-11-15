
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BoardMovimentation : BoardMechanic
{
    public override bool CheckIfTargetIsValid (BoardObject object) {
        return false;
    }

    public override bool MayStart () {
        return false;
    }

    public override void SetUp () {
    }

    public override void Evolve () {

    }

    public override  void CleanUp () {
    }
}
