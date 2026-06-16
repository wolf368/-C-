using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private CanvasGroup menuBar;
    private bool isMenuActive;
    [SerializeField] private CanvasGroup skileCanvas;
    [SerializeField] private CanvasGroup stateCanvas;
    [SerializeField] private CanvasGroup questCanvas;
    
    [SerializeField] private Sprite openSprite;
    [SerializeField] private Sprite closeSprite;
    [SerializeField] private Image menuToggleImage;

    public void ToggleMenu(CanvasGroup targetGroup)
    {
        setMenuState(stateCanvas, false);
        setMenuState(skileCanvas, false);
        setMenuState(questCanvas, false);

        setMenuState(targetGroup, true);
    }
    public void setMenuState(CanvasGroup group, bool isActive)
    {
        group.alpha = isActive ? 1 : 0;
        group.blocksRaycasts = isActive;
        group.interactable = isActive;
    }
    public void ToggleMainMenu()
    {
        isMenuActive = !isMenuActive;
        setMenuState(menuBar, isMenuActive);
        menuToggleImage.sprite = isMenuActive ? closeSprite : openSprite;
     
        setMenuState(stateCanvas, false);
        setMenuState(skileCanvas, false);
        setMenuState(questCanvas, false);
    }
}
