using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class DialogueManager : MonoBehaviour
{
    
    public Image actorImage;
    public TMPro.TextMeshProUGUI actorName;
    public TMPro.TextMeshProUGUI messageText;
    public RectTransform backgroundBox;
    public TMPro.TextMeshProUGUI space;
    public Button nextButton;
    
    Message[] currentMessages;
    Actor[] currentActors;
    int activeMessageIndex = 0; 
    public static bool isDialogueActive = false;    

    public void StartDialogue(Message[] messages, Actor[] actors){
        currentMessages = messages;
        currentActors = actors;
        activeMessageIndex = 0;
        isDialogueActive = true;
        Debug.Log("StartDialogue"+currentMessages.Length);
        space.text = "Press Space to continue";
        DisplayMessage();
    }

    void DisplayMessage(){
            Message message = currentMessages[activeMessageIndex];
           
            Actor actor = currentActors[message.actorId];
            actorImage.sprite = actor.sprite;
            actorName.text = actor.name;
            messageText.text = message.message;
    }
    public void NextMessage(){
       activeMessageIndex++;
         if(activeMessageIndex < currentMessages.Length){
              DisplayMessage();
         }
         else{
             isDialogueActive = false;
             space.text = "Click on Continue to solve the case";
             nextButton.gameObject.SetActive(true);
         }
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isDialogueActive){
            NextMessage();
        }
    }
}
