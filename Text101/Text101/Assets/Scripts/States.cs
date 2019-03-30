using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]

public class States : ScriptableObject
{
    [TextArea(10,14)][SerializeField] string storyText;
    [SerializeField] States[] nextStates;

    public States[] GetNextStates()
    {
        return nextStates;
    }

    public string GetStateStory()
    {
        return storyText;
    }
     
}
