using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.Events;

public enum EmailType
{
    None,
    Fake,
    Real
}
public class Email : MonoBehaviour {

    [SerializeField]
    private string m_subject = "This is a template E-mail";
    [SerializeField]
    private bool m_seen = false;
    public bool isSeen
    {
        get
        {
            return m_seen;
        }
    }
    [SerializeField]
    private EmailType m_type;
    private Text m_text;
    private Button m_button;
    [SerializeField]
    private Sprite m_EmailContent;
    [SerializeField]
    private Color m_unSeenColorNormal;
    [SerializeField]
    private Color m_unSeenColorHLit;
    private ColorBlock m_colorBkup;
    [SerializeField]
    private GameObject m_content;
    private Image m_contentDisplay;
    [SerializeField]
    private float m_trustPriceDKK;
    [SerializeField]
    private bool m_isApartment = false;

    public bool ApartmentFound
    {
        get
        {
            return m_isApartment;
        }
    }
    public float Price
    {
        get
        {
            return m_trustPriceDKK;
        }

    }
	// Use this for initialization
	void Start () {

        m_button = GetComponent<Button>();
        m_text = transform.GetChild(0).GetComponent<Text>();
        m_text.text = m_subject;
        ColorBlock colorB = m_button.colors;
        m_colorBkup = m_button.colors;
        colorB.normalColor = m_unSeenColorNormal;
        colorB.highlightedColor = m_unSeenColorHLit;
        m_button.colors = colorB;
        m_contentDisplay = m_content.transform.GetChild(0).GetComponent<Image>();
	}

    public void AddContentDisplayFunction(UnityAction action)
    {
        m_button.onClick.AddListener(action);
    }

    public void Seen()
    {
        m_button.colors = m_colorBkup;
        m_seen = true;
        m_contentDisplay.sprite = m_EmailContent;
    }
	// Update is called once per frame
	void Update () {
	
	}
}
