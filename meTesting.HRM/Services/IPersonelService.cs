namespace meTesting.HRM.Services;

public interface IPersonelService
{
    Personel Create(Personel inp);
    Personel Get(int id);
    IEnumerable<Personel> GetAll();
}

public class Personel
{
    public int Id { get; set; }
    public string Name { get; set; }
}
