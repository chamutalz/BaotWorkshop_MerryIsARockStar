using UnityEngine;

public class Player : MonoBehaviour
{
	private const float MIN_X = -9.0f, MAX_X = 9.0f;
	private float speed = 10;
	private Animator playerAnimator;
	private SpriteRenderer playerSpriteRendere;
	private float inputX;

    void Start()
    {
		playerAnimator = GetComponent<Animator>();
		playerSpriteRendere = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
		inputX = Input.GetAxis("Horizontal");
		Move();
		Flip();
		Animate();
    }

	private void Flip()
	{
		if(inputX < 0)
		{
			playerSpriteRendere.flipX = false;
		}
		else if(inputX > 0)
		{
			playerSpriteRendere.flipX = true;
		}
	}

	private void Move()
	{
		transform.Translate(new Vector3(inputX, 0, 0) * speed * Time.deltaTime);
		Vector3 clampedPosition = new Vector3 (Mathf.Clamp(transform.position.x, MIN_X, MAX_X), transform.position.y, transform.position.z);
		transform.position = clampedPosition;
	}

	private void Animate()
	{
		if(inputX == 0)
		{
			playerAnimator.SetTrigger("Idle");
		}
		else if(inputX != 0)
		{
			playerAnimator.SetTrigger("Walk");
		}
	}
	
}
