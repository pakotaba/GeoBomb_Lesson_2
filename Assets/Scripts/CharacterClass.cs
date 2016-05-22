using UnityEngine;
using System.Collections;

public class CharacterClass : MonoBehaviour {

    public float Speed = 0.2f;
    Animator Anim;

	void Start () 
	{
        Anim = gameObject.GetComponent<Animator>();

    }
    void ChangePosition( string dir)
    {
        switch(dir)
        {
		case "left":
                gameObject.transform.Translate(-Speed, 0, 0);
                break;
            case "right":
                gameObject.transform.Translate(Speed, 0, 0);
                break;
            case "up":
                gameObject.transform.Translate(0, Speed, 0);
                break;
            case "down":
                gameObject.transform.Translate(0, -Speed, 0);
                break;
        }
    }

	void Update ()
    {
        if (Input.GetKey(KeyCode.A) && gameObject.transform.position.x > -4)
            ChangePosition("left");
        if (Input.GetKey(KeyCode.D) && gameObject.transform.position.x < 4)
            ChangePosition("right");
        if (Input.GetKey(KeyCode.W) && gameObject.transform.position.y < 3.1f)
            ChangePosition("up");
        if (Input.GetKey(KeyCode.S) && gameObject.transform.position.y > -3.1f)
            ChangePosition("down");

		if (Input.GetKeyDown (KeyCode.A) && gameObject.transform.position.x > -4) 
		{
			if (gameObject.transform.localScale.x > 0)
				gameObject.transform.localScale = new Vector3 (-gameObject.transform.localScale.x, gameObject.transform.localScale.y, gameObject.transform.localScale.z);
			Anim.SetTrigger ("MoveSide");
		}

		if (Input.GetKeyDown (KeyCode.D) && gameObject.transform.position.x < 4)
		{
			if (gameObject.transform.localScale.x < 0)
				gameObject.transform.localScale = new Vector3 (-gameObject.transform.localScale.x, gameObject.transform.localScale.y, gameObject.transform.localScale.z);
			Anim.SetTrigger ("MoveSide");
		}
		if (Input.GetKeyDown (KeyCode.W) && gameObject.transform.position.y < 3.1f) 
		{
			Anim.SetTrigger ("MoveBack");
		}
		if (Input.GetKeyDown (KeyCode.S) && gameObject.transform.position.y > -3.1f) 
		{
			Anim.SetTrigger ("MoveFront");
		}

       if (Input.GetKeyUp(KeyCode.A) && gameObject.transform.position.x > -4)
            Anim.SetTrigger("Stop");
        if (Input.GetKeyUp(KeyCode.D) && gameObject.transform.position.x < 4)
            Anim.SetTrigger("Stop");
        if (Input.GetKeyUp(KeyCode.W) && gameObject.transform.position.y < 3.1f)
            Anim.SetTrigger("Stop");
        if (Input.GetKeyUp(KeyCode.S) && gameObject.transform.position.y > -3.1f)
            Anim.SetTrigger("Stop");

    }
}
