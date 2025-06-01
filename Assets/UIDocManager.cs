using UnityEngine;
using UnityEngine.UIElements;

public class UIDocManager : MonoBehaviour
{
    public GameObject pdfViewerGO;
    private UIDocument uIDocument;
    private VisualElement root;
    private bool showPdf = true;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        uIDocument = GetComponent<UIDocument>();
        root = uIDocument.rootVisualElement;
        Button noteButton = root.Q<Button>("noteOnOffButton");

        noteButton.clicked += () =>
        {
            showPdf = !showPdf;
            pdfViewerGO.SetActive(showPdf);
        };
    }

    
}
