using Antra.CRMApp.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Antra.CRMApp.Core.Contract.Service
{
    public interface IRegionServiceAsync
    {
        Task<IEnumerable<RegionModel>> GetAllAsync();
        Task<int> AddRegionAsync(RegionModel model);
        Task<RegionModel> GetRegionByIdAsync(int id);
        Task<int> InsertRegionAsync(RegionModel model);
        Task<int> UpdateRegionAsync(RegionModel model);
        Task<int> DeleteRegionAsync(int id);
    }
}
