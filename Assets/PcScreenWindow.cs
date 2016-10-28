using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public enum PcWindowState
{
    None,
    Open,
    Closed,
    Minimized
}

public class PcScreenWindow : MonoBehaviour {

    private Text m_windowText;
    private Button m_closeButton;
    [SerializeField]
    private string m_windowName;
    [SerializeField]
    private Sprite m_windowCloseSprite;
    private PcWindowState m_state;
    public PcWindowState State
    {
        get
        {
            return m_state;
        }

    }
    private bool m_dragging;
    private Vector3 m_lastMousePos;
    private RectTransform m_transform;
    bool m_dragStart;
	// Use this for initialization
	void Start () {

        m_transform = gameObject.GetComponent<RectTransform>();
        m_state = PcWindowState.Closed;
        gameObject.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Open()
    {
        gameObject.SetActive(true);
        m_state = PcWindowState.Open;

    }

    public void Close()
    {
        m_state = PcWindowState.Closed;
        gameObject.SetActive(false);
    }

    public void Drag()
    {
        if (!m_dragging)
        {
            m_lastMousePos = Input.mousePosition;
            m_dragging = true;
        }
        Vector3 cPosOffset = Input.mousePosition - m_lastMousePos;
        Debug.Log(cPosOffset);
        gameObject.transform.position += cPosOffset;
        m_lastMousePos = Input.mousePosition;
    }

    public void EndDrag()
    {
        m_dragging = false;
    }
}
