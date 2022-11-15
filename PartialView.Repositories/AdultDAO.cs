using PartialView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialView.Repositories
{
    public class AdultDAO
    {
        public AdultDAO()
        {

        }

        public IEnumerable<Adult> GetAll(JobType type)
        {
            // later we will use a database
            List<Adult> adults = new List<Adult>
            {
            new Adult{ Id=1, Voornaam="Jan", Naam="Janssens",
                EnrollDate =DateTime.Parse("2019-10-15"), Job=JobType.Student, ImagePath="stud_1.png" },
            new Adult{Id=2, Voornaam="Meredith",Naam="Alonso",
                EnrollDate=DateTime.Parse("2019-09-03"),  Job=JobType.Student, ImagePath="stud_2.png" },
            new Adult{Id=3, Voornaam="Piet", Naam="Vermeulen",
                 EnrollDate =DateTime.Parse("2019-09-10"),  Job=JobType.Student, ImagePath="stud_3.png" },
            new Adult{Id=4, Voornaam="Warre",Naam="Meeuws",
                 EnrollDate=DateTime.Parse("2019-09-03"),  Job=JobType.Student, ImagePath="stud_4.png" },
            new Adult{ Id=5, Voornaam="Christophe", Naam="De Waele",
                EnrollDate =DateTime.Parse("2010-10-15"), Job=JobType.Docent, ImagePath="lecture1.png" },
            new Adult{Id=6, Voornaam="Arne",Naam="Vandenbussche",
                EnrollDate=DateTime.Parse("2000-09-03"), Job=JobType.Docent, ImagePath="lecture2.png" },
            new Adult{Id=7, Voornaam="Yves", Naam="Seurynck",
                 EnrollDate =DateTime.Parse("2015-09-10"), Job=JobType.Docent, ImagePath="lecture3.png" },
            new Adult{Id=8, Voornaam="Warre",Naam="Meeuws",
                 EnrollDate=DateTime.Parse("2020-09-03"), Job=JobType.Docent, ImagePath="lecture4.png" },
            };

            // LINQ  (+/- SQL)

            // "select * from tblAdul where ..." 

            // => goes operator

            // Uitleg Lambda Expression
            // Expression lambda that has an expression as its body:
            //  (input-parameters) => expression

            // this  '=>' is the goes operator
            //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/lambda-expressions

            // uitleg LINQ
            // https://www.tutorialsteacher.com/linq/linq-method-syntax
            return adults.Where(a => a.Job == type); // adults -> only adults objects
        }

    }
}
