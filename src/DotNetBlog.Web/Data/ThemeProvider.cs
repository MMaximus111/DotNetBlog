namespace DotNetBlog.Web.Data;

public class ThemeProvider
{
    public bool DarkTheme { get; set; }

    public string GetStyle()
    {
        return DarkTheme ? "dark-theme" : "light-theme";
    }
}