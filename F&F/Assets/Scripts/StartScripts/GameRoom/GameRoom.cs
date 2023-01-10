using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRoom : MonoBehaviour
{

    public string RoomCode { get; set; }
    public Participant Host { get; set; }
    public List<Participant> Participants { get; set; }

    public string[] PawnColors = {
        "Red",
        "Orange",
        "Yellow",
        "Green",
        "Blue",
        "Purple",
        "Black",
        "White",
    };



    public void AddParticipant(string name)
    {
        List<string> availableColors = new List<string>();
        foreach (string color in PawnColors)
        {
            availableColors.Add(color);
        }
        foreach (var participant in Participants)
        {
            availableColors.Remove(participant.PawnColor);
        }
        Participants.Add(new Participant(name, availableColors[0]));
    }

    public void RemoveParticipant(string Name)
    {
        int index = Participants.FindIndex(prop => prop.Name == Name);
        if (index >= 0)
        {
            Participants.RemoveAt(index);
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





public class Participant
{
    public string Name { get; set; }
    public string PawnColor { get; set; }

    public Participant(string name, string pawnColor)
    {
        Name = name;
        PawnColor = pawnColor;
    }
}