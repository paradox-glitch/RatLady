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
        if (transform.rotation.z < 0)
        {
            mySpriteRenderer.flipX = true;
        }
        else if (transform.rotation.z > 0)
        {
            mySpriteRenderer.flipX = false;
        }

        Debug.Log(string.Format("WeaponNum = {0}", transform.rotation.z * 180));

        if (transform.rotation.z < 7.5 && transform.rotation.z > -7.5)
        {
            Debug.Log("Sec1");
        }
        else if (transform.rotation.z < -7.5 && transform.rotation.z > -22.5 || transform.rotation.z > 7.5 && transform.rotation.z < 22.5)
        {
            Debug.Log("Sec2");
        }
        else if (transform.rotation.z < -22.5 && transform.rotation.z > -37.5 || transform.rotation.z > 22.5 && transform.rotation.z < 37.5)
        {
            Debug.Log("Sec3");
        }
        else if (transform.rotation.z < -37.5 && transform.rotation.z > -52.5 || transform.rotation.z > 37.5 && transform.rotation.z < 52.5)
        {
            Debug.Log("Sec4");
        }
        else if (transform.rotation.z < -52.5 && transform.rotation.z > -67.5 || transform.rotation.z > 52.5 && transform.rotation.z < 67.5)
        {
            Debug.Log("Sec5");
        }
        else if (transform.rotation.z < -67.5 && transform.rotation.z > -82.5 || transform.rotation.z > 67.5 && transform.rotation.z < 82.5)
        {
            Debug.Log("Sec6");
        }
        else if (transform.rotation.z < -82.5 && transform.rotation.z > -97.5 || transform.rotation.z > 82.5 && transform.rotation.z < 97.5)
        {
            Debug.Log("Sec7");
        }
        else if (transform.rotation.z < -97.5 && transform.rotation.z > -112.5 || transform.rotation.z > 97.5 && transform.rotation.z < 112.5)
        {
            Debug.Log("Sec8");
        }
        else if (transform.rotation.z < -112.5 && transform.rotation.z > -127.5 || transform.rotation.z > 112.5 && transform.rotation.z < 127.5)
        {
            Debug.Log("Sec9");
        }
        else if (transform.rotation.z < -127.5 && transform.rotation.z > -142.5 || transform.rotation.z > 127.5 && transform.rotation.z < 142.5)
        {
            Debug.Log("Sec10");
        }
        else if (transform.rotation.z < -142.5 && transform.rotation.z > -157.5 || transform.rotation.z > 142.5 && transform.rotation.z < 157.5)
        {
            Debug.Log("Sec11");
        }
        else if (transform.rotation.z < -157.5 && transform.rotation.z > -172.5 || transform.rotation.z > 157.5 && transform.rotation.z < 172.5)
        {
            Debug.Log("Sec12");
        }
        else if (transform.rotation.z < -172.5 || transform.rotation.z > 172.5)
        {
            Debug.Log("Sec13");
        }
    }
}
