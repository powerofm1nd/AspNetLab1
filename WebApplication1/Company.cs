namespace WebApplication1;

public class Company
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string ZipCode { get; set; }
    public string Phone { get; set; }

    public string ToString()
    {
        return "Company: " + Name + ", " + Address + ", " + City + ", " + State + ", " + ZipCode + ", " + Phone;
    }
}