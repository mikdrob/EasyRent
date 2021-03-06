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
        
        IDisputeStatusRepository DisputeStatuses { get; }
        IErApplicationRepository ErApplications { get; }

        IErApplicationStatusRepository ErApplicationStatuses { get; }
        IErUserRepository ErUsers { get; }
        IErUserReviewRepository ErUserReviews { get; }
        IErUserPictureRepository ErUserPictures { get; }
        IPropertyLocationRepository PropertyLocations { get; }
        IPropertyPictureRepository PropertyPictures { get; }
        IPropertyRepository Properties { get; }
        IPropertyReviewRepository PropertyReviews { get; }
        IPropertyTypeRepository PropertyTypes { get; }
        IGenderRepository Genders { get; }

        
    }
}