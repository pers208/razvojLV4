using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace razvojLV4
{
    class Program
    {
        static void Main(string[] args)
        {   //drugi zadatak
            //System.Threading.Thread.CurrentThread.CurrentCulture = System.Globalization.CultureInfo.InvariantCulture;
            Dataset dataset = new Dataset("csvfile.txt");
            Analyzer3rdParty analyzer = new Analyzer3rdParty();
            Adapter adapter = new Adapter(analyzer);
            double[] columnAverage = adapter.CalculateAveragePerColumn(dataset);
            double[] rowAverage = adapter.CalculateAveragePerRow(dataset);
            for (int i = 0; i < columnAverage.Length; i++)
            {
                Console.Write(columnAverage[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < rowAverage.Length; i++)
            {
                Console.Write(rowAverage[i] + " ");
            }

            //treci zadatak
            List<IRentable> rentables = new List<IRentable>();
            rentables.Add(new Video("Transformers"));
            rentables.Add(new Book("Hunger Games"));
            RentingConsolePrinter rentingConsolePrinter = new RentingConsolePrinter();
            rentingConsolePrinter.DisplayItems(rentables);
            rentingConsolePrinter.PrintTotalPrice(rentables);

            //cetvrti zadatak
            //uočavam da su HotItem objekti skuplji i imaju drugačiji opis
            Video hitVideo = new Video("Avengers");
            Book hitBook = new Book("Harry Potter");
            rentables.Add(new HotItem(hitVideo));
            rentables.Add(new HotItem(hitBook));
            Console.WriteLine("Hot items added!!");
            rentingConsolePrinter.DisplayItems(rentables);
            rentingConsolePrinter.PrintTotalPrice(rentables);

            //peti zadatak
            List<IRentable> flashSale = new List<IRentable>();
            flashSale.Add(new DiscountedItem(new Video("Transformers")));
            flashSale.Add(new DiscountedItem(new Book("Hunger Games")));
            Console.WriteLine("sasalele");
            rentingConsolePrinter.DisplayItems(flashSale);
            rentingConsolePrinter.PrintTotalPrice(flashSale);

            //sesti zadatak
            string firstMail = "matej.per@live.com";
            string secondMail = "matej.per@live.hr";
            string thirdMail = "matej.per@livecom";
            string fourthMail = "matej.perlive.com";
            EmailValidator emailValidator = new EmailValidator();
            Console.WriteLine(emailValidator.IsValidAddress(firstMail));
            Console.WriteLine(emailValidator.IsValidAddress(secondMail));
            Console.WriteLine(emailValidator.IsValidAddress(thirdMail));
            Console.WriteLine(emailValidator.IsValidAddress(fourthMail));
            string firstPassword = "aaa";
            string secondPassword = "Aaaaaaa";
            string thirdPassword = "Anavratise123";
            PasswordValidator passwordValidator = new PasswordValidator(6);
            Console.WriteLine(passwordValidator.IsValidPassword(firstPassword));
            Console.WriteLine(passwordValidator.IsValidPassword(secondPassword));
            Console.WriteLine(passwordValidator.IsValidPassword(thirdPassword));

            //sedmi zadatak
            UserValidator userValidator = new UserValidator();
            UserEntry.ReadUserFromConsole();
            while (!userValidator.IsUserEntryValid(UserEntry.ReadUserFromConsole()));
        }
    }
}
