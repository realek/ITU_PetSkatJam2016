﻿using UnityEngine;
using System.Collections;

public static class EventManager {

    private static bool m_passChangeEvt = false;
    private static bool m_hasFoundApartmentEvt = false;
    private static bool m_hasDeletedPasswords = false;
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

    public static bool ChangedPassword
    {
        get
        {
            return m_passChangeEvt;
        }
    }

    public static bool PasswordsDeleted
    {
        get
        {
            return m_hasDeletedPasswords;
        }
    }

    public static void PassChange()
    {
        if (!m_passChangeEvt)
            m_passChangeEvt = true;

        Debug.Log("Password was changed");
    }

    public static void DeletedPasswords()
    {
        if (!m_hasDeletedPasswords)
            m_hasDeletedPasswords = true;

        Debug.Log("Has deleted passwords");
    }
}
