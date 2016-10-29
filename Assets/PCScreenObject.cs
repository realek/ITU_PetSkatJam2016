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
    public bool CanBeOpened = true;
    public bool HasName = true;
    // Use this for initialization
	void Start () {
        m_iconImage = GetComponent<Image>();
        m_iconText = transform.GetChild(1).GetComponent<Text>();
        m_iconImage.sprite = m_iconSprite;

        if (HasName)
            m_iconText.text = m_IconName;

        if (m_windowPrefab != null)
        {
            m_associtatedWindow = Instantiate(m_windowPrefab).GetComponent<PcScreenWindow>();
            m_associtatedWindow.transform.SetParent(transform.parent);
            RectTransform parentRect = transform.GetComponent<RectTransform>();
            m_associtatedWindow.transform.localPosition = parentRect.rect.center;
            m_associtatedWindow.transform.localScale = Vector3.one;
        }



	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void OpenWindow()
    {
        if (CanBeOpened && m_associtatedWindow.State != PcWindowState.Open)
        {
            m_associtatedWindow.gameObject.SetActive(true);
            m_associtatedWindow.Open();
        }


    }


}
