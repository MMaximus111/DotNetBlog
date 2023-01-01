namespace DotNetBlog.Web.Data;

public class ThemeProvider
{
    public bool DarkTheme { get; set; } = true;

    public string GetStyle()
    {
        return DarkTheme ? "dark-theme" : "light-theme";
    }
}