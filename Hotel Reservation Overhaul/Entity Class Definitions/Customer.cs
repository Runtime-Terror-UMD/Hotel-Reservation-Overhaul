class Customer
{
    private int customerID { get; set; }
    private string firstName { get; set; }
    private string lastName { get; set; }
    private int rewardPoints { get; set; }
    private decimal balance { get; set; }
    private string email { get; set; }
    private string password { get; set; }
    private string secretQuestion { get; set; }
    private string secretAnswer { get; set; }
    Customer(string first, string last, string email, string pass, string ques, string answr)
    {
        this.firstName = first;
        this.lastName = last;
        this.email = email;
        this.password = pass;
        this.secretQuestion = ques;
        this.secretAnswer = answr;
    }
}
