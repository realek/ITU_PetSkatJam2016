using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class PcScreenWidgetNotes : MonoBehaviour {

    private const int APARTMENT_ID = 0;
    private const int NEWS_ID = 1;
    private const int MAIL_ID = 2;
    private const int UPDATEPASS_ID = 3;
    private const int DELETEPASSTEXT_ID = 4;
    private const int OBJECTIVE_COUNT = 5;
    private bool m_updatedPass = false;
    private bool m_openedNews = false;
    private bool m_foundApartment = false;
    private bool m_startedDeletePassText = false;
    private bool m_doneDeletePassText = false;
    private bool m_checkedMail = false;
    private bool m_startedUpdatePass = false;

	// Use this for initialization
	void Start () {

        for (int i = 0; i < OBJECTIVE_COUNT; i++)
        {
            switch (i)
            {
                case APARTMENT_ID:
                    {
                        gameObject.transform.GetChild(i).GetChild(0).gameObject.SetActive(false);
                        break;
                    }
                case NEWS_ID:
                    {
                        gameObject.transform.GetChild(i).GetChild(0).gameObject.SetActive(false);
                        break;
                    }
                case MAIL_ID:
                    {
                        gameObject.transform.GetChild(i).GetChild(0).gameObject.SetActive(false);
                        break;
                    }
                default:
                    {
                        gameObject.transform.GetChild(i).gameObject.SetActive(false);
                        break;
                    }
            }
        }

        EventManager.Notes = this;
	}
	
	// Update is called once per frame
	void Update () {

	
	}

    public void StartUpdatePass()
    {
        if (!m_startedUpdatePass)
        {
            gameObject.transform.GetChild(UPDATEPASS_ID).gameObject.SetActive(true);
            gameObject.transform.GetChild(UPDATEPASS_ID).GetChild(0).gameObject.SetActive(false);
            m_startedUpdatePass = true;
        }

    }

    public void CompleteUpdatePass()
    {
        if (!m_updatedPass)
        {
            gameObject.transform.GetChild(UPDATEPASS_ID).GetChild(0).gameObject.SetActive(true);
            m_updatedPass = true;
        }

    }

    public void StartDeletePassText()
    {
        if (!m_startedDeletePassText)
        {
            gameObject.transform.GetChild(DELETEPASSTEXT_ID).gameObject.SetActive(true);
            gameObject.transform.GetChild(DELETEPASSTEXT_ID).GetChild(0).gameObject.SetActive(false);
            m_startedDeletePassText = true;
        }

    }

    public void CompleteDeletePassText()
    {
        if (!m_doneDeletePassText)
        {
            gameObject.transform.GetChild(DELETEPASSTEXT_ID).GetChild(0).gameObject.SetActive(true);
            m_doneDeletePassText = true;
        }

    }

    public void CompleteApartment()
    {
        if (!m_foundApartment)
        {
            gameObject.transform.GetChild(APARTMENT_ID).GetChild(0).gameObject.SetActive(true);
            m_foundApartment = true;
        }

    }

    public void CompleteMail()
    {
        if (!m_checkedMail)
        {
            gameObject.transform.GetChild(MAIL_ID).GetChild(0).gameObject.SetActive(true);
            m_checkedMail = true;
        }

    }

    public void CompleteNews()
    {
        if (!m_openedNews)
        {
            gameObject.transform.GetChild(NEWS_ID).GetChild(0).gameObject.SetActive(true);
            Debug.Log("Completed News");
            m_openedNews = true;
        }

    }

}
