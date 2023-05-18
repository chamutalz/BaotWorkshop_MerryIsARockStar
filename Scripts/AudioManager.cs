using UnityEngine;

public class AudioManager : MonoBehaviour
{
	[SerializeField]
	private AudioClip[] audioClips;
	private AudioSource audioPlayer;

	private void Start()
	{
		audioPlayer = GetComponent<AudioSource>();
	}

	public void PlayClip(int clip)
	{
		audioPlayer.PlayOneShot(audioClips[clip]);
	}
}
