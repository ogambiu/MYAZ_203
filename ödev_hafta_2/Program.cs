namespace ödev_hafta_2
{
    class program
    {
        static void Main()
        {
            var employee = new Employee("ali", "şahin", 1);
            Employee employee1 = new Employee("arda", "ogan", 2);
            Employee employee2 = new Employee("umut", "yarrak", 3);


            crud Crud = new();
            Crud.createEmployee(employee);
            Crud.createEmployee(employee1);
            Crud.createEmployee(employee2);

            Crud.delEmployee(4);

            

        }
    }
}