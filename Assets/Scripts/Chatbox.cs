using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Chatbox : MonoBehaviour
{
    public static Chatbox Instance;
    public Image Chatboximage;
    public TextMeshProUGUI Chattext;


    public void Awake()
    {
        Instance = this;
    }

    public void OpenChatBox()
    {
        Chatboximage.enabled = true;
        Chattext.enabled = true;
    }

    public void CloseChatBox()
    {
        Chatboximage.enabled = false;
        Chattext.enabled = false;
    }


    public void ChangeText(string T)
    {
        Chattext.text = T;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
