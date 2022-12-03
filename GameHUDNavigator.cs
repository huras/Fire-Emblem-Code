
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameHUDNavigator : MonoBehaviour
{
    Stack<GameHUD> TemporaryHUDStack = new Stack<GameHUD>();

    public void CloseHUD(GameHUD hud){
        if(TemporaryHUDStack.Count <= 0)
            return;

        GameHUD currentHUD = null;
        do{
            currentHUD = TemporaryHUDStack.Pop();
        } while(currentHUD != hud);
    }

    public void OpenHUD(GameHUD hud){
        TemporaryHUDStack.Push(hud);
    }

    public void Update(){
        if(TemporaryHUDStack.Count > 0){
            GameHUD currentHUD = TemporaryHUDStack.Peek();
            currentHUD.GameHUDUpdate();
        }
    }
}
