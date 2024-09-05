namespace WebApplication1;

public class Company
{
    string Name {get; set;}
    string Address {get; set;}
    string City {get; set;}
    string State {get; set;}
    string ZipCode {get; set;}
    string Phone {get; set;}

    string ToString()
    {
        return "Company: " + Name + "," + Address + "," + City + "," + State + "," + ZipCode + "," + Phone;
    }
}