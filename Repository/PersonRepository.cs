using Contact_UI.Models;
namespace Contact_UI.Repository
{
    public class PersonRepository
    {
        private static List<Person> persons = new List<Person>
        {
            
            new Person{Id = 1, Name ="asif", Email = "asif1@gmail.com", PhoneNumber = "01711111111", Message = "Hello, this is Asif."},
            new Person{Id = 2,Name="Riad", Email= "riad2@gmail.com", PhoneNumber = "01722222222", Message = "Hello, this is Riad."},
            new Person{Id = 3,Name = "rakib", Email = "rakib3@gmail.com", PhoneNumber = "01733333333", Message = "Hello, this is Rakib."}

        };
         
    
          public static void AddPerson(Person person)
        {
                person.Id  = persons.Count > 0 ? persons.Max(p => p.Id) + 1 : 1;
                persons.Add(person);
          }
    
          public static  List<Person> GetAllPersons()
        {
                return persons;
          }
    }
}
