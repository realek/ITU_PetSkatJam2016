using UnityEngine;
using System.Collections;

public enum NotesEvent
{
    None,
    Apartment_Done,
    News_Done,
    Mail_Sister_PassDelete_Start,
    Mail_Sister_PassDelete_Done,
    UpdatePass_Done
}
public class NotesEventTrigger : MonoBehaviour {
    [SerializeField]
    private NotesEvent m_Event;
    // Use this for initialization

    public void TriggerEvent()
    {
        switch (m_Event)
        {
            case NotesEvent.Apartment_Done:
                {
                    EventManager.Notes.CompleteApartment();
                    break;
                }
            case NotesEvent.News_Done:
                {
                    EventManager.Notes.CompleteNews();
                    EventManager.Notes.StartUpdatePass();
                    break;
                }
            case NotesEvent.Mail_Sister_PassDelete_Start:
                {
                    EventManager.Notes.StartDeletePassText();
                    break;
                }
            case NotesEvent.Mail_Sister_PassDelete_Done:
                {
                    EventManager.Notes.CompleteDeletePassText();
                    break;
                }
            case NotesEvent.UpdatePass_Done:
                {
                    EventManager.Notes.CompleteUpdatePass();
                    break;
                }

        }
    }
}
