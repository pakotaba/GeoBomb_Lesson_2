using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

    public GameObject _bg;
    public GameObject _borderBg;
    public float xStart = -4;
    public float yStart = 3;
    public float D = 0.6f;
    float X;
    int xBlock = 15;
    int yBlock = 10;


    void Start ()
    {
        X = xStart;
        GenerateBG();
    }
    void GenerateBG()
    {
        for(int k = 0; k<yBlock; k++)
        { 
        for(int i = 0; i<xBlock; i++)
        { if(i==0 || k==0)
           Instantiate(_borderBg, new Vector3(xStart, yStart, 0), Quaternion.identity);
          else if (i == xBlock-1 || k == yBlock-1)
                    Instantiate(_borderBg, new Vector3(xStart, yStart, 0), Quaternion.identity);
            else
                    Instantiate(_bg, new Vector3(xStart, yStart, 0), Quaternion.identity);

                xStart += D;
        }
            xStart = X;
            yStart -= D;
        }

    }
	void Update () {
	
	}
}
