using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cameracontroller : MonoBehaviour
{
    public Transform target;

    public Image Fadescreen;

    // Start is called before the first frame update
    void Start()
    {
        Color Fadecolor = Fadescreen.color;
        Fadecolor.a = 1;
        Fadescreen.color = Fadecolor;
        Fadescreen.CrossFadeAlpha(0, 1, false);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(target.position.x, target.position.y, transform.position.z);
    }

    public void fadeteleportplayer(Transform t)
    {
        
        StartCoroutine(fadeteleportplayerroutine(t.position));
    }

    public IEnumerator fadeteleportplayerroutine(Vector3 position)
    {
        Color Fadecolor = Fadescreen.color;
        Fadecolor.a = 0;
        Fadescreen.color = Fadecolor;
        Fadescreen.CrossFadeAlpha(1, 1, false);
        yield return new WaitForSeconds(1);
        playercontroller.instance.transform.position = position;
        Fadecolor.a = 1;
        Fadescreen.color = Fadecolor;
        Fadescreen.CrossFadeAlpha(0, 1, false);
        yield return new WaitForSeconds(1);
    }

}
