namespace LabPolymorphism;

public class MagicScroll : Artifact
{
    public MagicScroll(int id) : base(id) { }

    public override void Identify()
    {
        Console.WriteLine($"[Magic Scroll ID: {id}] Це сувій з закляттям вогню.");
    }
}
