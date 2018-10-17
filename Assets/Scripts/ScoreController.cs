using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class ScoreController : MonoBehaviour
    {
        public int Count;
        public Text CountText;
        public Text WinText;

        public void SetCountText()
        {
            CountText.text = $"Count: {++Count}";
            if (Count >= 12)
                WinText.text = "You Win!";
        }
    }
}
