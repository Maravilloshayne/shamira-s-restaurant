using ShamirasRestaurant.Domain.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShamirasRestaurant.Domain.CustomModels
{
    public class CustomCategory : BaseModel
    {
        public string Name { get; set; }

        public Guid? ParentId { get; set; }

        public int ProductCount { get; set; }

        public int ChildCount { get; set; }

        public Visibility ShowProductsButton
        {
            get
            {
                return (this.ProductCount > 0 ? Visibility.Visible : Visibility.Collapsed);
            }
        }

        public Visibility ShowAddProductButton
        {
            get
            {
                return (this.ProductCount > 0 ? Visibility.Collapsed : Visibility.Visible);
            }
        }

        public Visibility ShowChildrenButton
        {
            get
            {
                return (this.ChildCount > 0 ? Visibility.Visible : Visibility.Collapsed);
            }
        }

        public Visibility ShowAddChildButton
        {
            get
            {
                return (this.ChildCount > 0 ? Visibility.Collapsed : Visibility.Visible);
            }
        }

        public class Visibility
        {
            internal static readonly Visibility Visible;
            internal static readonly Visibility Collapsed;
        }
    }

}


