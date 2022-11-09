public class Car {
    public string Rego { get; set; }
    public string Type { get; set; }
    public Customer Borrower { get; set; }

    public Car() {

    }

    public Car(string rego, string type) {
        this.Rego = rego;
        this.Type = type;
    }

    public void Borrow(Customer borrower) {
        this.Borrower = borrower;
    }

    public void Return() {
        this.Borrower = null;
    }

}

public class Garage {
    public List<Car> Cars { get; set; }

    // default constructor
    public Garage() {
        System.Console.WriteLine("In the Garage constructor!");
        this.Cars = new List<Car>();

        this.Cars.Add(new Car("ABC-123", "Sedan"));
        this.Cars.Add(new Car("QWF-123", "GoKart"));
        this.Cars.Add(new Car("ZXC-123", "Coupe"));
        this.Cars.Add(new Car("FYT-654", "Ford"));
        this.Cars.Add(new Car("1LL-123", "MarioKart"));
        this.Cars.Add(new Car("1LL-1PO", "SUV"));
        this.Cars.Add(new Car("HFG-976", "Lancia"));
    

    }




public static bool hasSpecialChar(string Rego)
    {
        string specialChar = @"ABC-123";
        foreach (var item in specialChar)
        {
            if (Rego.Contains(item)) return true;
        }

        return false;

    }


    public List<Car> ShowAllCars() {
        return this.Cars;
    }

    public List<Car> ShowBorrowedCars() {
        return this.Cars.FindAll((car) => car.Borrower != null);
    }

    public List<Car> ShowAvailableCars() {
        return this.Cars.FindAll((car) => car.Borrower == null);
    }
}