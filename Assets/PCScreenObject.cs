using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PCScreenObject : MonoBehaviour {

    [SerializeField]
    private Sprite m_iconSprite;
    [SerializeField]
    private string m_IconName;
    [SerializeField]
    private GameObject m_windowPrefab;
    private PcScreenWindow m_associtatedWindow;
    private Image m_iconImage;
    private Text m_iconText;
	
    // Use this for initialization
	void Start () {
        m_iconImage = GetComponent<Image>();
        m_iconText = transform.GetChild(0).GetComponent<Text>();
        m_iconImage.sprite = m_iconSprite;
        m_iconText.text = m_IconName;

        if(m_windowPrefab!=null)
            m_associtatedWindow = Instantiate(m_windowPrefab).GetComponent<PcScreenWindow>();


	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OpenWindow()
    {
        if(m_associtatedWindow.State != PcWindowState.Open)
            m_associtatedWindow.Open();

    }

}
