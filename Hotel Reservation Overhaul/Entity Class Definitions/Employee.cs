class Employee
{
    private int employeeID { get; set; }
    private string firstName { get; set; }
    private string lastName { get; set; }
    private string email { get; set; }
    private decimal salary { get; set; }
    private string password { get; set; }
    private string secretQuestion { get; set; }
    private string secretAnswer { get; set; }
    Employee(string first, string last, string e_mail, decimal slry, string pass, string ques, string answr)
    {
        //employeeID?? from database
        this.firstName = first;
        this.lastName = last;
        this.email = e_mail;
        this.salary = slry;
        this.password = pass;
        this.secretQuestion = ques;
        this.secretAnswer = answr;
    }
}

