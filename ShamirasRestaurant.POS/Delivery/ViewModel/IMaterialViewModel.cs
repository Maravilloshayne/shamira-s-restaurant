using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamirasRestaurant.POS.Delivery.ViewModel
{
    public interface IMaterialViewModel
    {
        IEnumerable<Domain.Models.Materials> Materials { get; }
        Domain.Models.Materials SelectedMaterial { get; set; }
    }
}
