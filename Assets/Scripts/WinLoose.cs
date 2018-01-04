using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinLoose : DualBehaviour 
{
    #region Public Members

    public Save m_save;

    public Button m_yesButton;
    public Button m_noButton;
    public GameObject m_panelBonus;
    public GameObject m_panelResult;
    public Text m_result;

    #endregion

    #region Public void

    public bool WinGame()
    {
        bool win = false;
        if (m_save.fillAmounts[0] >= 1.0f && m_save.fillAmounts[1] >= 1.0f && m_save.fillAmounts[2] >= 1.0f && m_save.fillAmounts[3] >= 1.0f)
        {
            win = true;
        }
        return win;
    }

    public bool LooseGame()
    {
        bool loose = false;
        if (m_save.fillAmounts[0] <= 0f && m_save.fillAmounts[1] <= 0f && m_save.fillAmounts[2] <= 0f && m_save.fillAmounts[3] <= 0f)
        {
            loose = true;
        }
        return loose;
    }

    public void CheckGameEnding()
    {

        if (WinGame() ||  LooseGame())
        {
            m_yesButton.gameObject.SetActive(false);
            m_noButton.gameObject.SetActive(false);
            m_panelBonus.SetActive(false);
            m_panelResult.SetActive(true);

            if (LooseGame())
            {
                m_result.text = "LOOSE";
            }
            else if (WinGame())
            {
                m_result.text = "WIN";
            }
        }   
    }

    public void RestartGame()
    {
        m_yesButton.gameObject.SetActive(true);
        m_noButton.gameObject.SetActive(true);
        m_panelBonus.SetActive(true);
        m_panelResult.SetActive(false);
        m_result.text = "";
    }

    #endregion

}
