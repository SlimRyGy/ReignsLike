using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dilemme : DualBehaviour 
{
    #region Public Members

    public List<string> m_meiList = new List<string>();
    public List<string> m_genjiList = new List<string>();
    public List<Sprite> m_heroAvatar = new List<Sprite>();

    public Image m_currentAvatar;
    public Text m_currentText;
    public Text m_currentAvatarName;
    int _indexAvatar = 0;
    int _indexMei = 0;
    int _indexGenji = 0;

    #endregion

    #region Public void

    public void ChangeAvatar()
    {
        int m_avatarCount = m_heroAvatar.Count;

        m_currentAvatar.sprite = m_heroAvatar[_indexAvatar];
        m_currentAvatarName.text = m_currentAvatar.sprite.name;
        _indexAvatar += 1;

        if (_indexAvatar >= m_avatarCount)
        {
            _indexAvatar = 0;
        }
    }

    public void ChangeText()
    {
        if(m_currentAvatar.sprite.name == "mei")
        {
            int m_meiCount = m_meiList.Count;
            m_currentText.text = m_meiList[_indexMei];
            _indexMei += 1;

            if (_indexMei >= m_meiCount)
            {
                _indexMei = 0;
            }
        }
        else if (m_currentAvatar.sprite.name == "genji")
        {
            int m_genjiCount = m_genjiList.Count;
            m_currentText.text = m_genjiList[_indexGenji];
            _indexGenji += 1;

            if (_indexGenji >= m_genjiCount)
            {
                _indexGenji = 0;
            }
        }
    }

    #endregion

    #region System

    void Start () 
    {
		
	}
	
	void Update () 
    {
		
	}

    #endregion

    #region Class Methods
    
    #endregion

    #region Tools Debug and Utility

    #endregion

    #region Private and Protected Members

    #endregion

}
