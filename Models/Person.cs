namespace Api_ExampleASP.Models;

public class Person
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? NumberID { get; set; }
    public string? Email { get; set; }
    public string? TypeID { get; set; }
    public DateTime? CreationDate { get; set; }
    // Computed Rows :)
    public string? FullName { get; private set; }
    public string? TypeNumID { get; private set; }
}



