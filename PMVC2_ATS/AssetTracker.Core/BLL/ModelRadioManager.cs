using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssetTracker.Core.Models;
using AssetTracker.Core.DAL;

namespace AssetTracker.Core.BLL
{
    public class ModelRadioManager
    {
        private readonly ModelRadioRepository _repository = new ModelRadioRepository();

        public IList<ModelForRadio> GetGeneralCategory()
        {

            return _repository.GetGeneralCategory();
        }
    }
}
