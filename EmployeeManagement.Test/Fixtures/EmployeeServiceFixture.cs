using EmployeeManagement.Business;
using EmployeeManagement.DataAccess.Services;
using EmployeeManagement.Test.Services;

namespace EmployeeManagement.Test.Fixtures
{
    public class EmployeeServiceFixture : IDisposable
    {
        //get the instances using the property wrappers but cannot set the instances
        public IEmployeeManagementRepository EmployeeManagementTestDataRepository { get; }
        public EmployeeService EmployeeService { get; }

        public EmployeeServiceFixture()
        {
            EmployeeManagementTestDataRepository = new EmployeeManagementTestDataRepository();
            EmployeeService = new EmployeeService(EmployeeManagementTestDataRepository,new EmployeeFactory());
        }

        public void Dispose()
        {
            // clean up the setup code, if required
        }
    }
}
