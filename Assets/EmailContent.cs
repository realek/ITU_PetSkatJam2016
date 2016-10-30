using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class EmailContent : MonoBehaviour {

    [SerializeField]
    private GameObject m_mailList;
    private Email[] m_mails;
    private bool m_checkedMail = false;
    private Email m_currentMail;
    [SerializeField]
    private GameObject m_trust;
	// Use this for initialization
	void Start () {

        m_mails = new Email[m_mailList.transform.childCount];

        for (int i = 0; i < m_mailList.transform.childCount; i++)
        {
            m_mails[i] = m_mailList.transform.GetChild(i).GetComponent<Email>();
        }

        m_trust.SetActive(false);

	}
	
	// Update is called once per frame
	void Update () {

        CheckIfAllSeen();
	
	}

    public void TrustEmail()
    {
        EventManager.Bank.WithDrawFunds(m_currentMail.Price);
        if (m_currentMail.ApartmentFound)
        {
            EventManager.Notes.CompleteApartment();
        }
    }
    public void SetCurrentMail(Email em)
    {
        m_currentMail = em;
    }

    void CheckIfAllSeen()
    {
        if (m_currentMail != null)
        {
            if (!m_trust.activeSelf)
            {
                m_trust.SetActive(true);
            }

        }

        int count = 0;
        for (int i = 0; i < m_mails.Length; i++)
        {

            if (m_mails[i].isSeen)
            {
                count++;
            }
        }

        if (count == m_mails.Length && !m_checkedMail)
        {
            EventManager.Notes.CompleteMail();
            m_checkedMail = true;
        }
    }
}
