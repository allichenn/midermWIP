using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
public class riddleManager : MonoBehaviour
{
    private Queue<string> sentences;

    // Start is called before the first frame update
    void Start()
    {
        sentences = new Queue<string>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeRiddle(riddles riddle){
        Debug.Log("starting riddles");

        sentences.Clear();

        foreach (string sentence in riddle.sentences){
            sentences.Enqueue(sentence);
        }

        displayNextSentence();
    }

    public void displayNextSentence(){
        if (sentences.Count == 0){
            endDialogue();
            return;
        }
        string sentence = sentences.Dequeue();
        Debug.Log(sentence);
    }

    void endDialogue(){
        Debug.Log("end of convo");
    }
}
*/