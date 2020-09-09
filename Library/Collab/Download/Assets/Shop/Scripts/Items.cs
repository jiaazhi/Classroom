using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
	public enum ItemType
	{
		IM3080Notes,
		laptop,
		calculator,
		pencil
	}

	public static int GetCost(ItemType itemType)
	{
		switch (itemType)
		{
			default:
			case ItemType.IM3080Notes: return 3;
			case ItemType.laptop: return 10;
			case ItemType.calculator: return 5;
			case ItemType.pencil: return 2;

		}
	}

	public static Sprite GetSprite(ItemType itemType)
	{
		switch (itemType)
		{
			default:
			case ItemType.IM3080Notes: return GameAsset.i.s_IM3080Notes;
			case ItemType.laptop: return GameAsset.i.s.laptop;
			case ItemType.calculator: return GameAsset.i.s.calculator;
			case ItemType.pencil: return GameAsset.i.s.pencil;
		}
	}
}
