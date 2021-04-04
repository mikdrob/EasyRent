using Applications.BLL.App.Services;
using Applications.DAL.App;
using Applications.DAL.App.Repositories;
using AutoMapper;
using BLL.App.Mappers;
using BLL.Base.Services;
using BLLAppDTO = BLL.App.DTO;
using DALAppDTO = DAL.App.DTO;

namespace BLL.App.Services
{
    public class ErApplicationService: BaseEntityService<IAppUnitOfWork, IErApplicationRepository, BLLAppDTO.ErApplication, DALAppDTO.ErApplication>, IErApplicationService
    {
        public ErApplicationService(IAppUnitOfWork serviceUow, IErApplicationRepository serviceRepository, IMapper mapper)
            : base(serviceUow, serviceRepository, new ErApplicationMapper(mapper))
        {
        }
    }
}