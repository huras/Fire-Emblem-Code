
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHUDNavigator : MonoBehaviour
{
    Stack<GameHUD> HUDStack = new Stack<GameHUD>();

    public void OpenHUD(GameHUD hud){
        HUDStack.Push(hud);
    }
}
