using POS.Models.Setting;

namespace POS.DataAccess.IRepository.Setting
{
    public interface IFunctionRepository : IRepository<Function>
    {
        void Update(Function function);
    }
}
