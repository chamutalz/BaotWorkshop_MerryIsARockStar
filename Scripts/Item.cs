using UnityEngine;

public class Item : MonoBehaviour
{
	private SpriteRenderer itemSpriteRendere;
	[SerializeField]
	private Sprite[] spritePoolCool;
	[SerializeField]
	private Sprite[] spritePoolLame;

	void Start()
    {
		itemSpriteRendere = GetComponent<SpriteRenderer>();
		if(Random.value < 0.5f)
		{
			// cool item
			int i = Random.Range(0, spritePoolCool.Length);
			Sprite coolSprite = spritePoolCool[i];
			itemSpriteRendere.sprite = coolSprite;
			this.gameObject.tag = "Cool";
		}
		else
		{
			// lame item
			int j = Random.Range(0, spritePoolLame.Length);
			Sprite lameSprite = spritePoolLame[j];
			itemSpriteRendere.sprite = lameSprite;
			this.gameObject.tag = "Lame";
		}
    }


	private void OnTriggerEnter2D(Collider2D otherCollider)
	{
		if(otherCollider.gameObject.tag == "Player")
		{
			EventsRock.current.CatchItem(this.gameObject.tag);
			Destroy(this.gameObject);
		}

		else if(otherCollider.gameObject.tag == "Border")
		{
			Destroy(this.gameObject);
		}
	}
}
