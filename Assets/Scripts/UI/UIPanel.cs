public class UIPanel : CustomBehaviour
{
    public UIManager UIManager;

    public virtual void Initialize(UIManager uiManager)
    {
        UIManager = uiManager;
        GameManager = UIManager.GameManager;
    }

    public virtual void ShowPanel()
    {
        //if you use too many panel use that function for similar attributes
    }

    public virtual void HidePanel()
    {
        //if you use too many panel use that function for similar attributes

    }
}