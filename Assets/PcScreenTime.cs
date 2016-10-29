using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PcScreenTime : MonoBehaviour {

    private const int START_TIME_24H = 13;
    private readonly int[] START_MIN = { 0,0 };
    private const string SEPARATOR = ":";
    private int m_cHour;
    private int[] m_cMinutes;
    private string m_cTime;
    private Text m_Time;
    private WaitForSeconds m_w8;
    [SerializeField]
    private float secPerTick = 1.0f;
	// Use this for initialization
	void Start () {
        m_w8 = new WaitForSeconds(secPerTick);
        m_Time = GetComponent<Text>();
        m_cHour = START_TIME_24H;
        m_cMinutes = START_MIN;
        m_cTime = m_cHour.ToString() + SEPARATOR + m_cMinutes[0].ToString()+m_cMinutes[1].ToString();
        m_Time.text = m_cTime;

        StartCoroutine(Clock());
	
	}

    IEnumerator Clock()
    {
        while (true)
        {
            yield return m_w8;
            if (m_cMinutes[1] >= 0 && m_cMinutes[1] < 9)
                m_cMinutes[1]++;
            else if (m_cMinutes[1] == 9)
            {
                m_cMinutes[1] = 0;
                if (m_cMinutes[0] >= 0 && m_cMinutes[0] < 5)
                    m_cMinutes[0]++;
                else if (m_cMinutes[0] == 5)
                {
                    m_cMinutes[0] = 0;
                    if (m_cHour >= 0 && m_cHour < 23)
                        m_cHour++;
                    else if(m_cHour == 23)
                        m_cHour = 0;
                }
            }

            if (m_cHour == 0)
                m_cTime = m_cHour.ToString() + m_cHour.ToString() + SEPARATOR + m_cMinutes[0].ToString() + m_cMinutes[1].ToString();
            else
                m_cTime = m_cHour.ToString() + SEPARATOR + m_cMinutes[0].ToString() + m_cMinutes[1].ToString();

            m_Time.text = m_cTime;
        }



    }
}
