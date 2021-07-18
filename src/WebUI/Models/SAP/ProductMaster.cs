using System;
using MvvmBlazor.ViewModel;

namespace GFCA.WebUI.Models.SAP
{
    public class ProductMaster : ViewModelBase
    {
        #region [ Fields ]

        private string _Code;
        private string _Name;
        private string _SaleOrg;
        private string _DistributionChannel;
        private string _MaterialGroup;
        private string _UOM;
        private int? _PerPack;
        private string _CustMatCode;
        private string _CustMatName;
        private string _CustUOM;
        private int? _CustPerPack;

        #endregion [ Fields ]
        #region [ Properties ]

        public string Code
        {
            get => _Code;
            set => Set(ref _Code, value);
        }
        public string Name
        {
            get => _Name;
            set => Set(ref _Name, value);
        }
        public string SaleOrg
        {
            get => _SaleOrg;
            set => Set(ref _SaleOrg, value);
        }
        public string DistributionChannel
        {
            get => _DistributionChannel;
            set => Set(ref _DistributionChannel, value);
        }
        public string MaterialGroup
        {
            get => _MaterialGroup;
            set => Set(ref _MaterialGroup, value);
        }
        public string UOM
        {
            get => _UOM;
            set => Set(ref _UOM, value);
        } //SAPUOM
        public int? PerPack
        {
            get => _PerPack;
            set => Set(ref _PerPack, value);
        }
        public string CustMatCode
        {
            get => _CustMatCode;
            set => Set(ref _CustMatCode, value);
        }
        public string CustMatName
        {
            get => _CustMatName;
            set => Set(ref _CustMatName, value);
        }
        public string CustUOM
        {
            get => _CustUOM;
            set => Set(ref _CustUOM, value);
        }
        public int? CustPerPack
        {
            get => _CustPerPack;
            set => Set(ref _CustPerPack, value);
        }

        #endregion [ Properties ]

        public ProductMaster()
        {
        }

    }
}
