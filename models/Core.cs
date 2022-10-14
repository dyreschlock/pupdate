namespace pannella.analoguepocket;

public class Core
{
    public string? identifier { get; set; }
    public Repo? repository { get; set; }
    public string? platform { get; set; }
    public Release release { get; set; }
    public Release? prerelease { get; set; }

    public override string ToString()
    {
        return platform + ": " + identifier;
    }
}