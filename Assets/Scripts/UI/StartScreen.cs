using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StartScreen : Screen
{
    public event UnityAction PlayButtonClick = delegate { };

    public override void Close()
    {
        CanvasGroup.alpha = 0;
        Button.interactable = false;
    }

    protected override void OnButtonClick()
    {
        PlayButtonClick();
    }

    public override void Open()
    {
        CanvasGroup.alpha = 1;
        Button.interactable = true;
    }
}
