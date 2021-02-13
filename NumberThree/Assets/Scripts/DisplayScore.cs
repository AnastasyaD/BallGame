using UnityEngine;
using UnityEngine.UI;


namespace AnastasyaD
{
    public class DisplayBonuses 
    {
        public static int _score;
        private Text _scoreText;
        
        public DisplayBonuses()
            {
                _scoreText = Object.FindObjectOfType<Text>();
                _score = 0;
            }
        
        public void AddCoin(int count)
            {
                _score += count;
                _scoreText.text = $"Монеты: {_score}";
            }
    }
}
