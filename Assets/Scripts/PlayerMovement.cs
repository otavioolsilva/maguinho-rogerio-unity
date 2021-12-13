using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller;

    public Animator animator;

    [SerializeField] private float runSpeed = 40f;
    private float originalSpeed;

	private float horizontalMove = 0f;
	private bool jump = false;

    void Awake()
    {
        originalSpeed = runSpeed;
    }
	
	void Update ()
    {
		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        animator.SetFloat("Speed", Mathf.Abs(horizontalMove));

		if (Input.GetButtonDown("Jump"))
		{
			jump = true;
		}
	}

	void FixedUpdate ()
	{
		controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
		jump = false;
	}

    //Detect collisions
    void OnCollisionEnter2D (Collision2D col)
    {
        //Quicksand
        if (col.gameObject.tag == "Quicksand")
            runSpeed = 0.5f * originalSpeed;
        else
            runSpeed = originalSpeed;

        //Orc
        if (col.gameObject.tag == "Orc")
        {
            runSpeed = 0f;
            animator.enabled = false;
        }
    }
}
