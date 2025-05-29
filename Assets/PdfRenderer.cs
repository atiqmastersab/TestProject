using Paroxe.PdfRenderer;
using UnityEngine;
using UnityEngine.UI;

public class PdfRenderer : MonoBehaviour
{
    public RenderTexture pdfRenderer;
    public string filePath;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PDFDocument pdfDocument = new PDFDocument(filePath, "");
        Texture2D tex = pdfDocument.Renderer.RenderPageToTexture(PDFPage.LoadPageAsync(pdfDocument, 0), pdfRenderer.width, pdfRenderer.height);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
