namespace ConsoleApp21;

public class Teachers
{
    public int Id { get; set; }
    public string Name { get; set; }

    public int GroupId { get; set; }

    public override string ToString()
    {
        return $"Id {Id}\nName{Name}\nGroupId{GroupId}";
    }

}
