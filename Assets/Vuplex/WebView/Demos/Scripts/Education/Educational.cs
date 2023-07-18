using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuplex.WebView;

public class Educational : MonoBehaviour
{
    public CanvasWebViewPrefab browser;
    private string url;
    public InputField addressBar;

    // Start is called before the first frame update
    public void MathSimulation()
    {
        url = "https://phet.colorado.edu/sims/html/quadrilateral/latest/quadrilateral_all.html";
        addressBar.text = url;
        browser.WebView.LoadUrl(url);
    }

    public void PhysicsSimulation()
    {
        url = "https://phet.colorado.edu/sims/html/my-solar-system/latest/my-solar-system_all.html";
        addressBar.text = url;
        browser.WebView.LoadUrl(url);
    }

    public void ChemistrySimulation()
    {
        url = "https://phet.colorado.edu/sims/html/build-a-nucleus/latest/build-a-nucleus_all.html";
        addressBar.text = url;
        browser.WebView.LoadUrl(url);
    }

    public void BiologySimulation()
    {
        url = "https://phet.colorado.edu/sims/html/natural-selection/latest/natural-selection_all.html";
        addressBar.text = url;
        browser.WebView.LoadUrl(url);
    }
}
