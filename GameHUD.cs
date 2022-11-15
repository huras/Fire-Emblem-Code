
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHUD : MonoBehaviour
{
    public abstract bool Focus () {
    }

    public abstract bool Close () {
    }

    public abstract bool RestartAndAwake () {
    }
}
