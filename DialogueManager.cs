using UnityEngine;
using TMPro; // Required for TextMeshPro
using UnityEngine.UI; // Required if you want to control button interactivity

public class DialogueManager : MonoBehaviour
{
    [Header("UI Elements")]
    [SerializeField] private TextMeshProUGUI dialogueText;
    [SerializeField] private Button prevButton;
    [SerializeField] private Button nextButton;
    [SerializeField] private Button finishButton;

    [Header("Dialogue Content")]
    [TextArea(3, 5)] // Makes it easier to edit long text in the Inspector
    [SerializeField] private string[] dialogueLines;

    private int currentLineIndex = 0;

    void Start()
    {
        // Automatically hide the finish button at the start of the scene
        if (finishButton != null)
        {
            finishButton.gameObject.SetActive(false);
        }

        if (dialogueLines.Length > 0)
        {
            UpdateDialogueUI();
        }
        else
        {
            dialogueText.text = "No dialogue loaded.";
            UpdateButtonStates();
        }
    }

    public void ShowNextLine()
    {
        if (currentLineIndex < dialogueLines.Length - 1)
        {
            currentLineIndex++;
            UpdateDialogueUI();
        }
    }

    public void ShowPreviousLine()
    {
        if (currentLineIndex > 0)
        {
            currentLineIndex--;
            UpdateDialogueUI();
        }
    }

    public void FinishDialogue()
    {
        Debug.Log("Dialogue Finished!");
        // Add your logic here (e.g., hide the entire UI panel, trigger an event, start a fight, load next scene)
        //gameObject.SetActive(false); // Example: Hides the entire manager/dialogue box
    }
    private void UpdateDialogueUI()
    {
        dialogueText.text = dialogueLines[currentLineIndex];
        UpdateButtonStates();
    }

    private void UpdateButtonStates()
    {
        bool isLastLine = (currentLineIndex == dialogueLines.Length - 1);

        // Prev button management
        if (prevButton != null)
            prevButton.interactable = (currentLineIndex > 0);

        // Next button management: Hide it completely if it's the last line
        if (nextButton != null)
            nextButton.gameObject.SetActive(!isLastLine);

        // Finish button management: Pop up only if it's the last line
        if (finishButton != null)
        {
            finishButton.gameObject.SetActive(isLastLine);
        }
    }
}