var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

Garage garage = new Garage();
System.Console.WriteLine(garage.ShowAllCars().Count());

Group people = new Group();
List<Car> mycars = new List<Car>();
app.MapGet("/Cars/Add", (string rego, string type) => Addcar(rego, type));
app.MapGet("/Car", () => mycars);
void Addcar (string rego, string type) {
    Car newcar = new Car();
    newcar.Rego = rego;
    newcar.Type = type;

    if (rego.IndexOf('-', 0, rego.Length)< 3) {
        System.Console.WriteLine("Wrong Rego try again");

    }
    else if(rego.Length > 7){
        System.Console.WriteLine("Wrong Rego try again");
    }
    else if(rego.IndexOf('-', 4, 3)> 3) {
        System.Console.WriteLine("Write the rego again"); 
    }
    else if (rego.IndexOf('-', 0, rego.Length)== 3) {
        System.Console.WriteLine("Right rego number");
        
    mycars.Add(newcar);
    }

}

foreach(Car c in garage.Cars) {
    System.Console.WriteLine(c.Rego);
}

foreach(Customer c in people.Customers) {
    System.Console.WriteLine($"{c.LicenceNo} \t\t {c.Name}");
}


app.MapGet("/", () => "Hello World!");



app.Run();
