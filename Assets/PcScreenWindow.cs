using UnityEngine;
using System.Collections;

public enum PcWindowState
{
    None,
    Open,
    Closed,
    Minimized
}

public class PcScreenWindow : MonoBehaviour {

    private PcWindowState m_state;
    public PcWindowState State
    {
        get
        {
            return m_state;
        }

    }
	// Use this for initialization
	void Start () {

        m_state = PcWindowState.Closed;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Open()
    {
        m_state = PcWindowState.Open;
    }

    public void Close()
    {
        m_state = PcWindowState.Closed;
    }

    public void Minimize()
    {
        m_state = PcWindowState.Open;
    }
}
