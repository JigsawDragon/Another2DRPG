using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Interactable : MonoBehaviour
{
    public UnityEvent interactEvent;
    public bool doesrequireinteract;
    public bool doremove;
    bool didinteract;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        playercontroller p = collision.GetComponent<playercontroller>();
        if(p != null)
        {
            if (p.ispressinginteract && doesrequireinteract && !didinteract)
            {
                interactEvent.Invoke();
                if (doremove)
                {
                    didinteract = true;
                    Destroy(gameObject, 0.25f);
                }
            }
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(doesrequireinteract == false && !didinteract)
        {
            playercontroller p = collision.GetComponent<playercontroller>();
            if (p != null)
            {
               interactEvent.Invoke();
                if(doremove)
                {
                    didinteract = true;
                    Destroy(gameObject, 0.25f);
                }
            }
        }
        
    }
}
