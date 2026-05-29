using SampleAPI.Models;

namespace SampleAPI.Data
{
    public interface IPersonRepo
    {
        public Person AddPerson(Person model);
    }
}
