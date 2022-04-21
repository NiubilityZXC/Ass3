using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace TecEduFURB.Scoreboard {

	/// <summary>
	/// Gerencia a atualização da lista de pontuações do scoreboard.
	/// </summary>
    public class ScoreManager : MonoBehaviour {

		public GameObject playerScoreEntryPrefab;
		private List<Score> scores = new List<Score>();
		
		/// <summary>
		/// Recupera a lista de pontuações.
		/// </summary>
		/// <returns>A lista de pontuações.</returns>
		public List<Score> GetScores() {
			return scores;
		}

		/// <summary>
		/// Adiciona uma nova pontuação à lista de pontuações.
		/// </summary>
		/// <param name="score">A pontuação que deseja adicionar.</param>
		public void AddScore(Score score) {
			scores.Add(score);
		}

		/// <summary>
		/// Adiciona uma nova pontuação à lista de pontuações.
		/// </summary>
		/// <param name="name">Nome da pontuação.</param>
		/// <param name="value">Valor da pontuação.</param>
		public void AddScore(string name, int value) {
			scores.Add(new Score(name, value));
		}
		
		/// <summary>
		/// Atualiza o componente UI do scoreboard com as pontuações da lista.
		/// </summary>
		public void UpdateScoreboard() {
			ClearScoreboard();

			foreach(Score score in scores)
				AddEntryInScoreboard(score);
		}

		/// <summary>
		/// Adiciona a pontuação informada como um item no componente scoreboard da UI.
		/// </summary>
		/// <param name="score">A pontuação que será adicionada no componente.</param>
		private void AddEntryInScoreboard(Score score) {
			GameObject go = (GameObject)Instantiate(playerScoreEntryPrefab);
			go.transform.SetParent(this.transform);
			go.GetComponent<RectTransform>().localScale = new Vector3(1f, 1f, 1f);

			go.transform.Find("Username").GetComponent<Text>().text = score.Name;

			if(score.Value >= 0)
				go.transform.Find("Score").GetComponent<Text>().text = score.Value.ToString();
			else
				go.transform.Find("Score").GetComponent<Text>().text = "Sem pontuação";
		}

		/// <summary>
		/// Remove todas as pontuações do componente UI scoreboard.
		/// </summary>
		private void ClearScoreboard() {
			while(this.transform.childCount > 0) {
				Transform c = this.transform.GetChild(0);
				c.SetParent(null);
				Destroy (c.gameObject);
			}
		}

	}

}