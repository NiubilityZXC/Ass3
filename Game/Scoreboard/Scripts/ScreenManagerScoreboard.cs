using System;
using UnityEngine;
using UnityEngine.UI;

namespace TecEduFURB.Scoreboard {

    /// <summary>
    /// Gerencia a comunicação entre a Classe ScoreManager e a UI,
    /// utilizando os prefabs do scoreboard para exibir e interagir
    /// com as pontuações.
    /// </summary>
    public class ScreenManagerScoreboard : MonoBehaviour {

        [SerializeField] private InputField playerNameInputField;
        [SerializeField] private InputField playerScoreInputField;
        [SerializeField] private Button rankingPanelButton;

        [SerializeField] private GameObject savePlayerScorePanel;
        [SerializeField] private GameObject scoreboardPanel;

        [SerializeField] private ScoreManager scoreManager;

        /// <summary>
        /// Trata o evento do botão de enviar a pontuação, adicionando uma nova pontuação
        /// na lista e atualizando o componente do scoreboard.
        /// </summary>
        public void SendScoreButton() {
            if(playerNameInputField.text == string.Empty || playerScoreInputField.text == string.Empty)
                return;

            scoreManager.AddScore(playerNameInputField.text, Convert.ToInt32(playerScoreInputField.text));

            ShowScoreboardPanel();
        }

        /// <summary>
        /// Ativa e desativa o componente scoreboard.
        /// </summary>
        public void ShowScoreboardPanel() {
            if(!scoreboardPanel.activeSelf) {
                savePlayerScorePanel.SetActive(false);
                scoreboardPanel.SetActive(true);

                scoreManager.UpdateScoreboard();
            } else {
                scoreboardPanel.SetActive(false);
                savePlayerScorePanel.SetActive(true);
            }
        }

    }

}