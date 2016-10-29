using UnityEngine;
using System.Collections;

public static class EventManager {

    private static PcScreenBankWidget m_bank;
    public static PcScreenBankWidget Bank
    {
        set
        {
            if (m_bank == null)
                m_bank = value;
        }

        get
        {
            return m_bank;
        }
    }

    private static PcScreenWidgetNotes m_notes;
    public static PcScreenWidgetNotes Notes
    {
        set
        {
            if (m_notes == null)
                m_notes = value;
        }

        get
        {
            return m_notes;
        }
    }

}
