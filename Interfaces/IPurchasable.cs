namespace ConsoleTheater.Interfaces
{
    public interface IPurchasable
    {
        decimal Price { get; set; }
        string Type { get; set; }

        void PrintName();
    }
}

//interfaces similar to inheritance, interfaces are a contract. Class or struct that implements the interface must implement the members of the interface that are specified in the interface definition

//syntactical contract that all the classes inheriting the interface should follow