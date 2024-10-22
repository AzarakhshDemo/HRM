namespace meTesting.HRM.Services;

public interface IPersonelAttrributeService
{
    void SetAttribute<T>(int userId, PersonelAttributeAtom<T> attrKey, T value);
    T GetAttributeValue<T>(int userId, PersonelAttributeAtom<T> attrKey);

}
public sealed class PersonelAttributeEnum
{
    public static readonly PersonelAttributeAtom<string> GEO_LOCATION = "geo";
    public static readonly PersonelAttributeAtom<DateTime> HIRE_DATE = "hiredt";
    public static readonly PersonelAttributeAtom<DateTime> BIRTH_DATE = "bidt";
    public static readonly PersonelAttributeAtom<Gender> GENDER = "gn";
}
public enum Gender
{
    MALE = 1,
    FEMALE = 2,
    UNSPECIFIED = 3

}
public struct PersonelAttributeAtom<T> : IPersonelAttributeAtom
{
    public PersonelAttributeAtom()
    {
    }

    public string Name { get; set; }
    public Type Type => typeof(T);
    public static implicit operator PersonelAttributeAtom<T>(string Name) => new PersonelAttributeAtom<T> { Name = Name };
}

