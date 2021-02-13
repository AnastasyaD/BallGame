using UnityEngine;


namespace AnastasyaD
{
    public class ReloadPosition
    {
        private Movement[] _players;
        private Vector3 _position;

        public ReloadPosition()
        {
            _players = Object.FindObjectsOfType<Movement>();
            if (_players.Length > 0)
            {
                _position = _players[0].transform.position;
            }
        }
        
        public void StartPosition()
        {
            _players[0].transform.position = _position;
        }
    }
}
