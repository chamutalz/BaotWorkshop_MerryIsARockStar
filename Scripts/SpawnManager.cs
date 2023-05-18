using UnityEngine;

public class SpawnManager : MonoBehaviour
{
	public Vector3 spawnPosition;
	public GameObject itemPrefab;
	private float timeToNext;

    void Update()
    {
		SpawnItems();
    }

	public void SpawnItems()
	{
		if(Time.time > timeToNext)
		{
			timeToNext += 0.6f;
			spawnPosition = new Vector3(Random.Range(-8.0f, 8.0f), 5.0f, 0.0f);
			GameObject newItem = Instantiate(itemPrefab, spawnPosition, Quaternion.identity);
		}

	}
}
