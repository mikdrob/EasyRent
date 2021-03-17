using Applications.DAL.App.Repositories;
using Applications.DAL.Base;
using Applications.DAL.Base.Repositories;
using Domain.App;

namespace Applications.DAL.App
{
    public interface IAppUnitOfWork : IBaseUnitOfWork
    {
        IDisputeRepository Disputes { get; }
        
        // IDisputeStatusRepository DisputeStatuses { get; }
        // IErApplicationRepository ErApplications { get; }
        
        IBaseRepository<DisputeStatus> DisputeStatuses { get; }
        IBaseRepository<ErApplication> ErApplications { get; }
    }
}