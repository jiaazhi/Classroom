using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UI : MonoBehaviour
{

    private Transform container;
    private Transform shopItemTemplate;

    private void Awake()
    {
        container = transform.Find("container"); //ref to container 
        shopItemTemplate = container.Find("shopItemTemplate"); //ref to shopItemTemplate inside container
        shopItemTemplate.gameObject.SetActive(false);
    }

    private void Start()
    {
        CreateItemButton(ItemSprite.GetSprite(Item.ItemType.IM3080Notes), "IM3080Notes", itemSprite.GetCost(Item.ItemType.IM3080Notes), 0);
        CreateItemButton(ItemSprite.GetSprite(Item.ItemType.laptop), "laptop", itemSprite.GetCost(Item.ItemType.laptop), 1);

    }

    private void CreateItemButton(Sprite itemSprite, string itemName, int itemCost, int positionIndex)
    {
        Transform shopItemTransform = Instantiate(shopItemTemplate, container);
        RectTransform shopItemRectTransform = shopItemTransform.GetComponent<RectTransform>();

        float shopItemHeight = 30f;
        shopItemRectTransform.anchoredPosition = new Vector2(0, -shopItemHeight * positionIndex);

        shopItemTransform.Find("itemName").GetComponent<TextMeshProUGUI>().SetText(itemName);
        shopItemTransform.Find("costText").GetComponent<TextMeshProUGUI>().SetText(itemCost.ToString());

        shopItemTransform.Find("itemImage").GetComponent < ImageO().sprite = itemSprite;
    }
}
