using UnityEngine;
using System.Collections;

public class CharacterClass : MonoBehaviour {
    public float Speed = 0.25f;
	void Start () {

    }
    
    void ChoosePosition(string dir)
    {
        switch (dir)
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
         if (Input.GetKey(KeyCode.A) && gameObject.transform.position.x > -5)
            ChoosePosition("left");
         if (Input.GetKey(KeyCode.D) && gameObject.transform.position.x < 5)
            ChoosePosition("right");
        if (Input.GetKey(KeyCode.W) && gameObject.transform.position.y < 5)
            ChoosePosition("up");
        if (Input.GetKey(KeyCode.S) && gameObject.transform.position.y > -5)
            ChoosePosition("down");

    }
}
