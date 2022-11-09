public class Customer {
    public string Name { get; set; }
    public int LicenceNo { get; set; }


    //constructor for customers
    public Customer (string name, int licenceNo){
        this.Name=name;
        this.LicenceNo=licenceNo;

        ValidateLicense();
    }
    

    public void ValidateLicense() {
        while (this.LicenceNo > 999999999) {
            this.LicenceNo = this.LicenceNo / 10;
        }


        while (this.LicenceNo<99999999) {
            this.LicenceNo = this.LicenceNo*10;
        }
        
    }
}

public class Group {
    public List<Customer> Customers { get; set; }

    // below is an example of a constructor, it creates an instance of the group object
    public Group() {
        System.Console.WriteLine("In the Group Constructor");
        this.Customers = new List<Customer>();
        
        this.Customers.Add(new Customer("GD Park", 113445778));
        this.Customers.Add(new Customer("Gilsoo Park", 113445878));
        this.Customers.Add(new Customer("Lisa", 125623674));
        this.Customers.Add(new Customer("Nicholas", 1029384756));
        this.Customers.Add(new Customer("Danniella", 90786474));
        this.Customers.Add(new Customer("Fred", 1647382950));
        this.Customers.Add(new Customer("Sarah", 057549439));
   
    }
}
    
