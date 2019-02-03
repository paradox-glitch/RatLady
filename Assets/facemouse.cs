using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class facemouse : MonoBehaviour
{
    private SpriteRenderer mySpriteRenderer;

    private void Start()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }
    void Update()
    {
        FaceMouseSystem();
        SpriteSystem();
    }

    private void FaceMouseSystem()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

        Vector2 direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
        transform.up = direction;
    }

    private void SpriteSystem()
    {
        if (transform.eulerAngles.z > 0 && transform.eulerAngles.z < 180)
        {
            mySpriteRenderer.flipX = true;
            Debug.Log("Fliped");
        }
        else if (transform.eulerAngles.z < 360 && transform.eulerAngles.z > 180)
        {
            mySpriteRenderer.flipX = false;
            Debug.Log("Unfliped");
        }

        //Debug.Log(string.Format("Rotation = {0}", transform.eulerAngles.z));

        if (transform.eulerAngles.z < 7.5 || transform.eulerAngles.z > 352.5)
        {
            Debug.Log("Sec1");
        }
        else if (transform.eulerAngles.z > 7.5 && transform.eulerAngles.z < 22.5 || transform.eulerAngles.z > 337.5 && transform.eulerAngles.z < 352.5)
        {
            Debug.Log("Sec2");
        }
        else if (transform.eulerAngles.z > 22.5 && transform.eulerAngles.z < 37.5 || transform.eulerAngles.z > 322.5 && transform.eulerAngles.z < 337.5)
        {
            Debug.Log("Sec3");
        }
        else if (transform.eulerAngles.z > 37.5 && transform.eulerAngles.z < 52.5 || transform.eulerAngles.z > 307.5 && transform.eulerAngles.z < 322.5)
        {
            Debug.Log("Sec4");
        }
        else if (transform.eulerAngles.z > 52.5 && transform.eulerAngles.z < 67.5 || transform.eulerAngles.z > 292.5 && transform.eulerAngles.z < 307.5)
        {
            Debug.Log("Sec5");
        }
        else if (transform.eulerAngles.z > 67.5 && transform.eulerAngles.z < 82.5 || transform.eulerAngles.z > 277.5 && transform.eulerAngles.z < 292.5)
        {
            Debug.Log("Sec6");
        }
        else if (transform.eulerAngles.z > 82.5 && transform.eulerAngles.z < 97.5 || transform.eulerAngles.z > 262.5 && transform.eulerAngles.z < 277.5)
        {
            Debug.Log("Sec7");
        }
        else if (transform.eulerAngles.z > 97.5 && transform.eulerAngles.z < 112.5 || transform.eulerAngles.z > 247.5 && transform.eulerAngles.z < 262.5)
        {
            Debug.Log("Sec8");
        }
        else if (transform.eulerAngles.z > 112.5 && transform.eulerAngles.z < 127.5 || transform.eulerAngles.z > 232.5 && transform.eulerAngles.z < 247.5)
        {
            Debug.Log("Sec9");
        }
        else if (transform.eulerAngles.z > 127.5 && transform.eulerAngles.z < 142.5 || transform.eulerAngles.z > 217.5 && transform.eulerAngles.z < 232.5)
        {
            Debug.Log("Sec10");
        }
        else if (transform.eulerAngles.z > 142.5 && transform.eulerAngles.z < 157.5 || transform.eulerAngles.z > 202.5 && transform.eulerAngles.z < 217.5)
        {
            Debug.Log("Sec11");
        }
        else if (transform.eulerAngles.z > 157.5 && transform.eulerAngles.z < 172.5 || transform.eulerAngles.z > 187.5 && transform.eulerAngles.z < 202.5)
        {
            Debug.Log("Sec12");
        }
        else if (transform.eulerAngles.z > 172.5 && transform.eulerAngles.z < 187.5)
        {
            Debug.Log("Sec13");
        }
    }
}
