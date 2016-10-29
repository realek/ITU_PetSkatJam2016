using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PcScreenBankWidget : MonoBehaviour {

    [SerializeField]
    private float m_currentBallance;
    private const float GBP_TO_DKK_RATE = 8.25f;
    private const string USD = "GBP";
    private Text m_ballanceDisplay;
	// Use this for initialization
	void Start ()
    {
        m_ballanceDisplay = gameObject.transform.GetChild(1).GetComponent<Text>();
        EventManager.Bank = this;
        m_ballanceDisplay.text = m_currentBallance.ToString() + " " + USD;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void WithDrawFunds(float ammount)
    {
        if(ammount > 0)
            m_currentBallance -= ammount / GBP_TO_DKK_RATE;
        m_ballanceDisplay.text = m_currentBallance.ToString() + " " + USD;
    }
}
