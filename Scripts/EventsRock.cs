using System;
using UnityEngine;

public class EventsRock : MonoBehaviour
{
	public static EventsRock current;

	private void Awake()
	{
		current = this;
	}

	public event Action<string> OnCatchItem;

	public void CatchItem(string tag)
	{
		if (OnCatchItem != null)
		{
			OnCatchItem(tag);
		}
	}

}
