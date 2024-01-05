using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    [Multiline(10)]
    public List<string> Messages;
    public int ChatID = -1;

    public void Chatwith()
    {
        if(playercontroller.instance.CurrentNPC == null)
        {
            playercontroller.instance.setNPC(this);
            ContinueText();
        }
    }

    public void ContinueText()
    {
        
        if (ChatID < Messages.Count - 1)
        {
            ChatID += 1;
            Chatbox.Instance.OpenChatBox();
            Chatbox.Instance.ChangeText(Messages[ChatID]);
        }   
        else
        {
            Chatbox.Instance.CloseChatBox();
            playercontroller.instance.setNPC(null);
            ChatID = -1;
        }
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
