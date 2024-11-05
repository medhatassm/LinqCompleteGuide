namespace PajinationSystem;

class Program
{
    static void Main(string[] args)
    {
        var page = 1;
        var size = 10;

        Console.WriteLine("result per page: ");
        if (int.TryParse(Console.ReadLine(), out int resultPerPage))
        {
            size = resultPerPage;
        }

        Console.WriteLine("page No: ");
        if (int.TryParse(Console.ReadLine(), out int pageNo))
        {
            page = pageNo;
        }

        var emp = Repository.LoadEmployees();

        var result = emp.paginate(page, size);

        var resultCount = result.Count();

        var startRecord = ((page - 1) * size) + 1;

        var endRecord = resultCount < size
            ? startRecord + resultCount - 1
            : size * (page - 1) + size;

        result.Print($"Showing Employees {startRecord} - {endRecord}");
    }
}