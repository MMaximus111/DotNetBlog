namespace DotNetBlog.Web.Data;

public class ThemeProvider
{
    public bool DarkTheme { get; set; }

    public string GetStyle()
    {
        if (DarkTheme)
        {
            return "dark-theme";
        }

        return "light-theme";
    }
}