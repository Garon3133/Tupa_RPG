using UnityEngine;
using UnityEngine.UI;

namespace MainMenu
{
    public class MainMenuUI : MonoBehaviour
    {
        [SerializeField] private Button startBtn;
        [SerializeField] private Animator startBtnAniamtor;

        private void Start()
        {
            startBtn.onClick.AddListener(() =>
            {
                startBtnAniamtor.Play($"SparkAnimation");
            });
        }
    }
}
