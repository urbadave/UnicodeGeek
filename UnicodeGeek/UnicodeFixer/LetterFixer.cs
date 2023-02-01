namespace UnicodeFixer;

public class LetterFixer
{
    public int Code { get; set; }
    public bool Drop { get; set; }
    public bool Keep { get; set; }
    public string? Replace { get; set; }

    public LetterFixer() { }

    public LetterFixer(int code, bool drop, bool keep, string? replace)
    {
        Code = code;
        Drop = drop;
        Keep = keep;
        Replace = replace;
    }
}
