using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopKeeper : MonoBehaviour
{
    public static ShopKeeper currentShopKeeper;

    public Animator anim;
    public CanvasGroup shopCanvasGroup;
    public ShopManager shopManager;

    [SerializeField] private List<ShopItems> shopItems;
    [SerializeField] private List<ShopItems> shopWeapoms;
    [SerializeField] private List<ShopItems> shopArmour;

    [SerializeField] private Camera shopkeeperCam;
    [SerializeField] private Vector3 cameraOffset = new Vector3(0, 0, -1);


    public static event Action<ShopManager, bool> OnShopStateChanged;

    private bool playerInRange;
    private bool isShopOpen;

    private void Update()
    {
        if (playerInRange)
        {
            if (Input.GetButtonDown("Interact"))
            {
                if (!isShopOpen)
                {
                    //Time.timeScale = 0;
                    currentShopKeeper = this;
                    isShopOpen = true;
                    OnShopStateChanged?.Invoke(shopManager, true);
                    shopCanvasGroup.alpha = 1;
                    shopCanvasGroup.blocksRaycasts = true;
                    shopCanvasGroup.interactable = true;

                    shopkeeperCam.transform.position = transform.position + cameraOffset;
                    shopkeeperCam.gameObject.SetActive(true);

                    OpenItemShop();
                }
                else
                {
                   // Time.timeScale = 1;
                    currentShopKeeper = null;
                    currentShopKeeper = null;
                    isShopOpen = false;
                    OnShopStateChanged?.Invoke(shopManager, false);
                    shopCanvasGroup.alpha = 0;
                    shopCanvasGroup.blocksRaycasts = false;
                    shopCanvasGroup.interactable = false;

                    shopkeeperCam.gameObject.SetActive(false);
                }
            }
        }
    }

    public void OpenItemShop()
    {
        shopManager.PopuLateShopItems(shopItems);
    }
    
    public void OpenWeaponShop()
    {
        shopManager.PopuLateShopItems(shopWeapoms);

    }

    public void OpenArmourShop()
    {
        shopManager.PopuLateShopItems(shopArmour);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            anim.SetBool("PlayerInRanger", true);
            playerInRange = true;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            anim.SetBool("PlayerInRanger", false);
            playerInRange = false;
        }
    }
}
