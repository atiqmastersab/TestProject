using Paroxe.PdfRenderer;
using UnityEngine;
using UnityEngine.UI;

public class PdfRenderer : MonoBehaviour
{
    public RenderTexture pdfRenderTexture;
    public string filePath;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PDFDocument pdfDocument = new PDFDocument(filePath, "");
        Texture2D tex = pdfDocument.Renderer.RenderPageToTexture(new PDFPage(pdfDocument, 2), pdfRenderTexture.width, pdfRenderTexture.height);
        Graphics.Blit(tex, pdfRenderTexture);
    }

    
}
